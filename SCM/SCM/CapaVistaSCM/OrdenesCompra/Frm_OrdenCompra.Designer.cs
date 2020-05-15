namespace CapaVistaSCM
{
    partial class Frm_OrdenCompra
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
            this.Tbl_movimientoInventario = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new PDFHelpViewer.AyudaRup();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_desarrollo = new System.Windows.Forms.Panel();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Lbl_precioTotal = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Dgv_ordenCompraDetalle = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_producto = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Cbo_producto = new CapaVista.Combo();
            this.Txt_producto = new System.Windows.Forms.TextBox();
            this.Nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.Grp_eliminar = new System.Windows.Forms.GroupBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Grp_agregar = new System.Windows.Forms.GroupBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Grp_encabezado = new System.Windows.Forms.GroupBox();
            this.Tbc_Datos = new System.Windows.Forms.TabControl();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.Chk_entregado = new System.Windows.Forms.CheckBox();
            this.Pnl_datos = new System.Windows.Forms.Panel();
            this.Cbo_cotizacion = new CapaVista.Combo();
            this.Txt_cotizacion = new System.Windows.Forms.TextBox();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Grp_BuscarCot = new System.Windows.Forms.GroupBox();
            this.Btn_cotizacion = new System.Windows.Forms.Button();
            this.Grp_BuscarProv = new System.Windows.Forms.GroupBox();
            this.Btn_proveedor = new System.Windows.Forms.Button();
            this.Cbo_proveedor = new CapaVista.Combo();
            this.Chk_estado = new System.Windows.Forms.CheckBox();
            this.Dtp_entrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Chk_codigo = new System.Windows.Forms.CheckBox();
            this.Lbl_DocAsociado = new System.Windows.Forms.Label();
            this.Dtp_emision = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Grp_cancelar = new System.Windows.Forms.GroupBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Grp_guardar = new System.Windows.Forms.GroupBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_tipoMovimiento = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Tbp_descripcion = new System.Windows.Forms.TabPage();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Tbl_movimientoInventario.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_desarrollo.SuspendLayout();
            this.Gpb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenCompraDetalle)).BeginInit();
            this.Grp_producto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).BeginInit();
            this.Grp_eliminar.SuspendLayout();
            this.Grp_agregar.SuspendLayout();
            this.Grp_encabezado.SuspendLayout();
            this.Tbc_Datos.SuspendLayout();
            this.Tbp_Datos.SuspendLayout();
            this.Pnl_datos.SuspendLayout();
            this.Grp_BuscarCot.SuspendLayout();
            this.Grp_BuscarProv.SuspendLayout();
            this.Grp_cancelar.SuspendLayout();
            this.Grp_guardar.SuspendLayout();
            this.Tbp_descripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbl_movimientoInventario
            // 
            this.Tbl_movimientoInventario.ColumnCount = 1;
            this.Tbl_movimientoInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_movimientoInventario.Controls.Add(this.Pnl_titulo, 0, 0);
            this.Tbl_movimientoInventario.Controls.Add(this.Pnl_desarrollo, 0, 1);
            this.Tbl_movimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_movimientoInventario.Location = new System.Drawing.Point(0, 0);
            this.Tbl_movimientoInventario.Name = "Tbl_movimientoInventario";
            this.Tbl_movimientoInventario.RowCount = 2;
            this.Tbl_movimientoInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Tbl_movimientoInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(904, 758);
            this.Tbl_movimientoInventario.TabIndex = 2;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Pnl_titulo.Controls.Add(this.Btn_ayuda);
            this.Pnl_titulo.Controls.Add(this.Btn_MovInventario);
            this.Pnl_titulo.Controls.Add(this.Lbl_titulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_titulo.Location = new System.Drawing.Point(3, 3);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(898, 64);
            this.Pnl_titulo.TabIndex = 0;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ayuda.Location = new System.Drawing.Point(695, 5);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(57, 55);
            this.Btn_ayuda.TabIndex = 17;
            // 
            // Btn_MovInventario
            // 
            this.Btn_MovInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.BackgroundImage = global::CapaVistaSCM.Properties.Resources._027_shopping_cart;
            this.Btn_MovInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_MovInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_MovInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.BorderSize = 0;
            this.Btn_MovInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MovInventario.Location = new System.Drawing.Point(760, 0);
            this.Btn_MovInventario.Name = "Btn_MovInventario";
            this.Btn_MovInventario.Size = new System.Drawing.Size(138, 64);
            this.Btn_MovInventario.TabIndex = 3;
            this.Btn_MovInventario.UseVisualStyleBackColor = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.Lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(503, 59);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "ORDEN DE COMPRA";
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.Gpb_detalle);
            this.Pnl_desarrollo.Controls.Add(this.Grp_producto);
            this.Pnl_desarrollo.Controls.Add(this.Grp_encabezado);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 73);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(898, 682);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.Lbl_precioTotal);
            this.Gpb_detalle.Controls.Add(this.Txt_precioTotal);
            this.Gpb_detalle.Controls.Add(this.Dgv_ordenCompraDetalle);
            this.Gpb_detalle.Location = new System.Drawing.Point(4, 452);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(886, 230);
            this.Gpb_detalle.TabIndex = 16;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "DETALLE DE ORDEN DE COMPRA";
            // 
            // Lbl_precioTotal
            // 
            this.Lbl_precioTotal.AutoSize = true;
            this.Lbl_precioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precioTotal.Location = new System.Drawing.Point(6, 197);
            this.Lbl_precioTotal.Name = "Lbl_precioTotal";
            this.Lbl_precioTotal.Size = new System.Drawing.Size(145, 23);
            this.Lbl_precioTotal.TabIndex = 26;
            this.Lbl_precioTotal.Text = "PRECIO TOTAL";
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_precioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_precioTotal.Enabled = false;
            this.Txt_precioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(126, 197);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(161, 25);
            this.Txt_precioTotal.TabIndex = 27;
            // 
            // Dgv_ordenCompraDetalle
            // 
            this.Dgv_ordenCompraDetalle.AllowUserToAddRows = false;
            this.Dgv_ordenCompraDetalle.AllowUserToDeleteRows = false;
            this.Dgv_ordenCompraDetalle.AllowUserToResizeColumns = false;
            this.Dgv_ordenCompraDetalle.AllowUserToResizeRows = false;
            this.Dgv_ordenCompraDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_ordenCompraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ordenCompraDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Producto,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.modificado});
            this.Dgv_ordenCompraDetalle.Location = new System.Drawing.Point(5, 26);
            this.Dgv_ordenCompraDetalle.Name = "Dgv_ordenCompraDetalle";
            this.Dgv_ordenCompraDetalle.ReadOnly = true;
            this.Dgv_ordenCompraDetalle.RowHeadersVisible = false;
            this.Dgv_ordenCompraDetalle.RowHeadersWidth = 51;
            this.Dgv_ordenCompraDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_ordenCompraDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ordenCompraDetalle.Size = new System.Drawing.Size(878, 168);
            this.Dgv_ordenCompraDetalle.TabIndex = 25;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "No.";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // modificado
            // 
            this.modificado.HeaderText = "modificado";
            this.modificado.MinimumWidth = 6;
            this.modificado.Name = "modificado";
            this.modificado.ReadOnly = true;
            this.modificado.Visible = false;
            // 
            // Grp_producto
            // 
            this.Grp_producto.Controls.Add(this.groupBox1);
            this.Grp_producto.Controls.Add(this.Cbo_producto);
            this.Grp_producto.Controls.Add(this.Txt_producto);
            this.Grp_producto.Controls.Add(this.Nud_cantidad);
            this.Grp_producto.Controls.Add(this.Lbl_cantidad);
            this.Grp_producto.Controls.Add(this.Lbl_producto);
            this.Grp_producto.Controls.Add(this.Grp_eliminar);
            this.Grp_producto.Controls.Add(this.Grp_agregar);
            this.Grp_producto.Location = new System.Drawing.Point(5, 349);
            this.Grp_producto.Name = "Grp_producto";
            this.Grp_producto.Size = new System.Drawing.Size(891, 97);
            this.Grp_producto.TabIndex = 15;
            this.Grp_producto.TabStop = false;
            this.Grp_producto.Text = "PRODUCTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_buscar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(309, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 55);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_buscar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._191_search;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Location = new System.Drawing.Point(3, 24);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(95, 28);
            this.Btn_buscar.TabIndex = 35;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Location = new System.Drawing.Point(104, 25);
            this.Cbo_producto.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(200, 33);
            this.Cbo_producto.TabIndex = 50;
            // 
            // Txt_producto
            // 
            this.Txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_producto.Enabled = false;
            this.Txt_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_producto.Location = new System.Drawing.Point(10, 63);
            this.Txt_producto.Name = "Txt_producto";
            this.Txt_producto.Size = new System.Drawing.Size(282, 25);
            this.Txt_producto.TabIndex = 49;
            // 
            // Nud_cantidad
            // 
            this.Nud_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_cantidad.Location = new System.Drawing.Point(569, 60);
            this.Nud_cantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Nud_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_cantidad.Name = "Nud_cantidad";
            this.Nud_cantidad.Size = new System.Drawing.Size(53, 32);
            this.Nud_cantidad.TabIndex = 46;
            this.Nud_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad.Location = new System.Drawing.Point(473, 63);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(113, 23);
            this.Lbl_cantidad.TabIndex = 45;
            this.Lbl_cantidad.Text = "CANTIDAD";
            // 
            // Lbl_producto
            // 
            this.Lbl_producto.AutoSize = true;
            this.Lbl_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_producto.Location = new System.Drawing.Point(6, 26);
            this.Lbl_producto.Name = "Lbl_producto";
            this.Lbl_producto.Size = new System.Drawing.Size(118, 23);
            this.Lbl_producto.TabIndex = 35;
            this.Lbl_producto.Text = "PRODUCTO";
            // 
            // Grp_eliminar
            // 
            this.Grp_eliminar.Controls.Add(this.Btn_eliminar);
            this.Grp_eliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_eliminar.Location = new System.Drawing.Point(766, 31);
            this.Grp_eliminar.Name = "Grp_eliminar";
            this.Grp_eliminar.Size = new System.Drawing.Size(110, 55);
            this.Grp_eliminar.TabIndex = 34;
            this.Grp_eliminar.TabStop = false;
            this.Grp_eliminar.Text = "ELIMINAR";
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_eliminar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._223_trash;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Location = new System.Drawing.Point(3, 24);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(104, 28);
            this.Btn_eliminar.TabIndex = 36;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Grp_agregar
            // 
            this.Grp_agregar.Controls.Add(this.Btn_agregar);
            this.Grp_agregar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_agregar.Location = new System.Drawing.Point(659, 31);
            this.Grp_agregar.Name = "Grp_agregar";
            this.Grp_agregar.Size = new System.Drawing.Size(101, 55);
            this.Grp_agregar.TabIndex = 33;
            this.Grp_agregar.TabStop = false;
            this.Grp_agregar.Text = "AGREGAR";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_agregar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._159_pencil;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Location = new System.Drawing.Point(3, 24);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(95, 28);
            this.Btn_agregar.TabIndex = 35;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Grp_encabezado
            // 
            this.Grp_encabezado.Controls.Add(this.Tbc_Datos);
            this.Grp_encabezado.Location = new System.Drawing.Point(2, 3);
            this.Grp_encabezado.Name = "Grp_encabezado";
            this.Grp_encabezado.Size = new System.Drawing.Size(891, 340);
            this.Grp_encabezado.TabIndex = 14;
            this.Grp_encabezado.TabStop = false;
            this.Grp_encabezado.Text = "DATOS DE ORDEN DE COMPRA";
            // 
            // Tbc_Datos
            // 
            this.Tbc_Datos.Controls.Add(this.Tbp_Datos);
            this.Tbc_Datos.Controls.Add(this.Tbp_descripcion);
            this.Tbc_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Datos.Location = new System.Drawing.Point(3, 28);
            this.Tbc_Datos.Name = "Tbc_Datos";
            this.Tbc_Datos.SelectedIndex = 0;
            this.Tbc_Datos.Size = new System.Drawing.Size(885, 309);
            this.Tbc_Datos.TabIndex = 0;
            // 
            // Tbp_Datos
            // 
            this.Tbp_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Tbp_Datos.Controls.Add(this.Chk_entregado);
            this.Tbp_Datos.Controls.Add(this.Pnl_datos);
            this.Tbp_Datos.Location = new System.Drawing.Point(4, 32);
            this.Tbp_Datos.Name = "Tbp_Datos";
            this.Tbp_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Datos.Size = new System.Drawing.Size(877, 273);
            this.Tbp_Datos.TabIndex = 0;
            this.Tbp_Datos.Text = "Datos";
            // 
            // Chk_entregado
            // 
            this.Chk_entregado.AutoSize = true;
            this.Chk_entregado.Location = new System.Drawing.Point(191, 231);
            this.Chk_entregado.Name = "Chk_entregado";
            this.Chk_entregado.Size = new System.Drawing.Size(135, 27);
            this.Chk_entregado.TabIndex = 55;
            this.Chk_entregado.Text = "Entregado";
            this.Chk_entregado.UseVisualStyleBackColor = true;
            this.Chk_entregado.CheckedChanged += new System.EventHandler(this.Chk_entregado_CheckedChanged);
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_datos.Controls.Add(this.Cbo_cotizacion);
            this.Pnl_datos.Controls.Add(this.Txt_cotizacion);
            this.Pnl_datos.Controls.Add(this.Txt_proveedor);
            this.Pnl_datos.Controls.Add(this.Grp_BuscarCot);
            this.Pnl_datos.Controls.Add(this.Grp_BuscarProv);
            this.Pnl_datos.Controls.Add(this.Cbo_proveedor);
            this.Pnl_datos.Controls.Add(this.Chk_estado);
            this.Pnl_datos.Controls.Add(this.Dtp_entrega);
            this.Pnl_datos.Controls.Add(this.label2);
            this.Pnl_datos.Controls.Add(this.Chk_codigo);
            this.Pnl_datos.Controls.Add(this.Lbl_DocAsociado);
            this.Pnl_datos.Controls.Add(this.Dtp_emision);
            this.Pnl_datos.Controls.Add(this.Lbl_fecha);
            this.Pnl_datos.Controls.Add(this.Grp_cancelar);
            this.Pnl_datos.Controls.Add(this.Grp_guardar);
            this.Pnl_datos.Controls.Add(this.Lbl_tipoMovimiento);
            this.Pnl_datos.Controls.Add(this.Txt_nombre);
            this.Pnl_datos.Controls.Add(this.Lbl_codigo);
            this.Pnl_datos.Controls.Add(this.Txt_codigo);
            this.Pnl_datos.Controls.Add(this.Lbl_nombre);
            this.Pnl_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_datos.Location = new System.Drawing.Point(3, 3);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(871, 267);
            this.Pnl_datos.TabIndex = 0;
            this.Pnl_datos.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_datos_Paint);
            // 
            // Cbo_cotizacion
            // 
            this.Cbo_cotizacion.Location = new System.Drawing.Point(583, 134);
            this.Cbo_cotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_cotizacion.Name = "Cbo_cotizacion";
            this.Cbo_cotizacion.Size = new System.Drawing.Size(274, 34);
            this.Cbo_cotizacion.TabIndex = 54;
            // 
            // Txt_cotizacion
            // 
            this.Txt_cotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_cotizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_cotizacion.Enabled = false;
            this.Txt_cotizacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cotizacion.Location = new System.Drawing.Point(141, 138);
            this.Txt_cotizacion.Name = "Txt_cotizacion";
            this.Txt_cotizacion.Size = new System.Drawing.Size(282, 25);
            this.Txt_cotizacion.TabIndex = 53;
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_proveedor.Enabled = false;
            this.Txt_proveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_proveedor.Location = new System.Drawing.Point(141, 73);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(282, 25);
            this.Txt_proveedor.TabIndex = 52;
            // 
            // Grp_BuscarCot
            // 
            this.Grp_BuscarCot.Controls.Add(this.Btn_cotizacion);
            this.Grp_BuscarCot.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_BuscarCot.Location = new System.Drawing.Point(429, 112);
            this.Grp_BuscarCot.Name = "Grp_BuscarCot";
            this.Grp_BuscarCot.Size = new System.Drawing.Size(146, 55);
            this.Grp_BuscarCot.TabIndex = 52;
            this.Grp_BuscarCot.TabStop = false;
            this.Grp_BuscarCot.Text = "BUSCAR COTIZ";
            // 
            // Btn_cotizacion
            // 
            this.Btn_cotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_cotizacion.BackgroundImage = global::CapaVistaSCM.Properties.Resources._191_search;
            this.Btn_cotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cotizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_cotizacion.FlatAppearance.BorderSize = 0;
            this.Btn_cotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cotizacion.Location = new System.Drawing.Point(3, 24);
            this.Btn_cotizacion.Name = "Btn_cotizacion";
            this.Btn_cotizacion.Size = new System.Drawing.Size(140, 28);
            this.Btn_cotizacion.TabIndex = 35;
            this.Btn_cotizacion.UseVisualStyleBackColor = false;
            this.Btn_cotizacion.Click += new System.EventHandler(this.Btn_cotizacion_Click);
            // 
            // Grp_BuscarProv
            // 
            this.Grp_BuscarProv.Controls.Add(this.Btn_proveedor);
            this.Grp_BuscarProv.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_BuscarProv.Location = new System.Drawing.Point(429, 46);
            this.Grp_BuscarProv.Name = "Grp_BuscarProv";
            this.Grp_BuscarProv.Size = new System.Drawing.Size(149, 55);
            this.Grp_BuscarProv.TabIndex = 52;
            this.Grp_BuscarProv.TabStop = false;
            this.Grp_BuscarProv.Text = "BUSCAR PROV";
            this.Grp_BuscarProv.Enter += new System.EventHandler(this.Grp_BuscarProv_Enter);
            // 
            // Btn_proveedor
            // 
            this.Btn_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_proveedor.BackgroundImage = global::CapaVistaSCM.Properties.Resources._191_search;
            this.Btn_proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_proveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_proveedor.FlatAppearance.BorderSize = 0;
            this.Btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_proveedor.Location = new System.Drawing.Point(3, 24);
            this.Btn_proveedor.Name = "Btn_proveedor";
            this.Btn_proveedor.Size = new System.Drawing.Size(143, 28);
            this.Btn_proveedor.TabIndex = 35;
            this.Btn_proveedor.UseVisualStyleBackColor = false;
            this.Btn_proveedor.Click += new System.EventHandler(this.Btn_proveedor_Click);
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.Location = new System.Drawing.Point(583, 67);
            this.Cbo_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(274, 32);
            this.Cbo_proveedor.TabIndex = 49;
            this.Cbo_proveedor.Load += new System.EventHandler(this.Cbo_proveedor_Load);
            // 
            // Chk_estado
            // 
            this.Chk_estado.AutoSize = true;
            this.Chk_estado.Location = new System.Drawing.Point(535, 232);
            this.Chk_estado.Name = "Chk_estado";
            this.Chk_estado.Size = new System.Drawing.Size(96, 27);
            this.Chk_estado.TabIndex = 47;
            this.Chk_estado.Text = "Activo";
            this.Chk_estado.UseVisualStyleBackColor = true;
            this.Chk_estado.CheckedChanged += new System.EventHandler(this.Chk_estado_CheckedChanged);
            // 
            // Dtp_entrega
            // 
            this.Dtp_entrega.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_entrega.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dtp_entrega.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Dtp_entrega.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.Dtp_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_entrega.Location = new System.Drawing.Point(182, 186);
            this.Dtp_entrega.Name = "Dtp_entrega";
            this.Dtp_entrega.Size = new System.Drawing.Size(146, 32);
            this.Dtp_entrega.TabIndex = 43;
            this.Dtp_entrega.ValueChanged += new System.EventHandler(this.Dtp_entrega_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "FECHA ENTREGA";
            // 
            // Chk_codigo
            // 
            this.Chk_codigo.AutoSize = true;
            this.Chk_codigo.Location = new System.Drawing.Point(286, 15);
            this.Chk_codigo.Name = "Chk_codigo";
            this.Chk_codigo.Size = new System.Drawing.Size(225, 27);
            this.Chk_codigo.TabIndex = 42;
            this.Chk_codigo.Text = "Codigo automatico";
            this.Chk_codigo.UseVisualStyleBackColor = true;
            this.Chk_codigo.CheckedChanged += new System.EventHandler(this.Chk_codigo_CheckedChanged);
            // 
            // Lbl_DocAsociado
            // 
            this.Lbl_DocAsociado.AutoSize = true;
            this.Lbl_DocAsociado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DocAsociado.Location = new System.Drawing.Point(8, 73);
            this.Lbl_DocAsociado.Name = "Lbl_DocAsociado";
            this.Lbl_DocAsociado.Size = new System.Drawing.Size(127, 23);
            this.Lbl_DocAsociado.TabIndex = 39;
            this.Lbl_DocAsociado.Text = "PROVEEDOR";
            // 
            // Dtp_emision
            // 
            this.Dtp_emision.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_emision.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dtp_emision.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Dtp_emision.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.Dtp_emision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_emision.Location = new System.Drawing.Point(503, 186);
            this.Dtp_emision.Name = "Dtp_emision";
            this.Dtp_emision.Size = new System.Drawing.Size(129, 32);
            this.Dtp_emision.TabIndex = 4;
            this.Dtp_emision.ValueChanged += new System.EventHandler(this.Dtp_emision_ValueChanged);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(334, 192);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(163, 23);
            this.Lbl_fecha.TabIndex = 37;
            this.Lbl_fecha.Text = "FECHA EMISION";
            // 
            // Grp_cancelar
            // 
            this.Grp_cancelar.Controls.Add(this.Btn_cancelar);
            this.Grp_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_cancelar.Location = new System.Drawing.Point(758, 204);
            this.Grp_cancelar.Name = "Grp_cancelar";
            this.Grp_cancelar.Size = new System.Drawing.Size(110, 55);
            this.Grp_cancelar.TabIndex = 26;
            this.Grp_cancelar.TabStop = false;
            this.Grp_cancelar.Text = "CANCELAR";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_cancelar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._243_exit;
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Location = new System.Drawing.Point(3, 24);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(104, 28);
            this.Btn_cancelar.TabIndex = 10;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Grp_guardar
            // 
            this.Grp_guardar.Controls.Add(this.Btn_guardar);
            this.Grp_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_guardar.Location = new System.Drawing.Point(645, 204);
            this.Grp_guardar.Name = "Grp_guardar";
            this.Grp_guardar.Size = new System.Drawing.Size(107, 55);
            this.Grp_guardar.TabIndex = 25;
            this.Grp_guardar.TabStop = false;
            this.Grp_guardar.Text = "GUARDAR";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_guardar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._083_floppy_disk;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Location = new System.Drawing.Point(3, 24);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(101, 28);
            this.Btn_guardar.TabIndex = 9;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_tipoMovimiento
            // 
            this.Lbl_tipoMovimiento.AutoSize = true;
            this.Lbl_tipoMovimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoMovimiento.Location = new System.Drawing.Point(8, 142);
            this.Lbl_tipoMovimiento.Name = "Lbl_tipoMovimiento";
            this.Lbl_tipoMovimiento.Size = new System.Drawing.Size(136, 23);
            this.Lbl_tipoMovimiento.TabIndex = 31;
            this.Lbl_tipoMovimiento.Text = "COTIZACION";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(609, 13);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(245, 32);
            this.Txt_nombre.TabIndex = 2;
            this.Txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(14, 17);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(97, 23);
            this.Lbl_codigo.TabIndex = 27;
            this.Lbl_codigo.Text = "CODIGO";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(113, 15);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(160, 32);
            this.Txt_codigo.TabIndex = 1;
            this.Txt_codigo.TextChanged += new System.EventHandler(this.Txt_codigo_TextChanged);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(529, 17);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(94, 23);
            this.Lbl_nombre.TabIndex = 29;
            this.Lbl_nombre.Text = "NOMBRE";
            // 
            // Tbp_descripcion
            // 
            this.Tbp_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Tbp_descripcion.Controls.Add(this.Txt_descripcion);
            this.Tbp_descripcion.Location = new System.Drawing.Point(4, 25);
            this.Tbp_descripcion.Name = "Tbp_descripcion";
            this.Tbp_descripcion.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_descripcion.Size = new System.Drawing.Size(877, 280);
            this.Tbp_descripcion.TabIndex = 1;
            this.Tbp_descripcion.Text = "Nota";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_descripcion.Location = new System.Drawing.Point(3, 3);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(871, 274);
            this.Txt_descripcion.TabIndex = 12;
            this.Txt_descripcion.TextChanged += new System.EventHandler(this.Txt_descripcion_TextChanged);
            // 
            // Frm_OrdenCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 758);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_OrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_OrdenCompra_FormClosed);
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenCompraDetalle)).EndInit();
            this.Grp_producto.ResumeLayout(false);
            this.Grp_producto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).EndInit();
            this.Grp_eliminar.ResumeLayout(false);
            this.Grp_agregar.ResumeLayout(false);
            this.Grp_encabezado.ResumeLayout(false);
            this.Tbc_Datos.ResumeLayout(false);
            this.Tbp_Datos.ResumeLayout(false);
            this.Tbp_Datos.PerformLayout();
            this.Pnl_datos.ResumeLayout(false);
            this.Pnl_datos.PerformLayout();
            this.Grp_BuscarCot.ResumeLayout(false);
            this.Grp_BuscarProv.ResumeLayout(false);
            this.Grp_cancelar.ResumeLayout(false);
            this.Grp_guardar.ResumeLayout(false);
            this.Tbp_descripcion.ResumeLayout(false);
            this.Tbp_descripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.Label Lbl_precioTotal;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.DataGridView Dgv_ordenCompraDetalle;
        private System.Windows.Forms.GroupBox Grp_producto;
        private System.Windows.Forms.TextBox Txt_producto;
        private System.Windows.Forms.NumericUpDown Nud_cantidad;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.GroupBox Grp_eliminar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Grp_agregar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.GroupBox Grp_encabezado;
        private System.Windows.Forms.TabControl Tbc_Datos;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.Panel Pnl_datos;
        private System.Windows.Forms.CheckBox Chk_codigo;
        private System.Windows.Forms.Label Lbl_DocAsociado;
        private System.Windows.Forms.DateTimePicker Dtp_emision;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.GroupBox Grp_cancelar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.GroupBox Grp_guardar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_tipoMovimiento;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TabPage Tbp_descripcion;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.DateTimePicker Dtp_entrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Chk_estado;
        private CapaVista.Combo Cbo_producto;
        private CapaVista.Combo Cbo_proveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_cotizacion;
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.GroupBox Grp_BuscarCot;
        private System.Windows.Forms.Button Btn_cotizacion;
        private System.Windows.Forms.GroupBox Grp_BuscarProv;
        private System.Windows.Forms.Button Btn_proveedor;
        private CapaVista.Combo Cbo_cotizacion;
        private PDFHelpViewer.AyudaRup Btn_ayuda;
        private System.Windows.Forms.CheckBox Chk_entregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificado;
    }
}