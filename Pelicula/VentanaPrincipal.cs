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
            VentanaPelicula p = new VentanaPelicula();
            p.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
