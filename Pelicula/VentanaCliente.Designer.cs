namespace Pelicula;

partial class VentanaCliente
{
    private TextBox txtNombre = null!;
    private ComboBox cbCiudad = null!;
    private TextBox txtCelular = null!;
    private TextBox txtCorreo = null!;
    private Label lbltxtNombre = null!;
    private Label lblcbCiudad = null!;
    private Label lbltxtCelular = null!;
    private Label lbltxtCorreo = null!;
    private void InitializeComponent()
    {
        SuspendLayout();
        Editor.SuspendLayout();
        txtNombre = new TextBox();
        lbltxtNombre = new Label();
        lbltxtNombre.Text = "Nombre *";
        lbltxtNombre.AutoSize = true;
        lbltxtNombre.Location = new Point(20, 14);
        txtNombre.Name = "txtNombre";
        txtNombre.Location = new Point(20, 39);
        txtNombre.Size = new Size(300, 27);
        txtNombre.TabIndex = 0;
        txtNombre.MaxLength = 50;
        Editor.Controls.Add(lbltxtNombre);
        Editor.Controls.Add(txtNombre);
        cbCiudad = new ComboBox();
        lblcbCiudad = new Label();
        lblcbCiudad.Text = "Ciudad *";
        lblcbCiudad.AutoSize = true;
        lblcbCiudad.Location = new Point(360, 14);
        cbCiudad.Name = "cbCiudad";
        cbCiudad.Location = new Point(360, 39);
        cbCiudad.Size = new Size(390, 27);
        cbCiudad.TabIndex = 1;
        cbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCiudad.DropDownWidth = 550;
        Editor.Controls.Add(lblcbCiudad);
        Editor.Controls.Add(cbCiudad);
        txtCelular = new TextBox();
        lbltxtCelular = new Label();
        lbltxtCelular.Text = "Celular (opcional)";
        lbltxtCelular.AutoSize = true;
        lbltxtCelular.Location = new Point(20, 99);
        txtCelular.Name = "txtCelular";
        txtCelular.Location = new Point(20, 124);
        txtCelular.Size = new Size(300, 27);
        txtCelular.TabIndex = 2;
        txtCelular.MaxLength = 10;
        Editor.Controls.Add(lbltxtCelular);
        Editor.Controls.Add(txtCelular);
        txtCorreo = new TextBox();
        lbltxtCorreo = new Label();
        lbltxtCorreo.Text = "Correo (opcional)";
        lbltxtCorreo.AutoSize = true;
        lbltxtCorreo.Location = new Point(360, 99);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Location = new Point(360, 124);
        txtCorreo.Size = new Size(390, 27);
        txtCorreo.TabIndex = 3;
        txtCorreo.MaxLength = 100;
        Editor.Controls.Add(lbltxtCorreo);
        Editor.Controls.Add(txtCorreo);
        Name = "VentanaCliente";
        Text = "Clientes";
        Editor.ResumeLayout(false);
        Editor.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
