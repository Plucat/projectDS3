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
    public partial class VentanaClasificacion : Form
    {
        private bool editar = false;
        public VentanaClasificacion()
        {
            InitializeComponent();

            UIHelper.ConfigurarGrid(dgvClasificacion);
            FilldgvClasificacion();
            UIHelper.CambiarEstado(this, tsbVentanaClasificacion, dgvClasificacion, false);
        }

        private void FilldgvClasificacion()
        {
            string qry = """
                SELECT * FROM Clasificacion;
                """;

            dgvClasificacion.DataSource = DbHelper.Consultar(qry);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            dgvClasificacion.ClearSelection();

            UIHelper.LimpiarControles(this);
            UIHelper.CambiarEstado(this, tsbVentanaClasificacion, dgvClasificacion, true);

            dtpFechaCreacion.Value = DateTime.Now;

            editar = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count >= 1)
            {
                UIHelper.CambiarEstado(this, tsbVentanaClasificacion, dgvClasificacion, true);
                editar = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            dgvClasificacion.ClearSelection();

            UIHelper.LimpiarControles(this);
            UIHelper.CambiarEstado(this, tsbVentanaClasificacion, dgvClasificacion, false);
        }


        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
                GuardarEditar();
            else
                GuardarNuevo();

            FilldgvClasificacion();
            UIHelper.CambiarEstado(this, tsbVentanaClasificacion, dgvClasificacion, false);
        }

        private void GuardarEditar()
        {
            // la fecha de creacion no se modifica
            string qry = @"
                UPDATE Clasificacion
                SET Clave = @clave,
                    Descripcion = @descripcion
                WHERE IDClasificacion = @IDClasificacion;
                ";

            SqlParameter[] parametros =
            {
                new SqlParameter("@clave", txtClave.Text.Trim()),
                new SqlParameter("@descripcion", txtDescripcion.Text.Trim()),
                new SqlParameter("@IDClasificacion", dgvClasificacion.CurrentRow.Cells["IDClasificacion"].Value)
            };

            DbHelper.Ejecutar(qry, parametros);
        }

        private void GuardarNuevo()
        {
            string qry = @"
                INSERT INTO Clasificacion(Clave, Descripcion, FecharHoraCreacion)
                VALUES (@clave, @descripcion, GETDATE());
                ";

            SqlParameter[] parametros =
            {
                new SqlParameter("@clave", txtClave.Text.Trim()),
                new SqlParameter("@descripcion", txtDescripcion.Text.Trim())
            };

            DbHelper.Ejecutar(qry, parametros);
        }



        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count >= 1)
            {
                DialogResult elm = MessageBox.Show("Estás seguro de eliminar esta clasificación?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (elm == DialogResult.No) return;

                string qry = @"
                    DELETE FROM Clasificacion
                    WHERE IDClasificacion = @IDClasificacion;
                    ";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@IDClasificacion", dgvClasificacion.CurrentRow.Cells["IDClasificacion"].Value)
                };

                DbHelper.Ejecutar(qry, parametros);
                FilldgvClasificacion();
            }
        }


        private void dgvClasificacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClasificacion.CurrentRow != null)
            {
                DataGridViewRow r = dgvClasificacion.CurrentRow;

                txtClave.Text = Convert.ToString(r.Cells["Clave"].Value);
                txtDescripcion.Text = Convert.ToString(r.Cells["DescripcionGenero"].Value);

                if (r.Cells["FechaHoraCreacion"].Value != DBNull.Value && r.Cells["FechaHoraCreacion"].Value != null)
                {
                    dtpFechaCreacion.Value = Convert.ToDateTime(r.Cells["FechaHoraCreacion"].Value);
                }

            }
        }
    }
}
