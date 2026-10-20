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
        }

        private void botNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txtBoxEstado.Enabled = true;
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
            txtBoxEstado.Text = "";
            txtBoxSiglas.Text = "";
            txtBoxClave.Text = "";
            textBoxNombre.Text = "";

        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            txtBoxEstado.Enabled = true;
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
            txtBoxEstado.Enabled= false;
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
            if (Editar == false)
            {
                try
                {
                    using (SqlConnection s = new SqlConnection(conexion))
                    {
                        
                    }
                } catch (Exception ex) {
            }
        }
    }
}
