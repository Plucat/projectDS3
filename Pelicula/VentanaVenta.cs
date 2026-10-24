using Microsoft.Data.SqlClient;
using System.Data;

namespace Pelicula;

public partial class VentanaVenta : VentanaOperacion
{
    public VentanaVenta()
    {
        InitializeComponent();
        // Solo cambiar la tarifa cuando el usuario elija un tipo, nunca al consultar una venta histórica.
        cbTipoBoleto.SelectionChangeCommitted += (_, _) =>
        {
            if (EnEdicion && cbTipoBoleto.SelectedItem is DataRowView tipo)
                numPrecio.Value = tipo.Row.IsNull("Precio") ? 0 : Convert.ToDecimal(tipo["Precio"]);
        };
    }
    protected override int TamanoPagina => 100;
    protected override string Tabla => "Venta";
    protected override string ColumnaId => "IDVenta";
    protected override string Consulta => """
        SELECT v.IDVenta, v.IDCliente, v.IDFuncion, v.IDTipoBoleto,
               COALESCE(c.Nombre, 'Sin cliente') AS Cliente, p.NombrePelicula AS Película,
               su.Nombre AS Sucursal, s.NumeroSala AS Sala, f.Fecha,
               CASE WHEN f.Hora IS NULL THEN NULL ELSE
               STUFF(RIGHT('0000' + CAST(f.Hora AS varchar(4)), 4), 3, 0, ':') END AS Horario,
               t.Clave AS Boleto, v.Precio
        FROM dbo.Venta v LEFT JOIN dbo.Cliente c ON c.IDCliente = v.IDCliente
        INNER JOIN dbo.Funcion f ON f.IDFuncion = v.IDFuncion
        INNER JOIN dbo.Pelicula p ON p.IDPelicula = f.IDPelicula
        INNER JOIN dbo.Sala s ON s.IDSala = f.IDSala
        INNER JOIN dbo.Sucursal su ON su.IDSucursal = s.IDSucursal
        INNER JOIN dbo.TipoBoleto t ON t.IDTipoBoleto = v.IDTipoBoleto
        ORDER BY v.IDVenta DESC;
        """;
    protected override string Insertar => """
        INSERT INTO dbo.Venta (IDCliente, IDFuncion, IDTipoBoleto, Precio)
        OUTPUT INSERTED.IDVenta VALUES (@cliente, @funcion, @tipo, @precio);
        """;
    protected override string Modificar => """
        UPDATE dbo.Venta SET IDCliente = @cliente, IDFuncion = @funcion, IDTipoBoleto = @tipo, Precio = @precio
        OUTPUT INSERTED.IDVenta WHERE IDVenta = @id;
        """;
    protected override void CargarCatalogos()
    {
        LlenarCombo(cbCliente, "SELECT IDCliente, CONCAT(Nombre, ' (#', IDCliente, ')') AS Nombre FROM dbo.Cliente ORDER BY Nombre;", "IDCliente", true);
        LlenarCombo(cbFuncion, """
            SELECT f.IDFuncion, CONCAT('#', f.IDFuncion, ' / ', p.NombrePelicula, ' / ', su.Nombre,
                ' / Sala ', s.NumeroSala, ' / ', COALESCE(CONVERT(varchar(10), f.Fecha, 103), 'Sin fecha'),
                ' ', COALESCE(STUFF(RIGHT('0000' + CAST(f.Hora AS varchar(4)), 4), 3, 0, ':'), 'Sin hora')) AS Nombre
            FROM dbo.Funcion f INNER JOIN dbo.Pelicula p ON p.IDPelicula = f.IDPelicula
            INNER JOIN dbo.Sala s ON s.IDSala = f.IDSala
            INNER JOIN dbo.Sucursal su ON su.IDSucursal = s.IDSucursal
            ORDER BY f.Fecha DESC, f.Hora, f.IDFuncion;
            """, "IDFuncion");
        LlenarCombo(cbTipoBoleto, """
            SELECT IDTipoBoleto, CONCAT(Clave, ' / ', Descripcion, ' (#', IDTipoBoleto, ')') AS Nombre, Precio
            FROM dbo.TipoBoleto ORDER BY Clave, IDTipoBoleto;
            """, "IDTipoBoleto");
    }
    protected override void Limpiar()
    {
        cbCliente.SelectedIndex = cbCliente.Items.Count > 0 ? 0 : -1;
        cbFuncion.SelectedIndex = cbTipoBoleto.SelectedIndex = -1;
        numPrecio.Value = 0;
    }
    protected override void Mostrar(DataRow fila)
    {
        if (fila.IsNull("IDCliente")) cbCliente.SelectedIndex = 0;
        else cbCliente.SelectedValue = fila["IDCliente"];
        cbFuncion.SelectedValue = fila["IDFuncion"];
        cbTipoBoleto.SelectedValue = fila["IDTipoBoleto"];
        numPrecio.Value = Convert.ToDecimal(fila["Precio"]);
    }
    protected override bool Validar()
    {
        if (!Elegido(cbFuncion)) return Avisar("Selecciona una función.", cbFuncion);
        if (!Elegido(cbTipoBoleto)) return Avisar("Selecciona un tipo de boleto.", cbTipoBoleto);
        if (numPrecio.Value < 0) return Avisar("El precio no puede ser negativo.", numPrecio);
        return true;
    }
    protected override SqlParameter[] Parametros() => new[]
    {
        new SqlParameter("@cliente", SqlDbType.Int) { Value = Elegido(cbCliente) ? cbCliente.SelectedValue : DBNull.Value },
        new SqlParameter("@funcion", SqlDbType.Int) { Value = cbFuncion.SelectedValue },
        new SqlParameter("@tipo", SqlDbType.Int) { Value = cbTipoBoleto.SelectedValue },
        new SqlParameter("@precio", SqlDbType.Money) { Value = numPrecio.Value }
    };
}

