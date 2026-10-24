using Microsoft.Data.SqlClient;
using System.Data;

namespace Pelicula;

public partial class VentanaTipoBoleto : VentanaOperacion
{
    public VentanaTipoBoleto() { InitializeComponent(); }
    protected override string Tabla => "TipoBoleto";
    protected override string ColumnaId => "IDTipoBoleto";
    protected override string Consulta => "SELECT IDTipoBoleto, Clave, Descripcion AS Descripción, Precio FROM dbo.TipoBoleto ORDER BY Clave, IDTipoBoleto;";
    protected override string Insertar => """
        INSERT INTO dbo.TipoBoleto (Clave, Descripcion, Precio)
        OUTPUT INSERTED.IDTipoBoleto VALUES (@clave, @descripcion, @precio);
        """;
    protected override string Modificar => """
        UPDATE dbo.TipoBoleto SET Clave = @clave, Descripcion = @descripcion, Precio = @precio
        OUTPUT INSERTED.IDTipoBoleto WHERE IDTipoBoleto = @id;
        """;
    protected override void Limpiar()
    {
        txtClave.Clear(); txtDescripcion.Clear(); numPrecio.Value = 0;
    }
    protected override void Mostrar(DataRow fila)
    {
        txtClave.Text = Convert.ToString(fila["Clave"]);
        txtDescripcion.Text = Convert.ToString(fila["Descripción"]);
        numPrecio.Value = fila.IsNull("Precio") ? 0 : Convert.ToDecimal(fila["Precio"]);
    }
    protected override bool Validar()
    {
        if (string.IsNullOrWhiteSpace(txtClave.Text)) return Avisar("Escribe la clave del tipo de boleto.", txtClave);
        if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return Avisar("Escribe la descripción del tipo de boleto.", txtDescripcion);
        if (numPrecio.Value < 0) return Avisar("El precio no puede ser negativo.", numPrecio);
        return true;
    }
    protected override SqlParameter[] Parametros() => new[]
    {
        Texto("@clave", 10, txtClave.Text), Texto("@descripcion", 50, txtDescripcion.Text),
        new SqlParameter("@precio", SqlDbType.Money) { Value = numPrecio.Value }
    };
}

