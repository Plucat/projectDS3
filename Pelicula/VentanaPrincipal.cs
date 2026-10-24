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
            VentanaPelicula p = new VentanaPelicula();
            p.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
