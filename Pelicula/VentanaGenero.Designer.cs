namespace Pelicula
{
    partial class VentanaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGenero));
            tsbVentanaGenero = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbGuardar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            dgvGenero = new DataGridView();
            IDGenero = new DataGridViewTextBoxColumn();
            NombreGenero = new DataGridViewTextBoxColumn();
            DescripcionGenero = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            tsbVentanaGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenero).BeginInit();
            SuspendLayout();
            // 
            // tsbVentanaGenero
            // 
            tsbVentanaGenero.ImageScalingSize = new Size(24, 24);
            tsbVentanaGenero.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbCancelar, tsbGuardar, tsbEliminar, tsbSalir });
            tsbVentanaGenero.Location = new Point(0, 0);
            tsbVentanaGenero.Name = "tsbVentanaGenero";
            tsbVentanaGenero.Size = new Size(1112, 34);
            tsbVentanaGenero.TabIndex = 1;
            tsbVentanaGenero.Text = "toolStrip1";
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
            // dgvGenero
            // 
            dgvGenero.AllowUserToAddRows = false;
            dgvGenero.AllowUserToDeleteRows = false;
            dgvGenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenero.Columns.AddRange(new DataGridViewColumn[] { IDGenero, NombreGenero, DescripcionGenero });
            dgvGenero.Location = new Point(12, 57);
            dgvGenero.Name = "dgvGenero";
            dgvGenero.ReadOnly = true;
            dgvGenero.RowHeadersWidth = 62;
            dgvGenero.Size = new Size(1088, 252);
            dgvGenero.TabIndex = 2;
            dgvGenero.SelectionChanged += dgvGenero_SelectionChanged;
            // 
            // IDGenero
            // 
            IDGenero.DataPropertyName = "IDGenero";
            IDGenero.HeaderText = "IDGenero";
            IDGenero.MinimumWidth = 8;
            IDGenero.Name = "IDGenero";
            IDGenero.ReadOnly = true;
            IDGenero.Visible = false;
            IDGenero.Width = 150;
            // 
            // NombreGenero
            // 
            NombreGenero.DataPropertyName = "NombreGenero";
            NombreGenero.HeaderText = "Nombre Genero";
            NombreGenero.MinimumWidth = 8;
            NombreGenero.Name = "NombreGenero";
            NombreGenero.ReadOnly = true;
            NombreGenero.Width = 150;
            // 
            // DescripcionGenero
            // 
            DescripcionGenero.DataPropertyName = "DescripcionGenero";
            DescripcionGenero.HeaderText = "Descripcion Genero";
            DescripcionGenero.MinimumWidth = 8;
            DescripcionGenero.Name = "DescripcionGenero";
            DescripcionGenero.ReadOnly = true;
            DescripcionGenero.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 369);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(653, 312);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(515, 349);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(393, 127);
            txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 369);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 31);
            txtNombre.TabIndex = 6;
            // 
            // VentanaGenero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 488);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGenero);
            Controls.Add(tsbVentanaGenero);
            Name = "VentanaGenero";
            Text = "Genero";
            tsbVentanaGenero.ResumeLayout(false);
            tsbVentanaGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsbVentanaGenero;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbSalir;
        private DataGridView dgvGenero;
        private DataGridViewTextBoxColumn IDGenero;
        private DataGridViewTextBoxColumn NombreGenero;
        private DataGridViewTextBoxColumn DescripcionGenero;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
    }
}