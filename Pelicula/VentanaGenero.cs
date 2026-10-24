using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelicula
{
    public partial class VentanaGenero : Form
    {
        private bool editar = false;
        public VentanaGenero()
        {
            InitializeComponent();

            UIHelper.ConfigurarGrid(dgvGenero);
            FilldgvGenero();
            UIHelper.CambiarEstado(this, tsbVentanaGenero, dgvGenero, false);
        }

        private void FilldgvGenero()
        {
            string qry = """
                SELECT * FROM Genero;
                """;

            dgvGenero.DataSource = DbHelper.Consultar(qry);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            dgvGenero.ClearSelection();

            UIHelper.LimpiarControles(this);
            UIHelper.CambiarEstado(this, tsbVentanaGenero, dgvGenero, true);

            editar = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvGenero.SelectedRows.Count >= 1)
            {
                UIHelper.CambiarEstado(this, tsbVentanaGenero, dgvGenero, true);
                editar = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            dgvGenero.ClearSelection();

            UIHelper.LimpiarControles(this);
            UIHelper.CambiarEstado(this, tsbVentanaGenero, dgvGenero, false);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
                GuardarEditar();
            else
                GuardarNuevo();

            FilldgvGenero();
            UIHelper.CambiarEstado(this, tsbVentanaGenero, dgvGenero, false);

        }

        private void GuardarEditar()
        {
            string qry = @"
                UPDATE Genero
                SET NombreGenero = @nombre,
                    DescripcionGenero = @Descripcion
                WHERE IDGenero = @IDGenero;
                ";

            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre", txtNombre.Text.Trim()),
                new SqlParameter("@Descripcion", txtDescripcion.Text.Trim()),
                new SqlParameter("@IDGenero", dgvGenero.CurrentRow.Cells["IDGenero"].Value)
            };

            DbHelper.Ejecutar(qry, parametros);
        }

        private void GuardarNuevo()
        {
            string qry = @"
                INSERT INTO Genero(NombreGenero, DescripcionGenero)
                VALUES (@nombre, @Descripcion);
                ";

            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre", txtNombre.Text.Trim()),
                new SqlParameter("@Descripcion", txtDescripcion.Text.Trim()),
            };

            DbHelper.Ejecutar(qry, parametros);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGenero.SelectedRows.Count >= 1)
            {
                DialogResult elm = MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (elm == DialogResult.No) return;

                string qry = $@"
                DELETE FROM Genero
                WHERE IDGenero = {dgvGenero.CurrentRow.Cells["IDGenero"].Value};
                ";

                DbHelper.Ejecutar(qry);
                FilldgvGenero();
            }
        }

        private void dgvGenero_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGenero.CurrentRow != null)
            {
                DataGridViewRow r = dgvGenero.CurrentRow;

                txtNombre.Text = Convert.ToString(r.Cells["NombreGenero"].Value);
                txtDescripcion.Text = Convert.ToString(r.Cells["DescripcionGenero"].Value);

            }
        }
    }
}
