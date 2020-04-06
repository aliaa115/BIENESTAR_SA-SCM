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
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeOrdenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestoSobreProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.inventariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEjemploToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.impuestoSobreProductoToolStripMenuItem,
            this.categoriasDeProductosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoEjemploToolStripMenuItem
            // 
            this.mantenimientoEjemploToolStripMenuItem.Name = "mantenimientoEjemploToolStripMenuItem";
            this.mantenimientoEjemploToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.mantenimientoEjemploToolStripMenuItem.Text = "Tipo Producto";
            this.mantenimientoEjemploToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoEjemploToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.contactosToolStripMenuItem.Text = "Contactos";
            this.contactosToolStripMenuItem.Click += new System.EventHandler(this.ContactosToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem,
            this.ordenesDeCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeCotizacionesToolStripMenuItem});
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            this.cotizacionesToolStripMenuItem.Click += new System.EventHandler(this.CotizacionesToolStripMenuItem_Click);
            // 
            // listaDeCotizacionesToolStripMenuItem
            // 
            this.listaDeCotizacionesToolStripMenuItem.Name = "listaDeCotizacionesToolStripMenuItem";
            this.listaDeCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.listaDeCotizacionesToolStripMenuItem.Text = "Lista de Cotizaciones";
            this.listaDeCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.ListaDeCotizacionesToolStripMenuItem_Click);
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeOrdenesDeCompraToolStripMenuItem});
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra";
            // 
            // listaDeOrdenesDeCompraToolStripMenuItem
            // 
            this.listaDeOrdenesDeCompraToolStripMenuItem.Name = "listaDeOrdenesDeCompraToolStripMenuItem";
            this.listaDeOrdenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.listaDeOrdenesDeCompraToolStripMenuItem.Text = "Lista de Ordenes de Compra";
            this.listaDeOrdenesDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ListaDeOrdenesDeCompraToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosInventarioToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // movimientosInventarioToolStripMenuItem
            // 
            this.movimientosInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasladoDeInventarioToolStripMenuItem,
            this.movimientoDeInventarioToolStripMenuItem});
            this.movimientosInventarioToolStripMenuItem.Name = "movimientosInventarioToolStripMenuItem";
            this.movimientosInventarioToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.movimientosInventarioToolStripMenuItem.Text = "Movimientos de Inventario";
            this.movimientosInventarioToolStripMenuItem.Click += new System.EventHandler(this.MovimientosInventarioToolStripMenuItem_Click);
            // 
            // trasladoDeInventarioToolStripMenuItem
            // 
            this.trasladoDeInventarioToolStripMenuItem.Name = "trasladoDeInventarioToolStripMenuItem";
            this.trasladoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.trasladoDeInventarioToolStripMenuItem.Text = "Traslado de Inventario";
            this.trasladoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.TrasladoDeInventarioToolStripMenuItem_Click_1);
            // 
            // movimientoDeInventarioToolStripMenuItem
            // 
            this.movimientoDeInventarioToolStripMenuItem.Name = "movimientoDeInventarioToolStripMenuItem";
            this.movimientoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.movimientoDeInventarioToolStripMenuItem.Text = "Movimiento de Inventario";
            this.movimientoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.MovimientoDeInventarioToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
            // 
            // impuestoSobreProductoToolStripMenuItem
            // 
            this.impuestoSobreProductoToolStripMenuItem.Name = "impuestoSobreProductoToolStripMenuItem";
            this.impuestoSobreProductoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.impuestoSobreProductoToolStripMenuItem.Text = "Impuesto sobre producto";
            this.impuestoSobreProductoToolStripMenuItem.Click += new System.EventHandler(this.ImpuestoSobreProductoToolStripMenuItem_Click);
            // 
            // categoriasDeProductosToolStripMenuItem
            // 
            this.categoriasDeProductosToolStripMenuItem.Name = "categoriasDeProductosToolStripMenuItem";
            this.categoriasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.categoriasDeProductosToolStripMenuItem.Text = "Categorias de Productos";
            this.categoriasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.CategoriasDeProductosToolStripMenuItem_Click);
            // 
            // MDI_SCM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestoSobreProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeProductosToolStripMenuItem;
    }
}