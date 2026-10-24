using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace Pelicula;

// Comportamiento compartido de las pantallas de Operaciones.
public class VentanaOperacion : Form
{
    protected readonly Panel Editor = new() { Dock = DockStyle.Bottom, Height = 210 };
    protected readonly DataGridView Grid = new() { Dock = DockStyle.Fill, AutoGenerateColumns = true };
    private readonly ToolStrip barra = new() { Dock = DockStyle.Top, GripStyle = ToolStripGripStyle.Hidden };
    private readonly ToolStripButton nuevo = new("Nuevo"), editar = new("Editar"), guardar = new("Guardar"),
        cancelar = new("Cancelar"), eliminar = new("Eliminar"), actualizar = new("Actualizar"), salir = new("Salir");
    private readonly ToolStripLabel estado = new();
    private readonly ToolStripButton anterior = new("Anterior"), siguiente = new("Siguiente");
    private int pagina;
    private bool haySiguiente;
    private bool cargando;
    protected virtual int TamanoPagina => 0;
    protected bool EnEdicion { get; private set; }
    protected int? IdActual { get; private set; }
    protected virtual string Tabla => "";
    protected virtual string ColumnaId => "";
    protected virtual string Consulta => "";
    protected virtual string Insertar => "";
    protected virtual string Modificar => "";

