namespace Pelicula;

partial class VentanaFuncion
{
    private ComboBox cbPelicula = null!;
    private ComboBox cbSala = null!;
    private DateTimePicker dtFecha = null!;
    private DateTimePicker dtHora = null!;
    private Label lblcbPelicula = null!;
    private Label lblcbSala = null!;
    private Label lbldtFecha = null!;
    private Label lbldtHora = null!;
    private void InitializeComponent()
    {
        SuspendLayout();
        Editor.SuspendLayout();
        cbPelicula = new ComboBox();
        lblcbPelicula = new Label();
        lblcbPelicula.Text = "Película *";
        lblcbPelicula.AutoSize = true;
        lblcbPelicula.Location = new Point(20, 14);
        cbPelicula.Name = "cbPelicula";
        cbPelicula.Location = new Point(20, 39);
        cbPelicula.Size = new Size(300, 27);
        cbPelicula.TabIndex = 0;
        cbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
        cbPelicula.DropDownWidth = 550;
        Editor.Controls.Add(lblcbPelicula);
        Editor.Controls.Add(cbPelicula);
        cbSala = new ComboBox();
        lblcbSala = new Label();
        lblcbSala.Text = "Sucursal / Sala *";
        lblcbSala.AutoSize = true;
        lblcbSala.Location = new Point(360, 14);
        cbSala.Name = "cbSala";
        cbSala.Location = new Point(360, 39);
        cbSala.Size = new Size(390, 27);
        cbSala.TabIndex = 1;
        cbSala.DropDownStyle = ComboBoxStyle.DropDownList;
        cbSala.DropDownWidth = 550;
        Editor.Controls.Add(lblcbSala);
        Editor.Controls.Add(cbSala);
        dtFecha = new DateTimePicker();
        lbldtFecha = new Label();
        lbldtFecha.Text = "Fecha (desmarcar = sin fecha)";
        lbldtFecha.AutoSize = true;
        lbldtFecha.Location = new Point(20, 99);
        dtFecha.Name = "dtFecha";
        dtFecha.Location = new Point(20, 124);
        dtFecha.Size = new Size(300, 27);
        dtFecha.TabIndex = 2;
        dtFecha.ShowCheckBox = true;
        dtFecha.Format = DateTimePickerFormat.Custom;
        dtFecha.CustomFormat = "dd/MM/yyyy";
        Editor.Controls.Add(lbldtFecha);
        Editor.Controls.Add(dtFecha);
        dtHora = new DateTimePicker();
        lbldtHora = new Label();
        lbldtHora.Text = "Hora (desmarcar = sin hora)";
        lbldtHora.AutoSize = true;
        lbldtHora.Location = new Point(360, 99);
        dtHora.Name = "dtHora";
        dtHora.Location = new Point(360, 124);
        dtHora.Size = new Size(180, 27);
        dtHora.TabIndex = 3;
        dtHora.ShowCheckBox = true;
        dtHora.Format = DateTimePickerFormat.Custom;
            dtHora.CustomFormat = "HH:mm";
            dtHora.ShowUpDown = true;
        Editor.Controls.Add(lbldtHora);
        Editor.Controls.Add(dtHora);
        Name = "VentanaFuncion";
        Text = "Funciones";
        Editor.ResumeLayout(false);
        Editor.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}

