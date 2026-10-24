namespace Pelicula
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void OPEtsmFuncion_Click(object sender, EventArgs e)
        {
            using var ventana = new VentanaFuncion();
            ventana.ShowDialog(this);
        }

        private void OPEtsmVenta_Click(object sender, EventArgs e)
        {
            using var ventana = new VentanaVenta();
            ventana.ShowDialog(this);
        }

        private void OPEtsmCliente_Click(object sender, EventArgs e)
        {
            using var ventana = new VentanaCliente();
            ventana.ShowDialog(this);
        }

        private void OPEtsmTipoBoleto_Click(object sender, EventArgs e)
        {
            using var ventana = new VentanaTipoBoleto();
            ventana.ShowDialog(this);
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