    public VentanaOperacion()
    {
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 560);
        MinimumSize = new Size(900, 520);
        StartPosition = FormStartPosition.CenterParent;
        UIHelper.ConfigurarGrid(Grid);
        Grid.BackgroundColor = SystemColors.Window;
        barra.Items.AddRange(new ToolStripItem[] { nuevo, editar, guardar, cancelar, eliminar,
            new ToolStripSeparator(), actualizar, anterior, siguiente, estado, salir });
        anterior.Visible = siguiente.Visible = false;
        anterior.Click += (_, _) => EjecutarSeguro(() => Recargar(paginaSolicitada: pagina - 1));
        siguiente.Click += (_, _) => EjecutarSeguro(() => Recargar(paginaSolicitada: pagina + 1));
        salir.Alignment = ToolStripItemAlignment.Right;
        Controls.Add(Grid);
        Controls.Add(Editor);
        Controls.Add(barra);
        nuevo.Click += (_, _) => EjecutarSeguro(() =>
        {
            cargando = true;
            try { CargarCatalogos(); Grid.ClearSelection(); IdActual = null; Limpiar(); }
            finally { cargando = false; }
            CambiarEstado(true);
            Editor.SelectNextControl(null, true, true, true, false);
        });
        editar.Click += (_, _) => { if (IdActual.HasValue) CambiarEstado(true); };
        cancelar.Click += (_, _) => { CambiarEstado(false); MostrarSeleccion(); };
        guardar.Click += (_, _) => EjecutarSeguro(Guardar);
        eliminar.Click += (_, _) => EjecutarSeguro(Eliminar);
        actualizar.Click += (_, _) => EjecutarSeguro(() => Recargar(IdActual));
        salir.Click += (_, _) => Close();
        Grid.SelectionChanged += (_, _) => { if (!cargando && !EnEdicion) MostrarSeleccion(); };
        FormClosing += (_, e) =>
        {
            if (EnEdicion && MessageBox.Show(this, "¿Descartar los cambios sin guardar?", Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) e.Cancel = true;
        };
        CambiarEstado(false);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime || Tabla.Length == 0) return;
        EjecutarSeguro(() => Recargar());
    }

    private void Recargar(int? seleccionar = null, int? paginaSolicitada = null)
    {
        int destino = Math.Max(0, paginaSolicitada ?? pagina);
        DataTable datos = DbHelper.ConsultarOperacion(ConsultaDePagina(destino));
        if (TamanoPagina > 0 && destino > 0 && datos.Rows.Count == 0)
        {
            destino = 0;
            datos = DbHelper.ConsultarOperacion(ConsultaDePagina(destino));
        }
        bool otraPagina = TamanoPagina > 0 && datos.Rows.Count > TamanoPagina;
        if (otraPagina) datos.Rows.RemoveAt(datos.Rows.Count - 1);
        cargando = true;
        try
        {
            CargarCatalogos();
            Grid.DataSource = datos;
            UIHelper.ConfigurarGrid(Grid);
            if (Grid.Columns.Contains("Precio")) Grid.Columns["Precio"].DefaultCellStyle.Format = "N4";
            if (Grid.Columns.Contains("Fecha")) Grid.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (seleccionar.HasValue)
                foreach (DataGridViewRow fila in Grid.Rows)
                    if (Convert.ToInt32(fila.Cells[ColumnaId].Value) == seleccionar.Value)
                    {
                        Grid.CurrentCell = fila.Cells.Cast<DataGridViewCell>().First(c => c.Visible);
                        break;
                    }
            pagina = destino;
            haySiguiente = otraPagina;
            estado.Text = TamanoPagina > 0
                ? $"  Página {pagina + 1} · {datos.Rows.Count} ventas"
                : $"  {datos.Rows.Count} registros";
        }
        finally { cargando = false; }
        MostrarSeleccion();
    }

    private string ConsultaDePagina(int numero)
    {
        if (TamanoPagina == 0) return Consulta;
        // Valores internos enteros; la consulta de cada pantalla define su ORDER BY.
        return Consulta.TrimEnd().TrimEnd(';') +
            $" OFFSET {(long)numero * TamanoPagina} ROWS FETCH NEXT {TamanoPagina + 1} ROWS ONLY;";
    }

    private void MostrarSeleccion()
    {
        if (Grid.SelectedRows.Count > 0 && Grid.CurrentRow?.DataBoundItem is DataRowView fila)
        {
            IdActual = Convert.ToInt32(fila[ColumnaId]);
            Mostrar(fila.Row);
        }
        else { IdActual = null; Limpiar(); }
        CambiarEstado(false);
    }

    private void CambiarEstado(bool edicion)
    {
        EnEdicion = edicion;
        Editor.Enabled = edicion;
        Grid.Enabled = !edicion;
        nuevo.Enabled = actualizar.Enabled = !edicion;
        editar.Enabled = eliminar.Enabled = !edicion && IdActual.HasValue;
        guardar.Enabled = cancelar.Enabled = edicion;
        anterior.Visible = siguiente.Visible = TamanoPagina > 0;
        anterior.Enabled = !edicion && pagina > 0;
        siguiente.Enabled = !edicion && haySiguiente;
    }

    private void Guardar()
    {
        if (!Validar()) return;
        var parametros = Parametros().ToList();
        if (IdActual.HasValue) parametros.Add(new SqlParameter("@id", SqlDbType.Int) { Value = IdActual.Value });
        int id = DbHelper.GuardarOperacion(IdActual.HasValue ? Modificar : Insertar, parametros.ToArray());
        CambiarEstado(false);
        Recargar(id, IdActual.HasValue ? pagina : 0);
    }

    private void Eliminar()
    {
        if (!IdActual.HasValue || MessageBox.Show(this, "¿Eliminar el registro seleccionado?", Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        // Tabla y columna son constantes internas; el ID siempre se envía como parámetro.
        DbHelper.GuardarOperacion($"DELETE FROM dbo.[{Tabla}] OUTPUT DELETED.[{ColumnaId}] WHERE [{ColumnaId}] = @id;",
            new[] { new SqlParameter("@id", SqlDbType.Int) { Value = IdActual.Value } });
        Recargar();
    }

    private void EjecutarSeguro(Action accion)
    {
        try { accion(); }
        catch (SqlException ex)
        {
            string mensaje = ex.Number == 547
                ? "No se pudo realizar la operación. El registro está relacionado con otros datos (por ejemplo, ventas), o una referencia ya no existe."
                : "No se pudo acceder a la base de datos Cine. Comprueba la conexión y vuelve a intentarlo.\n\n" + ex.Message;
            MessageBox.Show(this, mensaje, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (DataException ex)
        { MessageBox.Show(this, "No se pudieron cargar los datos.\n\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        catch (InvalidOperationException ex)
        { MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    protected virtual void CargarCatalogos() { }
    protected virtual void Limpiar() { }
    protected virtual void Mostrar(DataRow fila) { }
    protected virtual bool Validar() => true;
    protected virtual SqlParameter[] Parametros() => Array.Empty<SqlParameter>();

    protected bool Avisar(string mensaje, Control control)
    {
        MessageBox.Show(this, mensaje, "Revisar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        control.Focus();
        return false;
    }

    protected static void LlenarCombo(ComboBox combo, string consulta, string valor, bool opcional = false)
    {
        DataTable datos = DbHelper.ConsultarOperacion(consulta);
        if (opcional) datos = AgregarOpcionSinCliente(datos);
        combo.DisplayMember = "Nombre";
        combo.ValueMember = valor;
        combo.DataSource = datos;
        combo.SelectedIndex = opcional ? 0 : -1;
    }

    internal static DataTable AgregarOpcionSinCliente(DataTable origen)
    {
        // La opción vacía pertenece a la interfaz: no hereda IDENTITY, NOT NULL
        // ni columnas de solo lectura que pueda devolver SQL Server.
        var opciones = new DataTable();
        foreach (DataColumn columna in origen.Columns)
            opciones.Columns.Add(columna.ColumnName, columna.DataType);
        DataRow vacio = opciones.NewRow();
        vacio["Nombre"] = "Sin cliente";
        opciones.Rows.Add(vacio);
        foreach (DataRow fila in origen.Rows)
            opciones.Rows.Add(fila.ItemArray);
        return opciones;
    }

    protected static bool Elegido(ComboBox combo) => combo.SelectedValue is int;
    protected static SqlParameter Texto(string nombre, int longitud, string valor) =>
        new(nombre, SqlDbType.VarChar, longitud) { Value = string.IsNullOrWhiteSpace(valor) ? DBNull.Value : valor.Trim() };
}

