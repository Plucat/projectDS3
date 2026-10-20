namespace Pelicula
{
    partial class VentanaPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPelicula));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbGuardar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            dgvPelicula = new DataGridView();
            IDPelicula = new DataGridViewTextBoxColumn();
            NombrePelicula = new DataGridViewTextBoxColumn();
            DuracionPelicula = new DataGridViewTextBoxColumn();
            IDGenero = new DataGridViewTextBoxColumn();
            IDClasificacion = new DataGridViewTextBoxColumn();
            txtIDPelicula = new TextBox();
            txtNombre = new TextBox();
            txtDuracion = new TextBox();
            txtIDGenero = new TextBox();
            txtIDClasificacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbCancelar, tsbGuardar, tsbEliminar, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1128, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(92, 29);
            tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(85, 29);
            tsbEditar.Text = "Editar";
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(106, 29);
            tsbCancelar.Text = "Cancelar";
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(103, 29);
            tsbGuardar.Text = "Guardar";
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(102, 29);
            tsbEliminar.Text = "Eliminar";
            // 
            // tsbSalir
            // 
            tsbSalir.Alignment = ToolStripItemAlignment.Right;
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(73, 29);
            tsbSalir.Text = "Salir";
            // 
            // dgvPelicula
            // 
            dgvPelicula.AllowUserToAddRows = false;
            dgvPelicula.AllowUserToDeleteRows = false;
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { IDPelicula, NombrePelicula, DuracionPelicula, IDGenero, IDClasificacion });
            dgvPelicula.Location = new Point(12, 50);
            dgvPelicula.MultiSelect = false;
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.ReadOnly = true;
            dgvPelicula.RowHeadersWidth = 62;
            dgvPelicula.Size = new Size(1104, 312);
            dgvPelicula.TabIndex = 1;
            // 
            // IDPelicula
            // 
            IDPelicula.HeaderText = "IDPelicula";
            IDPelicula.MinimumWidth = 8;
            IDPelicula.Name = "IDPelicula";
            IDPelicula.ReadOnly = true;
            IDPelicula.Width = 150;
            // 
            // NombrePelicula
            // 
            NombrePelicula.HeaderText = "Nombre";
            NombrePelicula.MinimumWidth = 8;
            NombrePelicula.Name = "NombrePelicula";
            NombrePelicula.ReadOnly = true;
            NombrePelicula.Width = 150;
            // 
            // DuracionPelicula
            // 
            DuracionPelicula.HeaderText = "Duracion";
            DuracionPelicula.MinimumWidth = 8;
            DuracionPelicula.Name = "DuracionPelicula";
            DuracionPelicula.ReadOnly = true;
            DuracionPelicula.Width = 150;
            // 
            // IDGenero
            // 
            IDGenero.HeaderText = "IDGenero";
            IDGenero.MinimumWidth = 8;
            IDGenero.Name = "IDGenero";
            IDGenero.ReadOnly = true;
            IDGenero.Width = 150;
            // 
            // IDClasificacion
            // 
            IDClasificacion.HeaderText = "IDClasificacion";
            IDClasificacion.MinimumWidth = 8;
            IDClasificacion.Name = "IDClasificacion";
            IDClasificacion.ReadOnly = true;
            IDClasificacion.Width = 150;
            // 
            // txtIDPelicula
            // 
            txtIDPelicula.Location = new Point(127, 392);
            txtIDPelicula.Name = "txtIDPelicula";
            txtIDPelicula.Size = new Size(150, 31);
            txtIDPelicula.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 456);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(409, 395);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(150, 31);
            txtDuracion.TabIndex = 4;
            txtDuracion.TextChanged += textBox3_TextChanged;
            // 
            // txtIDGenero
            // 
            txtIDGenero.Location = new Point(409, 456);
            txtIDGenero.Name = "txtIDGenero";
            txtIDGenero.Size = new Size(150, 31);
            txtIDGenero.TabIndex = 5;
            // 
            // txtIDClasificacion
            // 
            txtIDClasificacion.Location = new Point(783, 398);
            txtIDClasificacion.Name = "txtIDClasificacion";
            txtIDClasificacion.Size = new Size(150, 31);
            txtIDClasificacion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 392);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 7;
            label1.Text = "IDPelicula:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 456);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 395);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 9;
            label3.Text = "Duracion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 456);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 10;
            label4.Text = "IDGenero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 401);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 11;
            label5.Text = "IDClasificacion:";
            // 
            // VentanaPelicula
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 548);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIDClasificacion);
            Controls.Add(txtIDGenero);
            Controls.Add(txtDuracion);
            Controls.Add(txtNombre);
            Controls.Add(txtIDPelicula);
            Controls.Add(dgvPelicula);
            Controls.Add(toolStrip1);
            Name = "VentanaPelicula";
            Text = "Peliculas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbSalir;
        private DataGridView dgvPelicula;
        private DataGridViewTextBoxColumn IDPelicula;
        private DataGridViewTextBoxColumn NombrePelicula;
        private DataGridViewTextBoxColumn DuracionPelicula;
        private DataGridViewTextBoxColumn IDGenero;
        private DataGridViewTextBoxColumn IDClasificacion;
        private TextBox txtIDPelicula;
        private TextBox txtNombre;
        private TextBox txtDuracion;
        private TextBox txtIDGenero;
        private TextBox txtIDClasificacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}