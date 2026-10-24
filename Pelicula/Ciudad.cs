using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Pelicula
{
    public partial class Ciudad : Form
    {
        private bool Editar = false;
        private String conexion = "";
        public Ciudad()
        {
            InitializeComponent();
            conexion = "Server=localhost\\DS3;Database=Cine;Trusted_Connection=True;"
                        + "Integrated Security=true; TrustServerCertificate=true";

            llenaComboEstado();
            ObtenerDatosBD();

        }

        private void llenaComboEstado()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conexion))
                {
                    sqlConn.Open();
                    String consulta = "SELECT IDEstado, NombreEstado FROM dbo.Estado";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datos = new DataTable();
                    adapter.Fill(datos);
                    cmbEstado.DataSource = datos;
                    cmbEstado.ValueMember = "IDEstado";
                    cmbEstado.DisplayMember = "NombreEstado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void ObtenerDatosBD()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conexion))
                {
                    sqlConn.Open();
                    String consulta = "SELECT C.IDCiudad, C.IDEstado, E.NombreEstado, C.SiglasCiudad, C.ClaveCiudad, C.NombreCiudad FROM dbo.Ciudad C INNER JOIN dbo.Estado E ON E.IDEstado = C.IDEstado";
                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datos = new DataTable();
                    adapter.Fill(datos);
                    dgvCiudad.DataSource = datos;
                    dgvCiudad.Columns["IDEstado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            cmbEstado.Enabled = true;
            txtBoxSiglas.Enabled = true;
            txtBoxClave.Enabled = true;
            textBoxNombre.Enabled = true;

            botGuardar.Enabled = true;
            botCancelar.Enabled = true;
            botNuevo.Enabled = false;
            botEditar.Enabled = false;
            botEliminar.Enabled = false;
            botObtener.Enabled = false;
            botSalir1.Enabled = false;

            dgvCiudad.Enabled = false;

            txtBoxIDCiudad.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtBoxSiglas.Text = "";
            txtBoxClave.Text = "";
            textBoxNombre.Text = "";

        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            cmbEstado.Enabled = true;
            txtBoxSiglas.Enabled = true;
            txtBoxClave.Enabled = true;
            textBoxNombre.Enabled= true;

            botGuardar.Enabled = true;
            botCancelar.Enabled = true;
            botNuevo.Enabled = false;
            botEditar.Enabled = false;
            botEliminar.Enabled = false;
            botObtener.Enabled= false;
            botSalir1.Enabled = false;

            dgvCiudad.Enabled = false;
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            cmbEstado.Enabled= false;
            txtBoxSiglas.Enabled= false;
            txtBoxClave.Enabled= false;
            textBoxNombre.Enabled = false;

            botGuardar.Enabled= false;
            botCancelar.Enabled= false;
            botNuevo.Enabled= true;
            botEditar.Enabled= true;
            botEliminar.Enabled= true;
            botObtener.Enabled= true;
            botSalir1.Enabled= true;

            dgvCiudad.Enabled= true;
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false) // Nuevo, vamos a utilizar INSERT
            {
                try
                {
                    using (SqlConnection s = new SqlConnection(conexion))
                    {
                        s.Open();
                        string nuevo = "INSERT INTO dbo.Ciudad (IDEstado, SiglasCiudad, ClaveCiudad, NombreCiudad) VALUES (@IDEstado, @SiglasCiudad, @ClaveCiudad, @NombreCiudad)";
                        SqlCommand comando = new SqlCommand(nuevo, s);
                        comando.Parameters.AddWithValue("@IDEstado", cmbEstado.SelectedValue ?? DBNull.Value);
                        comando.Parameters.AddWithValue("@SiglasCiudad", txtBoxSiglas.Text);
                        comando.Parameters.AddWithValue("@ClaveCiudad", txtBoxClave.Text);
                        comando.Parameters.AddWithValue("@NombreCiudad", textBoxNombre.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al guardar el registro");
                        }
                    }

                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }

            }
            else
            {
                try
                {
                    using (SqlConnection s = new SqlConnection(conexion))
                    {
                        s.Open();
                        string actualizar = "UPDATE dbo.Ciudad SET IDEstado = @IDEstado  ,SiglasCiudad = @SiglasCiudad  ,ClaveCiudad = @ClaveCiudad  ,NombreCiudad = @NombreCiudad WHERE IDCiudad = @IDCiudad";
                        SqlCommand comando = new SqlCommand(actualizar, s);
                        comando.Parameters.AddWithValue("@IDEstado", cmbEstado.SelectedValue ?? DBNull.Value);
                        comando.Parameters.AddWithValue("@SiglasCiudad", txtBoxSiglas.Text);
                        comando.Parameters.AddWithValue("@ClaveCiudad", txtBoxClave.Text);
                        comando.Parameters.AddWithValue("@NombreCiudad", textBoxNombre.Text);
                        comando.Parameters.AddWithValue("@IDCiudad", txtBoxIDCiudad.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al guardar el registro");
                        }
                    }

                    ObtenerDatosBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }
            }

            cmbEstado.Enabled = false;
            txtBoxSiglas.Enabled = false;
            txtBoxClave.Enabled = false;
            textBoxNombre.Enabled = false;

            botGuardar.Enabled = false;
            botCancelar.Enabled = false;
            botNuevo.Enabled = true;
            botEditar.Enabled = true;
            botEliminar.Enabled = true;
            botObtener.Enabled = true;
            botSalir1.Enabled = true;

            dgvCiudad.Enabled = true;
        }

        private void dgvCiudad_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dgvCiudad.SelectedRows[0];
                txtBoxIDCiudad.Text = r.Cells["IDCiudad"].Value.ToString();
                if (r.Cells["IDEstado"].Value != DBNull.Value)
                {
                    cmbEstado.SelectedValue = r.Cells["IDEstado"].Value;
                }
                else
                {
                    cmbEstado.SelectedIndex = -1;
                }
                txtBoxSiglas.Text = r.Cells["SiglasCiudad"].Value.ToString();
                txtBoxClave.Text = r.Cells["ClaveCiudad"].Value.ToString();
                textBoxNombre.Text = r.Cells["NombreCiudad"].Value.ToString();
            }
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count == 1)
            {
                DialogResult resultado =
                    MessageBox.Show("¿Desea eliminar este registro?", "¿Eliminar?"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection s = new SqlConnection(conexion))
                        {
                            s.Open();
                            string eliminar = "DELETE FROM dbo.Ciudad WHERE IDCiudad = @IDCiudad";
                            SqlCommand comando = new SqlCommand(eliminar, s);
                            comando.Parameters.AddWithValue("@IDCiudad", txtBoxIDCiudad.Text);

                            int renglonesAfectados = comando.ExecuteNonQuery();
                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Éxito al eliminar el registro");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Excepción: " + ex.Message);
                    }

                    ObtenerDatosBD();
                }

            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar");
            }
        }

        private void botObtener_Click(object sender, EventArgs e)
        {
            ObtenerDatosBD();
        }

        private void botSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



