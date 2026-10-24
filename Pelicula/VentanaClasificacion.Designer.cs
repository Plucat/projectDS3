namespace Pelicula
{
    partial class VentanaClasificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaClasificacion));
            tsbVentanaClasificacion = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbGuardar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            dgvClasificacion = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpFechaCreacion = new DateTimePicker();
            txtClave = new TextBox();
            txtDescripcion = new TextBox();
            IDClasificacion = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            DescripcionGenero = new DataGridViewTextBoxColumn();
            FechaHoraCreacion = new DataGridViewTextBoxColumn();
            tsbVentanaClasificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).BeginInit();
            SuspendLayout();
            // 
            // tsbVentanaClasificacion
            // 
            tsbVentanaClasificacion.ImageScalingSize = new Size(24, 24);
            tsbVentanaClasificacion.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbCancelar, tsbGuardar, tsbEliminar, tsbSalir });
            tsbVentanaClasificacion.Location = new Point(0, 0);
            tsbVentanaClasificacion.Name = "tsbVentanaClasificacion";
            tsbVentanaClasificacion.Size = new Size(992, 34);
            tsbVentanaClasificacion.TabIndex = 2;
            tsbVentanaClasificacion.Text = "toolStrip1";
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
            // dgvClasificacion
            // 
            dgvClasificacion.AllowUserToAddRows = false;
            dgvClasificacion.AllowUserToDeleteRows = false;
            dgvClasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasificacion.Columns.AddRange(new DataGridViewColumn[] { IDClasificacion, Clave, DescripcionGenero, FechaHoraCreacion });
            dgvClasificacion.Location = new Point(12, 63);
            dgvClasificacion.Name = "dgvClasificacion";
            dgvClasificacion.ReadOnly = true;
            dgvClasificacion.RowHeadersWidth = 62;
            dgvClasificacion.Size = new Size(951, 252);
            dgvClasificacion.TabIndex = 3;
            dgvClasificacion.SelectionChanged += dgvClasificacion_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 412);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 4;
            label1.Text = "Clave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 337);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 5;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 337);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 6;
            label3.Text = "Fecha Hora";
            // 
            // dtpFechaCreacion
            // 
            dtpFechaCreacion.Format = DateTimePickerFormat.Custom;
            dtpFechaCreacion.Location = new Point(606, 412);
            dtpFechaCreacion.Name = "dtpFechaCreacion";
            dtpFechaCreacion.Size = new Size(303, 31);
            dtpFechaCreacion.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(88, 412);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(278, 373);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(254, 129);
            txtDescripcion.TabIndex = 9;
            // 
            // IDClasificacion
            // 
            IDClasificacion.DataPropertyName = "IDClasificacion";
            IDClasificacion.HeaderText = "IDClasificacion";
            IDClasificacion.MinimumWidth = 8;
            IDClasificacion.Name = "IDClasificacion";
            IDClasificacion.ReadOnly = true;
            IDClasificacion.Visible = false;
            IDClasificacion.Width = 150;
            // 
            // Clave
            // 
            Clave.DataPropertyName = "Clave";
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 8;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Width = 150;
            // 
            // DescripcionGenero
            // 
            DescripcionGenero.DataPropertyName = "Descripcion";
            DescripcionGenero.HeaderText = "Descripcion";
            DescripcionGenero.MinimumWidth = 8;
            DescripcionGenero.Name = "DescripcionGenero";
            DescripcionGenero.ReadOnly = true;
            DescripcionGenero.Width = 150;
            // 
            // FechaHoraCreacion
            // 
            FechaHoraCreacion.DataPropertyName = "FecharHoraCreacion";
            FechaHoraCreacion.HeaderText = "FechaHora de Creacion";
            FechaHoraCreacion.MinimumWidth = 8;
            FechaHoraCreacion.Name = "FechaHoraCreacion";
            FechaHoraCreacion.ReadOnly = true;
            FechaHoraCreacion.Width = 150;
            // 
            // VentanaClasificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 514);
            Controls.Add(txtDescripcion);
            Controls.Add(txtClave);
            Controls.Add(dtpFechaCreacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClasificacion);
            Controls.Add(tsbVentanaClasificacion);
            Name = "VentanaClasificacion";
            Text = "Clasificaciones";
            tsbVentanaClasificacion.ResumeLayout(false);
            tsbVentanaClasificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsbVentanaClasificacion;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbSalir;
        private DataGridView dgvClasificacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaCreacion;
        private TextBox txtClave;
        private TextBox txtDescripcion;
        private DataGridViewTextBoxColumn IDClasificacion;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn DescripcionGenero;
        private DataGridViewTextBoxColumn FechaHoraCreacion;
    }
}