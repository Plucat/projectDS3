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
            tsbVentanaPelicula = new ToolStrip();
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
            GeneroPelicula = new DataGridViewTextBoxColumn();
            ClasificacionPelicula = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            txtDuracion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbGenero = new ComboBox();
            cbClasificacion = new ComboBox();
            tsbVentanaPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            SuspendLayout();
            // 
            // tsbVentanaPelicula
            // 
            tsbVentanaPelicula.ImageScalingSize = new Size(24, 24);
            tsbVentanaPelicula.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbCancelar, tsbGuardar, tsbEliminar, tsbSalir });
            tsbVentanaPelicula.Location = new Point(0, 0);
            tsbVentanaPelicula.Name = "tsbVentanaPelicula";
            tsbVentanaPelicula.Size = new Size(1162, 34);
            tsbVentanaPelicula.TabIndex = 0;
            tsbVentanaPelicula.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(92, 29);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(85, 29);
            tsbEditar.Text = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(106, 29);
            tsbCancelar.Text = "Cancelar";
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(103, 29);
            tsbGuardar.Text = "Guardar";
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(102, 29);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbSalir
            // 
            tsbSalir.Alignment = ToolStripItemAlignment.Right;
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(73, 29);
            tsbSalir.Text = "Salir";
            tsbSalir.Click += tsbSalir_Click;
            // 
            // dgvPelicula
            // 
            dgvPelicula.AllowUserToAddRows = false;
            dgvPelicula.AllowUserToDeleteRows = false;
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { IDPelicula, NombrePelicula, DuracionPelicula, IDGenero, IDClasificacion, GeneroPelicula, ClasificacionPelicula });
            dgvPelicula.Location = new Point(12, 50);
            dgvPelicula.MultiSelect = false;
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.ReadOnly = true;
            dgvPelicula.RowHeadersWidth = 62;
            dgvPelicula.Size = new Size(1126, 312);
            dgvPelicula.TabIndex = 1;
            dgvPelicula.SelectionChanged += dgvPelicula_SelectionChanged;
            // 
            // IDPelicula
            // 
            IDPelicula.DataPropertyName = "IDPelicula";
            IDPelicula.HeaderText = "IDPelicula";
            IDPelicula.MinimumWidth = 8;
            IDPelicula.Name = "IDPelicula";
            IDPelicula.ReadOnly = true;
            IDPelicula.Width = 150;
            // 
            // NombrePelicula
            // 
            NombrePelicula.DataPropertyName = "NombrePelicula";
            NombrePelicula.HeaderText = "Nombre";
            NombrePelicula.MinimumWidth = 8;
            NombrePelicula.Name = "NombrePelicula";
            NombrePelicula.ReadOnly = true;
            NombrePelicula.Width = 150;
            // 
            // DuracionPelicula
            // 
            DuracionPelicula.DataPropertyName = "Duracion";
            DuracionPelicula.HeaderText = "Duracion";
            DuracionPelicula.MinimumWidth = 8;
            DuracionPelicula.Name = "DuracionPelicula";
            DuracionPelicula.ReadOnly = true;
            DuracionPelicula.Width = 150;
            // 
            // IDGenero
            // 
            IDGenero.DataPropertyName = "IDGenero";
            IDGenero.HeaderText = "IDGenero";
            IDGenero.MinimumWidth = 8;
            IDGenero.Name = "IDGenero";
            IDGenero.ReadOnly = true;
            IDGenero.Width = 150;
            // 
            // IDClasificacion
            // 
            IDClasificacion.DataPropertyName = "IDClasificacion";
            IDClasificacion.HeaderText = "IDClasificacion";
            IDClasificacion.MinimumWidth = 8;
            IDClasificacion.Name = "IDClasificacion";
            IDClasificacion.ReadOnly = true;
            IDClasificacion.Width = 150;
            // 
            // GeneroPelicula
            // 
            GeneroPelicula.DataPropertyName = "NombreGenero";
            GeneroPelicula.HeaderText = "Genero";
            GeneroPelicula.MinimumWidth = 8;
            GeneroPelicula.Name = "GeneroPelicula";
            GeneroPelicula.ReadOnly = true;
            GeneroPelicula.Width = 150;
            // 
            // ClasificacionPelicula
            // 
            ClasificacionPelicula.DataPropertyName = "Clave";
            ClasificacionPelicula.HeaderText = "Clasificacion";
            ClasificacionPelicula.MinimumWidth = 8;
            ClasificacionPelicula.Name = "ClasificacionPelicula";
            ClasificacionPelicula.ReadOnly = true;
            ClasificacionPelicula.Width = 150;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 392);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(128, 468);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(150, 31);
            txtDuracion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 392);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 468);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 9;
            label3.Text = "Duracion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 398);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 10;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 401);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 11;
            label5.Text = "Clasificacion:";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(415, 398);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(182, 33);
            cbGenero.TabIndex = 12;
            // 
            // cbClasificacion
            // 
            cbClasificacion.FormattingEnabled = true;
            cbClasificacion.Location = new Point(774, 398);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(182, 33);
            cbClasificacion.TabIndex = 13;
            // 
            // VentanaPelicula
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 548);
            Controls.Add(cbClasificacion);
            Controls.Add(cbGenero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDuracion);
            Controls.Add(txtNombre);
            Controls.Add(dgvPelicula);
            Controls.Add(tsbVentanaPelicula);
            Name = "VentanaPelicula";
            Text = "Peliculas";
            tsbVentanaPelicula.ResumeLayout(false);
            tsbVentanaPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsbVentanaPelicula;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbSalir;
        private DataGridView dgvPelicula;
        private TextBox txtNombre;
        private TextBox txtDuracion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbGenero;
        private ComboBox cbClasificacion;
        private DataGridViewTextBoxColumn IDPelicula;
        private DataGridViewTextBoxColumn NombrePelicula;
        private DataGridViewTextBoxColumn DuracionPelicula;
        private DataGridViewTextBoxColumn IDGenero;
        private DataGridViewTextBoxColumn IDClasificacion;
        private DataGridViewTextBoxColumn GeneroPelicula;
        private DataGridViewTextBoxColumn ClasificacionPelicula;
    }
}