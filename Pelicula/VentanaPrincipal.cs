namespace Pelicula
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void CARtsmPelicula_Click(object sender, EventArgs e)
        {
            VentanaPelicula ventana = new VentanaPelicula();
            ventana.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CARtsmGenero_Click(object sender, EventArgs e)
        {
            VentanaGenero ventana = new VentanaGenero();
            ventana.ShowDialog();
        }

        private void CARtsmClasificacion_Click(object sender, EventArgs e)
        {
            VentanaClasificacion ventana = new VentanaClasificacion();
            ventana.ShowDialog();
        }
    }
}
