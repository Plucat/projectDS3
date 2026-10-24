using Microsoft.Data.SqlClient;
using System.Data;

namespace Pelicula;

public partial class VentanaFuncion : VentanaOperacion
{
    public VentanaFuncion() { InitializeComponent(); }
    protected override string Tabla => "Funcion";
    protected override string ColumnaId => "IDFuncion";
    protected override string Consulta => """
        SELECT f.IDFuncion, f.IDPelicula, f.IDSala, p.NombrePelicula AS Película,
               su.Nombre AS Sucursal, s.NumeroSala AS Sala, f.Fecha,
               CASE WHEN f.Hora IS NULL THEN NULL ELSE
               STUFF(RIGHT('0000' + CAST(f.Hora AS varchar(4)), 4), 3, 0, ':') END AS Horario,
               f.Hora AS IDHora
        FROM dbo.Funcion f INNER JOIN dbo.Pelicula p ON p.IDPelicula = f.IDPelicula
        INNER JOIN dbo.Sala s ON s.IDSala = f.IDSala
        INNER JOIN dbo.Sucursal su ON su.IDSucursal = s.IDSucursal
        ORDER BY f.Fecha DESC, f.Hora, f.IDFuncion;
        """;
    protected override string Insertar => """
        INSERT INTO dbo.Funcion (IDPelicula, IDSala, Fecha, Hora)
        OUTPUT INSERTED.IDFuncion VALUES (@pelicula, @sala, @fecha, @hora);
        """;
    protected override string Modificar => """
        UPDATE dbo.Funcion SET IDPelicula = @pelicula, IDSala = @sala, Fecha = @fecha, Hora = @hora
        OUTPUT INSERTED.IDFuncion WHERE IDFuncion = @id;
        """;
    protected override void CargarCatalogos()
    {
        LlenarCombo(cbPelicula, "SELECT IDPelicula, NombrePelicula AS Nombre FROM dbo.Pelicula ORDER BY NombrePelicula;", "IDPelicula");
        LlenarCombo(cbSala, """
            SELECT s.IDSala, CONCAT(su.Nombre, ' / Sala ', s.NumeroSala, ' / ', s.TipoSala, ' (#', s.IDSala, ')') AS Nombre
            FROM dbo.Sala s INNER JOIN dbo.Sucursal su ON su.IDSucursal = s.IDSucursal
            ORDER BY su.Nombre, s.NumeroSala;
            """, "IDSala");
    }
    protected override void Limpiar()
    {
        cbPelicula.SelectedIndex = cbSala.SelectedIndex = -1;
        dtFecha.Value = DateTime.Today; dtFecha.Checked = true;
        dtHora.Value = DateTime.Today.AddHours(12); dtHora.Checked = true;
    }
    protected override void Mostrar(DataRow fila)
    {
        cbPelicula.SelectedValue = fila["IDPelicula"]; cbSala.SelectedValue = fila["IDSala"];
        dtFecha.Value = fila.IsNull("Fecha") ? DateTime.Today : Convert.ToDateTime(fila["Fecha"]);
        dtFecha.Checked = !fila.IsNull("Fecha");
        int hora = fila.IsNull("IDHora") ? 1200 : Convert.ToInt32(fila["IDHora"]);
        dtHora.Value = DateTime.Today.AddHours(Math.Clamp(hora / 100, 0, 23)).AddMinutes(Math.Clamp(hora % 100, 0, 59));
        dtHora.Checked = !fila.IsNull("IDHora");
    }
    protected override bool Validar()
    {
        if (!Elegido(cbPelicula)) return Avisar("Selecciona una película.", cbPelicula);
        if (!Elegido(cbSala)) return Avisar("Selecciona una sala.", cbSala);
        return true;
    }
    protected override SqlParameter[] Parametros() => new[]
    {
        new SqlParameter("@pelicula", SqlDbType.Int) { Value = cbPelicula.SelectedValue },
        new SqlParameter("@sala", SqlDbType.Int) { Value = cbSala.SelectedValue },
        new SqlParameter("@fecha", SqlDbType.Date) { Value = dtFecha.Checked ? dtFecha.Value.Date : DBNull.Value },
        // El script del profesor utiliza HHmm como entero: 12:30 se almacena como 1230.
        new SqlParameter("@hora", SqlDbType.Int) { Value = dtHora.Checked ? dtHora.Value.Hour * 100 + dtHora.Value.Minute : DBNull.Value }
    };
}

