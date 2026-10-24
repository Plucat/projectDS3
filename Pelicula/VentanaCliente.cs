using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace Pelicula;

public partial class VentanaCliente : VentanaOperacion
{
    public VentanaCliente() { InitializeComponent(); }
    protected override string Tabla => "Cliente";
    protected override string ColumnaId => "IDCliente";
    protected override string Consulta => """
        SELECT c.IDCliente, c.IDCiudad, c.Nombre, c.Celular, c.Correo,
               ci.NombreCiudad AS Ciudad, e.NombreEstado AS Estado
        FROM dbo.Cliente c
        INNER JOIN dbo.Ciudad ci ON ci.IDCiudad = c.IDCiudad
        INNER JOIN dbo.Estado e ON e.IDEstado = ci.IDEstado
        ORDER BY c.Nombre, c.IDCliente;
        """;
    protected override string Insertar => """
        INSERT INTO dbo.Cliente (IDCiudad, Nombre, Celular, Correo)
        OUTPUT INSERTED.IDCliente VALUES (@ciudad, @nombre, @celular, @correo);
        """;
    protected override string Modificar => """
        UPDATE dbo.Cliente SET IDCiudad = @ciudad, Nombre = @nombre, Celular = @celular, Correo = @correo
        OUTPUT INSERTED.IDCliente WHERE IDCliente = @id;
        """;
    protected override void CargarCatalogos() => LlenarCombo(cbCiudad, """
        SELECT c.IDCiudad, CONCAT(c.NombreCiudad, ' / ', e.NombreEstado) AS Nombre
        FROM dbo.Ciudad c INNER JOIN dbo.Estado e ON e.IDEstado = c.IDEstado ORDER BY Nombre;
        """, "IDCiudad");
    protected override void Limpiar()
    {
        txtNombre.Clear(); txtCelular.Clear(); txtCorreo.Clear(); cbCiudad.SelectedIndex = -1;
    }
    protected override void Mostrar(DataRow fila)
    {
        txtNombre.Text = Convert.ToString(fila["Nombre"]);
        txtCelular.Text = Convert.ToString(fila["Celular"]);
        txtCorreo.Text = Convert.ToString(fila["Correo"]);
        cbCiudad.SelectedValue = fila["IDCiudad"];
    }
    protected override bool Validar()
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text)) return Avisar("Escribe el nombre del cliente.", txtNombre);
        if (!Elegido(cbCiudad)) return Avisar("Selecciona una ciudad.", cbCiudad);
        string celular = txtCelular.Text.Trim();
        if (celular.Length > 0 && (celular.Length != 10 || celular.Any(c => c < '0' || c > '9')))
            return Avisar("El celular debe contener 10 dígitos o quedar vacío.", txtCelular);
        string correo = txtCorreo.Text.Trim();
        if (correo.Length > 0 && (!MailAddress.TryCreate(correo, out var direccion) || direccion.Address != correo))
            return Avisar("Escribe un correo válido o deja el campo vacío.", txtCorreo);
        return true;
    }
    protected override SqlParameter[] Parametros() => new[]
    {
        new SqlParameter("@ciudad", SqlDbType.Int) { Value = cbCiudad.SelectedValue },
        Texto("@nombre", 50, txtNombre.Text), Texto("@celular", 10, txtCelular.Text), Texto("@correo", 100, txtCorreo.Text)
    };
}

