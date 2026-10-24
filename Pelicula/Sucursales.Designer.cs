namespace Pelicula
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            toolStrip1 = new ToolStrip();
            botNuevo = new ToolStripButton();
            botEditar = new ToolStripButton();
            botEliminar = new ToolStripButton();
            botGuardar = new ToolStripButton();
            botCancelar = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            botSalir = new ToolStripButton();
            dataGridView1 = new DataGridView();
            lblIDSucursal = new Label();
            textBox1 = new TextBox();
            Direccion = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botNuevo, botEditar, botEliminar, botGuardar, botCancelar, toolStripButton6, botSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // botNuevo
            // 
            botNuevo.Image = (Image)resources.GetObject("botNuevo.Image");
            botNuevo.ImageTransparentColor = Color.Magenta;
            botNuevo.Name = "botNuevo";
            botNuevo.Size = new Size(76, 24);
            botNuevo.Text = "Nuevo";
            // 
            // botEditar
            // 
            botEditar.Image = (Image)resources.GetObject("botEditar.Image");
            botEditar.ImageTransparentColor = Color.Magenta;
            botEditar.Name = "botEditar";
            botEditar.Size = new Size(72, 24);
            botEditar.Text = "Editar";
            // 
            // botEliminar
            // 
            botEliminar.Image = (Image)resources.GetObject("botEliminar.Image");
            botEliminar.ImageTransparentColor = Color.Magenta;
            botEliminar.Name = "botEliminar";
            botEliminar.Size = new Size(87, 24);
            botEliminar.Text = "Eliminar";
            // 
            // botGuardar
            // 
            botGuardar.Image = (Image)resources.GetObject("botGuardar.Image");
            botGuardar.ImageTransparentColor = Color.Magenta;
            botGuardar.Name = "botGuardar";
            botGuardar.Size = new Size(86, 24);
            botGuardar.Text = "Guardar";
            // 
            // botCancelar
            // 
            botCancelar.Image = (Image)resources.GetObject("botCancelar.Image");
            botCancelar.ImageTransparentColor = Color.Magenta;
            botCancelar.Name = "botCancelar";
            botCancelar.Size = new Size(90, 24);
            botCancelar.Text = "Cancelar";
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(128, 24);
            toolStripButton6.Text = "Obtener datos";
            // 
            // botSalir
            // 
            botSalir.Alignment = ToolStripItemAlignment.Right;
            botSalir.Image = (Image)resources.GetObject("botSalir.Image");
            botSalir.ImageTransparentColor = Color.Magenta;
            botSalir.Name = "botSalir";
            botSalir.Size = new Size(62, 24);
            botSalir.Text = "Salir";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 281);
            dataGridView1.TabIndex = 1;
            // 
            // lblIDSucursal
            // 
            lblIDSucursal.AutoSize = true;
            lblIDSucursal.Location = new Point(32, 332);
            lblIDSucursal.Name = "lblIDSucursal";
            lblIDSucursal.Size = new Size(78, 20);
            lblIDSucursal.TabIndex = 2;
            lblIDSucursal.Text = "IDSucursal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(32, 388);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(72, 20);
            Direccion.TabIndex = 4;
            Direccion.Text = "Direccion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 385);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 374);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 336);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(438, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 388);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "Ciudad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(438, 380);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(Direccion);
            Controls.Add(textBox1);
            Controls.Add(lblIDSucursal);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "Sucursales";
            Text = "Sucursales";
            Load += Sucursales_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton botNuevo;
        private ToolStripButton botEditar;
        private ToolStripButton botEliminar;
        private ToolStripButton botGuardar;
        private ToolStripButton botCancelar;
        private ToolStripButton toolStripButton6;
        private ToolStripButton botSalir;
        private DataGridView dataGridView1;
        private Label lblIDSucursal;
        private TextBox textBox1;
        private Label Direccion;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private ComboBox comboBox1;
    }
}