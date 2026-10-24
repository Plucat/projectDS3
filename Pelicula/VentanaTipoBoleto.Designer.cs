namespace Pelicula;

partial class VentanaTipoBoleto
{
    private TextBox txtClave = null!;
    private TextBox txtDescripcion = null!;
    private NumericUpDown numPrecio = null!;
    private Label lbltxtClave = null!;
    private Label lbltxtDescripcion = null!;
    private Label lblnumPrecio = null!;
    private void InitializeComponent()
    {
        SuspendLayout();
        Editor.SuspendLayout();
        txtClave = new TextBox();
        lbltxtClave = new Label();
        lbltxtClave.Text = "Clave *";
        lbltxtClave.AutoSize = true;
        lbltxtClave.Location = new Point(20, 14);
        txtClave.Name = "txtClave";
        txtClave.Location = new Point(20, 39);
        txtClave.Size = new Size(300, 27);
        txtClave.TabIndex = 0;
        txtClave.MaxLength = 10;
        Editor.Controls.Add(lbltxtClave);
        Editor.Controls.Add(txtClave);
        txtDescripcion = new TextBox();
        lbltxtDescripcion = new Label();
        lbltxtDescripcion.Text = "Descripción *";
        lbltxtDescripcion.AutoSize = true;
        lbltxtDescripcion.Location = new Point(360, 14);
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Location = new Point(360, 39);
        txtDescripcion.Size = new Size(390, 27);
        txtDescripcion.TabIndex = 1;
        txtDescripcion.MaxLength = 50;
        Editor.Controls.Add(lbltxtDescripcion);
        Editor.Controls.Add(txtDescripcion);
        numPrecio = new NumericUpDown();
        lblnumPrecio = new Label();
        ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
        lblnumPrecio.Text = "Precio *";
        lblnumPrecio.AutoSize = true;
        lblnumPrecio.Location = new Point(20, 99);
        numPrecio.Name = "numPrecio";
        numPrecio.Location = new Point(20, 124);
        numPrecio.Size = new Size(300, 27);
        numPrecio.TabIndex = 2;
        numPrecio.DecimalPlaces = 4;
        numPrecio.Minimum = -922337203685477.5808m;
        numPrecio.Maximum = 922337203685477.5807m;
        numPrecio.ThousandsSeparator = true;
        Editor.Controls.Add(lblnumPrecio);
        Editor.Controls.Add(numPrecio);
        ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
        Name = "VentanaTipoBoleto";
        Text = "Tipos de boleto";
        Editor.ResumeLayout(false);
        Editor.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
