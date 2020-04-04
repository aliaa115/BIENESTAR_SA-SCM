namespace CapaVistaSCM
{
    partial class MDI_SCM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeOrdenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.inventariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEjemploToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoEjemploToolStripMenuItem
            // 
            this.mantenimientoEjemploToolStripMenuItem.Name = "mantenimientoEjemploToolStripMenuItem";
            this.mantenimientoEjemploToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mantenimientoEjemploToolStripMenuItem.Text = "MantenimientoEjemplo";
            this.mantenimientoEjemploToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoEjemploToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem,
            this.ordenesDeCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeCotizacionesToolStripMenuItem});
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            this.cotizacionesToolStripMenuItem.Click += new System.EventHandler(this.CotizacionesToolStripMenuItem_Click);
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeOrdenesDeCompraToolStripMenuItem});
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra";
            // 
            // listaDeOrdenesDeCompraToolStripMenuItem
            // 
            this.listaDeOrdenesDeCompraToolStripMenuItem.Name = "listaDeOrdenesDeCompraToolStripMenuItem";
            this.listaDeOrdenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.listaDeOrdenesDeCompraToolStripMenuItem.Text = "Lista de Ordenes de Compra";
            this.listaDeOrdenesDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ListaDeOrdenesDeCompraToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosInventarioToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // movimientosInventarioToolStripMenuItem
            // 
            this.movimientosInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasladoDeInventarioToolStripMenuItem,
            this.movimientoDeInventarioToolStripMenuItem});
            this.movimientosInventarioToolStripMenuItem.Name = "movimientosInventarioToolStripMenuItem";
            this.movimientosInventarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.movimientosInventarioToolStripMenuItem.Text = "Movimientos de Inventario";
            this.movimientosInventarioToolStripMenuItem.Click += new System.EventHandler(this.MovimientosInventarioToolStripMenuItem_Click);
            // 
            // trasladoDeInventarioToolStripMenuItem
            // 
            this.trasladoDeInventarioToolStripMenuItem.Name = "trasladoDeInventarioToolStripMenuItem";
            this.trasladoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.trasladoDeInventarioToolStripMenuItem.Text = "Traslado de Inventario";
            this.trasladoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.TrasladoDeInventarioToolStripMenuItem_Click_1);
            // 
            // movimientoDeInventarioToolStripMenuItem
            // 
            this.movimientoDeInventarioToolStripMenuItem.Name = "movimientoDeInventarioToolStripMenuItem";
            this.movimientoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.movimientoDeInventarioToolStripMenuItem.Text = "Movimiento de Inventario";
            this.movimientoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.MovimientoDeInventarioToolStripMenuItem_Click);
            // 
            // listaDeCotizacionesToolStripMenuItem
            // 
            this.listaDeCotizacionesToolStripMenuItem.Name = "listaDeCotizacionesToolStripMenuItem";
            this.listaDeCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.listaDeCotizacionesToolStripMenuItem.Text = "Lista de Cotizaciones";
            this.listaDeCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.ListaDeCotizacionesToolStripMenuItem_Click);
            // 
            // MDI_SCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_SCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeOrdenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEjemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCotizacionesToolStripMenuItem;
    }
}