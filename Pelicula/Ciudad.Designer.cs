namespace Pelicula
{
    partial class Ciudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudad));
            toolStrip1 = new ToolStrip();
            botNuevo = new ToolStripButton();
            botEditar = new ToolStripButton();
            botCancelar = new ToolStripButton();
            botGuardar = new ToolStripButton();
            botEliminar = new ToolStripButton();
            botSalir1 = new ToolStripButton();
            botObtener = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxIDCiudad = new TextBox();
            txtBoxSiglas = new TextBox();
            label4 = new Label();
            textBoxNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtBoxClave = new TextBox();
            txtBoxEstado = new TextBox();
            dgvCiudad = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudad).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botNuevo, botEditar, botCancelar, botGuardar, botEliminar, botSalir1, botObtener });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(960, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // botNuevo
            // 
            botNuevo.Image = (Image)resources.GetObject("botNuevo.Image");
            botNuevo.ImageTransparentColor = Color.Magenta;
            botNuevo.Name = "botNuevo";
            botNuevo.Size = new Size(76, 24);
            botNuevo.Text = "Nuevo";
            botNuevo.Click += botNuevo_Click;
            // 
            // botEditar
            // 
            botEditar.Image = (Image)resources.GetObject("botEditar.Image");
            botEditar.ImageTransparentColor = Color.Magenta;
            botEditar.Name = "botEditar";
            botEditar.Size = new Size(72, 24);
            botEditar.Text = "Editar";
            botEditar.Click += botEditar_Click;
            // 
            // botCancelar
            // 
            botCancelar.Image = (Image)resources.GetObject("botCancelar.Image");
            botCancelar.ImageTransparentColor = Color.Magenta;
            botCancelar.Name = "botCancelar";
            botCancelar.Size = new Size(90, 24);
            botCancelar.Text = "Cancelar";
            botCancelar.Click += botCancelar_Click;
            // 
            // botGuardar
            // 
            botGuardar.Image = (Image)resources.GetObject("botGuardar.Image");
            botGuardar.ImageTransparentColor = Color.Magenta;
            botGuardar.Name = "botGuardar";
            botGuardar.Size = new Size(86, 24);
            botGuardar.Text = "Guardar";
            botGuardar.Click += botGuardar_Click;
            // 
            // botEliminar
            // 
            botEliminar.Image = (Image)resources.GetObject("botEliminar.Image");
            botEliminar.ImageTransparentColor = Color.Magenta;
            botEliminar.Name = "botEliminar";
            botEliminar.Size = new Size(87, 24);
            botEliminar.Text = "Eliminar";
            // 
            // botSalir1
            // 
            botSalir1.Alignment = ToolStripItemAlignment.Right;
            botSalir1.Image = (Image)resources.GetObject("botSalir1.Image");
            botSalir1.ImageTransparentColor = Color.Magenta;
            botSalir1.Name = "botSalir1";
            botSalir1.Size = new Size(62, 24);
            botSalir1.Text = "Salir";
            // 
            // botObtener
            // 
            botObtener.Image = (Image)resources.GetObject("botObtener.Image");
            botObtener.ImageTransparentColor = Color.Magenta;
            botObtener.Name = "botObtener";
            botObtener.Size = new Size(128, 24);
            botObtener.Text = "Obtener datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 373);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 416);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Siglas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 373);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "IDCiudad";
            // 
            // txtBoxIDCiudad
            // 
            txtBoxIDCiudad.Location = new Point(136, 370);
            txtBoxIDCiudad.Name = "txtBoxIDCiudad";
            txtBoxIDCiudad.Size = new Size(125, 27);
            txtBoxIDCiudad.TabIndex = 5;
            // 
            // txtBoxSiglas
            // 
            txtBoxSiglas.Location = new Point(136, 413);
            txtBoxSiglas.Name = "txtBoxSiglas";
            txtBoxSiglas.Size = new Size(125, 27);
            txtBoxSiglas.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 455);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(136, 452);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 370);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 420);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 11;
            label6.Text = "Clave";
            // 
            // txtBoxClave
            // 
            txtBoxClave.Location = new Point(546, 416);
            txtBoxClave.Name = "txtBoxClave";
            txtBoxClave.Size = new Size(125, 27);
            txtBoxClave.TabIndex = 12;
            // 
            // txtBoxEstado
            // 
            txtBoxEstado.Location = new Point(546, 370);
            txtBoxEstado.Name = "txtBoxEstado";
            txtBoxEstado.Size = new Size(125, 27);
            txtBoxEstado.TabIndex = 13;
            // 
            // dgvCiudad
            // 
            dgvCiudad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudad.Location = new Point(12, 41);
            dgvCiudad.Name = "dgvCiudad";
            dgvCiudad.RowHeadersWidth = 51;
            dgvCiudad.Size = new Size(802, 300);
            dgvCiudad.TabIndex = 14;
            // 
            // Ciudad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 553);
            Controls.Add(dgvCiudad);
            Controls.Add(txtBoxEstado);
            Controls.Add(txtBoxClave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxNombre);
            Controls.Add(label4);
            Controls.Add(txtBoxSiglas);
            Controls.Add(txtBoxIDCiudad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Ciudad";
            Text = "Ciudad";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton botNuevo;
        private ToolStripButton botEditar;
        private ToolStripButton botCancelar;
        private ToolStripButton botGuardar;
        private ToolStripButton botEliminar;
        private ToolStripButton botSalir1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxIDCiudad;
        private TextBox txtBoxSiglas;
        private Label label4;
        private TextBox textBoxNombre;
        private Label label5;
        private Label label6;
        private TextBox txtBoxClave;
        private TextBox txtBoxEstado;
        private DataGridView dgvCiudad;
        private ToolStripButton botObtener;
    }
}