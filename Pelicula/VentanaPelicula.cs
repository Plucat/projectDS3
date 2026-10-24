using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelicula
{
    public partial class VentanaPelicula : Form
    {

        private bool editar = false;
        public VentanaPelicula()
        {
            InitializeComponent();

            UIHelper.ConfigurarGrid(dgvPelicula);
            FilldgvPelicula();
            UIHelper.CambiarEstado(this, tsbVentanaPelicula, dgvPelicula, false);

            UIHelper.LlenarCombo(cbGenero, "Genero", "IDGenero", "NombreGenero");
            UIHelper.LlenarCombo(cbClasificacion, "Clasificacion", "IDClasificacion", "Clave");
        }

        private void FilldgvPelicula()
        {
            string qry = """
                SELECT P.IDPelicula, P.NombrePelicula, P.Duracion, P.IDGenero, P.IDClasificacion, G.NombreGenero, C.Clave FROM Pelicula AS P
                INNER JOIN Genero AS G ON P.IDGenero = G.IDGENERO
                INNER JOIN Clasificacion AS C ON P.IDClasificacion = C.IDClasificacion;
                """;

            dgvPelicula.DataSource = DbHelper.Consultar(qry);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            dgvPelicula.ClearSelection(); // tiene que ir antes que las demas que limpian, no se porque no limpian si haces despues el clear

            UIHelper.LimpiarControles(this);
            UIHelper.CambiarEstado(this, tsbVentanaPelicula, dgvPelicula, true);
            UIHelper.LlenarCombo(cbGenero, "Genero", "IDGenero", "NombreGenero");
            UIHelper.LlenarCombo(cbClasificacion, "Clasificacion", "IDClasificacion", "Clave");

            editar = false;

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvPelicula.SelectedRows.Count >= 1) // no funciono ocn el .current
            {
                UIHelper.CambiarEstado(this, tsbVentanaPelicula, dgvPelicula, true);
                editar = true;
            }
                

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            dgvPelicula.ClearSelection(); // limpair lo seleccionado en el dgv visualmente

            UIHelper.LimpiarControles(this);
            UIHelper.CambiarEstado(this, tsbVentanaPelicula, dgvPelicula, false);

        }

        private void dgvPelicula_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPelicula.CurrentRow != null) // directamente la row apuntada el la tabla
            {
                DataGridViewRow r = dgvPelicula.CurrentRow;

                txtNombre.Text = Convert.ToString(r.Cells["NombrePelicula"].Value);
                txtDuracion.Text = Convert.ToString(r.Cells["DuracionPelicula"].Value);

                cbGenero.SelectedValue = r.Cells["IDGenero"].Value;
                cbClasificacion.SelectedValue = r.Cells["IDClasificacion"].Value;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
                GuardarEditar();
            else
                GuardarNuevo();

            UIHelper.CambiarEstado(this, tsbVentanaPelicula, dgvPelicula, false);

 

        }

        private void GuardarEditar()
        {
            string qry = @"
                UPDATE Pelicula
                SET NombrePelicula = @nombre,
                    Duracion = @Duracion,
                    IDGenero = @IDGenero,
                    IDClasificacion = @IDClasificacion
                WHERE IDPelicula = @IDPelicula;
                ";

            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre", txtNombre.Text.Trim()),
                new SqlParameter("@Duracion", Convert.ToInt32( txtDuracion.Text.Trim() )),
                new SqlParameter("@IDGenero", cbGenero.SelectedValue),
                new SqlParameter("@IDClasificacion", cbClasificacion.SelectedValue),
                new SqlParameter("@IDPelicula", dgvPelicula.CurrentRow.Cells["IDPelicula"].Value)
            };

            DbHelper.Ejecutar(qry, parametros);
            FilldgvPelicula();
        }

        private void GuardarNuevo() 
        {
            string qry = @"
                INSERT INTO Pelicula(NombrePelicula, Duracion, IDGenero, IDClasificacion)
                VALUES (@nombre, @Duracion, @IDGenero, @IDClasificacion);
                ";

            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre", txtNombre.Text.Trim()),
                new SqlParameter("@Duracion", Convert.ToInt32( txtDuracion.Text.Trim() )),
                new SqlParameter("@IDGenero", cbGenero.SelectedValue),
                new SqlParameter("@IDClasificacion", cbClasificacion.SelectedValue),
            };

            DbHelper.Ejecutar(qry, parametros);
            FilldgvPelicula();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPelicula.SelectedRows.Count >= 1) 
            {
                DialogResult elm = MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (elm == DialogResult.No) return; // si dijo que no, no lo elimina

                // es un dato de la tabla entonces no es necesario darle la proteccion de parametro
                string qry = $@"
                DELETE FROM Pelicula
                WHERE IDPelicula = {dgvPelicula.CurrentRow.Cells["IDPelicula"].Value};
                ";

                DbHelper.Ejecutar(qry);
                FilldgvPelicula();
            }
        }
    }
}
