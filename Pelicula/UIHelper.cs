using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Pelicula
{
    internal class UIHelper
    {
        public static void LimpiarControles(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                if (c is TextBox txt) // txt es el alias para hacer el clear mas corto
                {
                    txt.Clear();
                }
                else if (c is ComboBox cmb) 
                {
                    cmb.SelectedIndex = -1; // si esta vacio dara excepcion al elegir indice 0
                }
                else  if (c is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
                else if (c is CheckBox chk)
                    chk.Checked = false;
            }
        }





        public static void CambiarEstado(Control contenedor, ToolStrip barraBotones, DataGridView dgv, bool modoEdicion)
        {
            // desactiva y aciva dgv para no cambiar de opcion cuando se esta en modo edicion
            if (dgv != null)
            {
                dgv.Enabled = !modoEdicion;
            }

            foreach (Control c in contenedor.Controls)
            {
                if (c is TextBox txt)
                {
          
                    if (txt.Name.ToLower().Contains("id")) // caja id siempre desactivada
                        txt.Enabled = false;
                    else
                        txt.Enabled = modoEdicion;
                }
                else if (c is ComboBox || c is DateTimePicker || c is CheckBox)
                {
                    c.Enabled = modoEdicion;
                }
            }

           
            foreach (ToolStripItem item in barraBotones.Items)
            {
                if (item is ToolStripButton btn)
                {
                    string texto = btn.Text.ToLower();

                    // estos tres siempre tienen el mismo estado
                    if (texto.Contains("nuevo") || texto.Contains("editar") || texto.Contains("eliminar"))
                    {
                        btn.Enabled = !modoEdicion;
                    }
                    //solo cuando esta el modo editar
                    else if (texto.Contains("guardar") || texto.Contains("cancelar"))
                    {
                        btn.Enabled = modoEdicion;
                    }
                   
                }
            }
        }



        public static void LlenarCombo(ComboBox combo, string tabla, string columnaValor, string columnaMostrar)
        {
            // aqui no hay injection porque nosotros definimos los parametros
            string query = $"SELECT {columnaValor}, {columnaMostrar} FROM {tabla} ORDER BY {columnaMostrar}";
            combo.DataSource = DbHelper.Consultar(query);

            // la datatable tiene esos nombres de columna
            combo.ValueMember = columnaValor;
            combo.DisplayMember = columnaMostrar;
            combo.SelectedIndex = -1;
        }



       public static void ConfigurarGrid(DataGridView dgv)
       {

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.RowHeadersVisible = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name.StartsWith("ID", StringComparison.OrdinalIgnoreCase) || col.Name.EndsWith("ID", StringComparison.OrdinalIgnoreCase) || col.Name.Equals("ID", StringComparison.OrdinalIgnoreCase))
                {
                    col.Visible = false;
                }
            }


        }




    }
}
