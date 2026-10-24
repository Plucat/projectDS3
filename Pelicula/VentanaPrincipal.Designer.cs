namespace Pelicula
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmCartelera = new ToolStripMenuItem();
            CARtsmPelicula = new ToolStripMenuItem();
            CARtsmGenero = new ToolStripMenuItem();
            CARtsmClasificacion = new ToolStripMenuItem();
            tsmInfraestructura = new ToolStripMenuItem();
            INFtsmSucursal = new ToolStripMenuItem();
            INFtsmSala = new ToolStripMenuItem();
            INFtsmCiudadEstado = new ToolStripMenuItem();
            tsmOperaciones = new ToolStripMenuItem();
            OPEtsmFuncion = new ToolStripMenuItem();
            OPEtsmVenta = new ToolStripMenuItem();
            OPEtsmCliente = new ToolStripMenuItem();
            OPEtsmTipoBoleto = new ToolStripMenuItem();
            tsmSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmCartelera, tsmInfraestructura, tsmOperaciones, tsmSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmCartelera
            // 
            tsmCartelera.DropDownItems.AddRange(new ToolStripItem[] { CARtsmPelicula, CARtsmGenero, CARtsmClasificacion });
            tsmCartelera.Name = "tsmCartelera";
            tsmCartelera.Size = new Size(97, 29);
            tsmCartelera.Text = "Cartelera";
            // 
            // CARtsmPelicula
            // 
            CARtsmPelicula.Name = "CARtsmPelicula";
            CARtsmPelicula.Size = new Size(270, 34);
            CARtsmPelicula.Text = "Peliculas";
            CARtsmPelicula.Click += CARtsmPelicula_Click;
            // 
            // CARtsmGenero
            // 
            CARtsmGenero.Name = "CARtsmGenero";
            CARtsmGenero.Size = new Size(270, 34);
            CARtsmGenero.Text = "Generos";
            CARtsmGenero.Click += CARtsmGenero_Click;
            // 
            // CARtsmClasificacion
            // 
            CARtsmClasificacion.Name = "CARtsmClasificacion";
            CARtsmClasificacion.Size = new Size(270, 34);
            CARtsmClasificacion.Text = "Clasificaciones";
            CARtsmClasificacion.Click += CARtsmClasificacion_Click;
            // 
            // tsmInfraestructura
            // 
            tsmInfraestructura.DropDownItems.AddRange(new ToolStripItem[] { INFtsmSucursal, INFtsmSala, INFtsmCiudadEstado });
            tsmInfraestructura.Name = "tsmInfraestructura";
            tsmInfraestructura.Size = new Size(142, 29);
            tsmInfraestructura.Text = "Infraestructura";
            // 
            // INFtsmSucursal
            // 
            INFtsmSucursal.Name = "INFtsmSucursal";
            INFtsmSucursal.Size = new Size(243, 34);
            INFtsmSucursal.Text = "Sucursal";
            // 
            // INFtsmSala
            // 
            INFtsmSala.Name = "INFtsmSala";
            INFtsmSala.Size = new Size(243, 34);
            INFtsmSala.Text = "Sala";
            // 
            // INFtsmCiudadEstado
            // 
            INFtsmCiudadEstado.Name = "INFtsmCiudadEstado";
            INFtsmCiudadEstado.Size = new Size(243, 34);
            INFtsmCiudadEstado.Text = "Ciudad y Estado";
            // 
            // tsmOperaciones
            // 
            tsmOperaciones.DropDownItems.AddRange(new ToolStripItem[] { OPEtsmFuncion, OPEtsmVenta, OPEtsmCliente, OPEtsmTipoBoleto });
            tsmOperaciones.Name = "tsmOperaciones";
            tsmOperaciones.Size = new Size(127, 29);
            tsmOperaciones.Text = "Operaciones";
            // 
            // OPEtsmFuncion
            // 
            OPEtsmFuncion.Name = "OPEtsmFuncion";
            OPEtsmFuncion.Size = new Size(205, 34);
            OPEtsmFuncion.Text = "Funcion";
            // 
            // OPEtsmVenta
            // 
            OPEtsmVenta.Name = "OPEtsmVenta";
            OPEtsmVenta.Size = new Size(205, 34);
            OPEtsmVenta.Text = "Venta";
            // 
            // OPEtsmCliente
            // 
            OPEtsmCliente.Name = "OPEtsmCliente";
            OPEtsmCliente.Size = new Size(205, 34);
            OPEtsmCliente.Text = "Cliente";
            // 
            // OPEtsmTipoBoleto
            // 
            OPEtsmTipoBoleto.Name = "OPEtsmTipoBoleto";
            OPEtsmTipoBoleto.Size = new Size(205, 34);
            OPEtsmTipoBoleto.Text = "Tipo Boleto";
            // 
            // tsmSalir
            // 
            tsmSalir.Alignment = ToolStripItemAlignment.Right;
            tsmSalir.Name = "tsmSalir";
            tsmSalir.Size = new Size(61, 29);
            tsmSalir.Text = "Salir";
            tsmSalir.Click += tsmSalir_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "VentanaPrincipal";
            Text = "Ventana Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmCartelera;
        private ToolStripMenuItem CARtsmPelicula;
        private ToolStripMenuItem CARtsmGenero;
        private ToolStripMenuItem CARtsmClasificacion;
        private ToolStripMenuItem tsmInfraestructura;
        private ToolStripMenuItem INFtsmSucursal;
        private ToolStripMenuItem INFtsmSala;
        private ToolStripMenuItem INFtsmCiudadEstado;
        private ToolStripMenuItem tsmOperaciones;
        private ToolStripMenuItem OPEtsmFuncion;
        private ToolStripMenuItem OPEtsmVenta;
        private ToolStripMenuItem OPEtsmCliente;
        private ToolStripMenuItem OPEtsmTipoBoleto;
        private ToolStripMenuItem tsmSalir;
    }
}
