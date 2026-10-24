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
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmCartelera
            // 
            tsmCartelera.DropDownItems.AddRange(new ToolStripItem[] { CARtsmPelicula, CARtsmGenero, CARtsmClasificacion });
            tsmCartelera.Name = "tsmCartelera";
            tsmCartelera.Size = new Size(66, 22);
            tsmCartelera.Text = "Cartelera";
            // 
            // CARtsmPelicula
            // 
            CARtsmPelicula.Name = "CARtsmPelicula";
            CARtsmPelicula.Size = new Size(180, 22);
            CARtsmPelicula.Text = "Peliculas";
            CARtsmPelicula.Click += CARtsmPelicula_Click;
            // 
            // CARtsmGenero
            // 
            CARtsmGenero.Name = "CARtsmGenero";
            CARtsmGenero.Size = new Size(180, 22);
            CARtsmGenero.Text = "Generos";
            // 
            // CARtsmClasificacion
            // 
            CARtsmClasificacion.Name = "CARtsmClasificacion";
            CARtsmClasificacion.Size = new Size(180, 22);
            CARtsmClasificacion.Text = "Clasificaciones";
            // 
            // tsmInfraestructura
            // 
            tsmInfraestructura.DropDownItems.AddRange(new ToolStripItem[] { INFtsmSucursal, INFtsmSala, INFtsmCiudadEstado });
            tsmInfraestructura.Name = "tsmInfraestructura";
            tsmInfraestructura.Size = new Size(96, 22);
            tsmInfraestructura.Text = "Infraestructura";
            // 
            // INFtsmSucursal
            // 
            INFtsmSucursal.Name = "INFtsmSucursal";
            INFtsmSucursal.Size = new Size(180, 22);
            INFtsmSucursal.Text = "Sucursal";
            // 
            // INFtsmSala
            // 
            INFtsmSala.Name = "INFtsmSala";
            INFtsmSala.Size = new Size(180, 22);
            INFtsmSala.Text = "Sala";
            // 
            // INFtsmCiudadEstado
            // 
            INFtsmCiudadEstado.Name = "INFtsmCiudadEstado";
            INFtsmCiudadEstado.Size = new Size(180, 22);
            INFtsmCiudadEstado.Text = "Ciudad y Estado";
            // 
            // tsmOperaciones
            // 
            tsmOperaciones.DropDownItems.AddRange(new ToolStripItem[] { OPEtsmFuncion, OPEtsmVenta, OPEtsmCliente, OPEtsmTipoBoleto });
            tsmOperaciones.Name = "tsmOperaciones";
            tsmOperaciones.Size = new Size(85, 22);
            tsmOperaciones.Text = "Operaciones";
            // 
            // OPEtsmFuncion
            // 
            OPEtsmFuncion.Name = "OPEtsmFuncion";
            OPEtsmFuncion.Size = new Size(180, 22);
            OPEtsmFuncion.Text = "Funcion";
            OPEtsmFuncion.Click += OPEtsmFuncion_Click;
            // 
            // OPEtsmVenta
            // 
            OPEtsmVenta.Name = "OPEtsmVenta";
            OPEtsmVenta.Size = new Size(180, 22);
            OPEtsmVenta.Text = "Venta";
            OPEtsmVenta.Click += OPEtsmVenta_Click;
            // 
            // OPEtsmCliente
            // 
            OPEtsmCliente.Name = "OPEtsmCliente";
            OPEtsmCliente.Size = new Size(180, 22);
            OPEtsmCliente.Text = "Cliente";
            OPEtsmCliente.Click += OPEtsmCliente_Click;
            // 
            // OPEtsmTipoBoleto
            // 
            OPEtsmTipoBoleto.Name = "OPEtsmTipoBoleto";
            OPEtsmTipoBoleto.Size = new Size(180, 22);
            OPEtsmTipoBoleto.Text = "Tipo Boleto";
            OPEtsmTipoBoleto.Click += OPEtsmTipoBoleto_Click;
            // 
            // tsmSalir
            // 
            tsmSalir.Alignment = ToolStripItemAlignment.Right;
            tsmSalir.Name = "tsmSalir";
            tsmSalir.Size = new Size(41, 22);
            tsmSalir.Text = "Salir";
            tsmSalir.Click += tsmSalir_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
