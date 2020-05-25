namespace CapaVistaSCM
{
    partial class Frm_MovimientosInventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MovimientosInventarios));
            this.Tbl_movimientoInventario = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_desarrollo = new System.Windows.Forms.Panel();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.ZZ = new System.Windows.Forms.Label();
            this.Lbl_costoTotal = new System.Windows.Forms.Label();
            this.Txt_costoTotal = new System.Windows.Forms.TextBox();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Dgv_movimientoDetalle = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_producto = new System.Windows.Forms.GroupBox();
            this.combo1 = new CapaVista.Combo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_producto = new System.Windows.Forms.TextBox();
            this.Txt_costo = new System.Windows.Forms.TextBox();
            this.Lbl_costo = new System.Windows.Forms.Label();
            this.Nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_producto = new System.Windows.Forms.Label();
            this.Gpb_eliminar = new System.Windows.Forms.GroupBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Gpb_agregar = new System.Windows.Forms.GroupBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Grp_DatosMovimiento = new System.Windows.Forms.GroupBox();
            this.Tbc_Datos = new System.Windows.Forms.TabControl();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.Pnl_datos = new System.Windows.Forms.Panel();
            this.Btn_Verificar = new System.Windows.Forms.Button();
            this.Chk_estado = new System.Windows.Forms.CheckBox();
            this.Chk_codigo = new System.Windows.Forms.CheckBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Grp_cancelar = new System.Windows.Forms.GroupBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Grp_guardar = new System.Windows.Forms.GroupBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Cbo_tipoMovimiento = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimientoDetalle)).BeginInit();
            this.Grp_producto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).BeginInit();
            this.Gpb_eliminar.SuspendLayout();
            this.Gpb_agregar.SuspendLayout();
            this.Grp_DatosMovimiento.SuspendLayout();
            this.Tbc_Datos.SuspendLayout();
            this.Tbp_Datos.SuspendLayout();
            this.Pnl_datos.SuspendLayout();
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
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(923, 642);
            this.Tbl_movimientoInventario.TabIndex = 1;
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
            this.Pnl_titulo.Size = new System.Drawing.Size(917, 64);
            this.Pnl_titulo.TabIndex = 0;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackgroundImage = global::CapaVistaSCM.Properties.Resources.information;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_ayuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Location = new System.Drawing.Point(742, 0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(37, 64);
            this.Btn_ayuda.TabIndex = 5;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_MovInventario
            // 
            this.Btn_MovInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.BackgroundImage = global::CapaVistaSCM.Properties.Resources._091_trolley;
            this.Btn_MovInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_MovInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_MovInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.BorderSize = 0;
            this.Btn_MovInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MovInventario.Location = new System.Drawing.Point(779, 0);
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
            this.Lbl_titulo.Size = new System.Drawing.Size(667, 59);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Movimientos de Inventario";
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.Gpb_detalle);
            this.Pnl_desarrollo.Controls.Add(this.Grp_producto);
            this.Pnl_desarrollo.Controls.Add(this.Grp_DatosMovimiento);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 73);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(917, 566);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.ZZ);
            this.Gpb_detalle.Controls.Add(this.Lbl_costoTotal);
            this.Gpb_detalle.Controls.Add(this.Txt_costoTotal);
            this.Gpb_detalle.Controls.Add(this.Txt_precioTotal);
            this.Gpb_detalle.Controls.Add(this.Dgv_movimientoDetalle);
            this.Gpb_detalle.Location = new System.Drawing.Point(9, 326);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(886, 230);
            this.Gpb_detalle.TabIndex = 16;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "DETALLE DE MOVIMIENTO";
            // 
            // ZZ
            // 
            this.ZZ.AutoSize = true;
            this.ZZ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZZ.Location = new System.Drawing.Point(6, 199);
            this.ZZ.Name = "ZZ";
            this.ZZ.Size = new System.Drawing.Size(139, 23);
            this.ZZ.TabIndex = 30;
            this.ZZ.Text = "PRESIO TOTAL";
            // 
            // Lbl_costoTotal
            // 
            this.Lbl_costoTotal.AutoSize = true;
            this.Lbl_costoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costoTotal.Location = new System.Drawing.Point(346, 197);
            this.Lbl_costoTotal.Name = "Lbl_costoTotal";
            this.Lbl_costoTotal.Size = new System.Drawing.Size(141, 23);
            this.Lbl_costoTotal.TabIndex = 28;
            this.Lbl_costoTotal.Text = "COSTO TOTAL";
            // 
            // Txt_costoTotal
            // 
            this.Txt_costoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_costoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_costoTotal.Enabled = false;
            this.Txt_costoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_costoTotal.Location = new System.Drawing.Point(504, 197);
            this.Txt_costoTotal.Name = "Txt_costoTotal";
            this.Txt_costoTotal.Size = new System.Drawing.Size(161, 25);
            this.Txt_costoTotal.TabIndex = 29;
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_precioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_precioTotal.Enabled = false;
            this.Txt_precioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(153, 200);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(187, 25);
            this.Txt_precioTotal.TabIndex = 27;
            // 
            // Dgv_movimientoDetalle
            // 
            this.Dgv_movimientoDetalle.AllowUserToAddRows = false;
            this.Dgv_movimientoDetalle.AllowUserToDeleteRows = false;
            this.Dgv_movimientoDetalle.AllowUserToResizeColumns = false;
            this.Dgv_movimientoDetalle.AllowUserToResizeRows = false;
            this.Dgv_movimientoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_movimientoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_movimientoDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Nombre,
            this.Cantidad,
            this.Costo,
            this.Precio,
            this.Impuesto,
            this.Cambio});
            this.Dgv_movimientoDetalle.Location = new System.Drawing.Point(5, 26);
            this.Dgv_movimientoDetalle.Name = "Dgv_movimientoDetalle";
            this.Dgv_movimientoDetalle.ReadOnly = true;
            this.Dgv_movimientoDetalle.RowHeadersVisible = false;
            this.Dgv_movimientoDetalle.RowHeadersWidth = 51;
            this.Dgv_movimientoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_movimientoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_movimientoDetalle.Size = new System.Drawing.Size(878, 168);
            this.Dgv_movimientoDetalle.TabIndex = 25;
            this.Dgv_movimientoDetalle.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dgv_movimientoDetalle_RowsAdded);
            this.Dgv_movimientoDetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dgv_movimientoDetalle_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
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
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.MinimumWidth = 6;
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            this.Impuesto.Visible = false;
            // 
            // Cambio
            // 
            this.Cambio.HeaderText = "CAMBIO";
            this.Cambio.MinimumWidth = 6;
            this.Cambio.Name = "Cambio";
            this.Cambio.ReadOnly = true;
            this.Cambio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cambio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cambio.Visible = false;
            // 
            // Grp_producto
            // 
            this.Grp_producto.Controls.Add(this.combo1);
            this.Grp_producto.Controls.Add(this.groupBox1);
            this.Grp_producto.Controls.Add(this.Txt_producto);
            this.Grp_producto.Controls.Add(this.Txt_costo);
            this.Grp_producto.Controls.Add(this.Lbl_costo);
            this.Grp_producto.Controls.Add(this.Nud_cantidad);
            this.Grp_producto.Controls.Add(this.Lbl_cantidad);
            this.Grp_producto.Controls.Add(this.Txt_precio);
            this.Grp_producto.Controls.Add(this.label1);
            this.Grp_producto.Controls.Add(this.Lbl_producto);
            this.Grp_producto.Controls.Add(this.Gpb_eliminar);
            this.Grp_producto.Controls.Add(this.Gpb_agregar);
            this.Grp_producto.Location = new System.Drawing.Point(9, 223);
            this.Grp_producto.Name = "Grp_producto";
            this.Grp_producto.Size = new System.Drawing.Size(891, 97);
            this.Grp_producto.TabIndex = 15;
            this.Grp_producto.TabStop = false;
            this.Grp_producto.Text = "PRODUCTOS";
            // 
            // combo1
            // 
            this.combo1.Location = new System.Drawing.Point(106, 20);
            this.combo1.Margin = new System.Windows.Forms.Padding(4);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(211, 34);
            this.combo1.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_buscar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(324, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 55);
            this.groupBox1.TabIndex = 36;
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
            // Txt_producto
            // 
            this.Txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_producto.Enabled = false;
            this.Txt_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_producto.Location = new System.Drawing.Point(10, 63);
            this.Txt_producto.Name = "Txt_producto";
            this.Txt_producto.Size = new System.Drawing.Size(277, 25);
            this.Txt_producto.TabIndex = 49;
            // 
            // Txt_costo
            // 
            this.Txt_costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_costo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_costo.Enabled = false;
            this.Txt_costo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_costo.Location = new System.Drawing.Point(542, 25);
            this.Txt_costo.Name = "Txt_costo";
            this.Txt_costo.Size = new System.Drawing.Size(103, 25);
            this.Txt_costo.TabIndex = 48;
            // 
            // Lbl_costo
            // 
            this.Lbl_costo.AutoSize = true;
            this.Lbl_costo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costo.Location = new System.Drawing.Point(472, 26);
            this.Lbl_costo.Name = "Lbl_costo";
            this.Lbl_costo.Size = new System.Drawing.Size(78, 23);
            this.Lbl_costo.TabIndex = 47;
            this.Lbl_costo.Text = "COSTO";
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
            // Txt_precio
            // 
            this.Txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_precio.Enabled = false;
            this.Txt_precio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.Location = new System.Drawing.Point(364, 63);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(103, 25);
            this.Txt_precio.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "PRECIO";
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
            // Gpb_eliminar
            // 
            this.Gpb_eliminar.Controls.Add(this.Btn_eliminar);
            this.Gpb_eliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Gpb_eliminar.Location = new System.Drawing.Point(766, 31);
            this.Gpb_eliminar.Name = "Gpb_eliminar";
            this.Gpb_eliminar.Size = new System.Drawing.Size(110, 55);
            this.Gpb_eliminar.TabIndex = 34;
            this.Gpb_eliminar.TabStop = false;
            this.Gpb_eliminar.Text = "ELIMINAR";
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
            // Gpb_agregar
            // 
            this.Gpb_agregar.Controls.Add(this.Btn_agregar);
            this.Gpb_agregar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Gpb_agregar.Location = new System.Drawing.Point(659, 31);
            this.Gpb_agregar.Name = "Gpb_agregar";
            this.Gpb_agregar.Size = new System.Drawing.Size(101, 55);
            this.Gpb_agregar.TabIndex = 33;
            this.Gpb_agregar.TabStop = false;
            this.Gpb_agregar.Text = "AGREGAR";
            this.Gpb_agregar.Enter += new System.EventHandler(this.Gpb_agregar_Enter);
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
            this.Btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Grp_DatosMovimiento
            // 
            this.Grp_DatosMovimiento.Controls.Add(this.Tbc_Datos);
            this.Grp_DatosMovimiento.Location = new System.Drawing.Point(9, 3);
            this.Grp_DatosMovimiento.Name = "Grp_DatosMovimiento";
            this.Grp_DatosMovimiento.Size = new System.Drawing.Size(891, 214);
            this.Grp_DatosMovimiento.TabIndex = 14;
            this.Grp_DatosMovimiento.TabStop = false;
            this.Grp_DatosMovimiento.Text = "DATOS DE MOVIMIENTO DE INVENTARIO";
            // 
            // Tbc_Datos
            // 
            this.Tbc_Datos.Controls.Add(this.Tbp_Datos);
            this.Tbc_Datos.Controls.Add(this.Tbp_descripcion);
            this.Tbc_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Datos.Location = new System.Drawing.Point(3, 28);
            this.Tbc_Datos.Name = "Tbc_Datos";
            this.Tbc_Datos.SelectedIndex = 0;
            this.Tbc_Datos.Size = new System.Drawing.Size(885, 183);
            this.Tbc_Datos.TabIndex = 0;
            // 
            // Tbp_Datos
            // 
            this.Tbp_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Tbp_Datos.Controls.Add(this.Pnl_datos);
            this.Tbp_Datos.Location = new System.Drawing.Point(4, 32);
            this.Tbp_Datos.Name = "Tbp_Datos";
            this.Tbp_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Datos.Size = new System.Drawing.Size(877, 147);
            this.Tbp_Datos.TabIndex = 0;
            this.Tbp_Datos.Text = "Datos";
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_datos.Controls.Add(this.Btn_Verificar);
            this.Pnl_datos.Controls.Add(this.Chk_estado);
            this.Pnl_datos.Controls.Add(this.Chk_codigo);
            this.Pnl_datos.Controls.Add(this.Dtp_fecha);
            this.Pnl_datos.Controls.Add(this.Lbl_fecha);
            this.Pnl_datos.Controls.Add(this.Grp_cancelar);
            this.Pnl_datos.Controls.Add(this.Grp_guardar);
            this.Pnl_datos.Controls.Add(this.Cbo_tipoMovimiento);
            this.Pnl_datos.Controls.Add(this.Lbl_tipoMovimiento);
            this.Pnl_datos.Controls.Add(this.Txt_nombre);
            this.Pnl_datos.Controls.Add(this.Lbl_codigo);
            this.Pnl_datos.Controls.Add(this.Txt_codigo);
            this.Pnl_datos.Controls.Add(this.Lbl_nombre);
            this.Pnl_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_datos.Location = new System.Drawing.Point(3, 3);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(871, 141);
            this.Pnl_datos.TabIndex = 0;
            // 
            // Btn_Verificar
            // 
            this.Btn_Verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_Verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Verificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_Verificar.FlatAppearance.BorderSize = 0;
            this.Btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Verificar.Location = new System.Drawing.Point(229, 14);
            this.Btn_Verificar.Name = "Btn_Verificar";
            this.Btn_Verificar.Size = new System.Drawing.Size(101, 28);
            this.Btn_Verificar.TabIndex = 48;
            this.Btn_Verificar.Text = "Verificar";
            this.Btn_Verificar.UseVisualStyleBackColor = false;
            // 
            // Chk_estado
            // 
            this.Chk_estado.AutoSize = true;
            this.Chk_estado.Checked = true;
            this.Chk_estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_estado.Location = new System.Drawing.Point(314, 90);
            this.Chk_estado.Name = "Chk_estado";
            this.Chk_estado.Size = new System.Drawing.Size(96, 27);
            this.Chk_estado.TabIndex = 47;
            this.Chk_estado.Text = "Activo";
            this.Chk_estado.UseVisualStyleBackColor = true;
            this.Chk_estado.CheckedChanged += new System.EventHandler(this.Chk_estado_CheckedChanged);
            // 
            // Chk_codigo
            // 
            this.Chk_codigo.AutoSize = true;
            this.Chk_codigo.Location = new System.Drawing.Point(338, 17);
            this.Chk_codigo.Name = "Chk_codigo";
            this.Chk_codigo.Size = new System.Drawing.Size(225, 27);
            this.Chk_codigo.TabIndex = 42;
            this.Chk_codigo.Text = "Codigo automatico";
            this.Chk_codigo.UseVisualStyleBackColor = true;
            this.Chk_codigo.CheckedChanged += new System.EventHandler(this.Chk_codigo_CheckedChanged);
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dtp_fecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Dtp_fecha.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha.Location = new System.Drawing.Point(118, 86);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(133, 32);
            this.Dtp_fecha.TabIndex = 4;
            this.Dtp_fecha.ValueChanged += new System.EventHandler(this.Dtp_fecha_ValueChanged);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(26, 92);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(75, 23);
            this.Lbl_fecha.TabIndex = 37;
            this.Lbl_fecha.Text = "FECHA";
            // 
            // Grp_cancelar
            // 
            this.Grp_cancelar.Controls.Add(this.Btn_cancelar);
            this.Grp_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_cancelar.Location = new System.Drawing.Point(753, 86);
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
            this.Grp_guardar.Location = new System.Drawing.Point(640, 86);
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
            // Cbo_tipoMovimiento
            // 
            this.Cbo_tipoMovimiento.BackColor = System.Drawing.Color.White;
            this.Cbo_tipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_tipoMovimiento.FormattingEnabled = true;
            this.Cbo_tipoMovimiento.Location = new System.Drawing.Point(118, 51);
            this.Cbo_tipoMovimiento.Name = "Cbo_tipoMovimiento";
            this.Cbo_tipoMovimiento.Size = new System.Drawing.Size(212, 31);
            this.Cbo_tipoMovimiento.TabIndex = 3;
            this.Cbo_tipoMovimiento.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipoMovimiento_SelectedIndexChanged);
            // 
            // Lbl_tipoMovimiento
            // 
            this.Lbl_tipoMovimiento.AutoSize = true;
            this.Lbl_tipoMovimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoMovimiento.Location = new System.Drawing.Point(12, 56);
            this.Lbl_tipoMovimiento.Name = "Lbl_tipoMovimiento";
            this.Lbl_tipoMovimiento.Size = new System.Drawing.Size(113, 23);
            this.Lbl_tipoMovimiento.TabIndex = 31;
            this.Lbl_tipoMovimiento.Text = "TIPO MOV.";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.White;
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
            this.Lbl_codigo.Location = new System.Drawing.Point(12, 17);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(97, 23);
            this.Lbl_codigo.TabIndex = 27;
            this.Lbl_codigo.Text = "CODIGO";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.BackColor = System.Drawing.Color.White;
            this.Txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(118, 13);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(105, 32);
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
            this.Tbp_descripcion.Location = new System.Drawing.Point(4, 22);
            this.Tbp_descripcion.Name = "Tbp_descripcion";
            this.Tbp_descripcion.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_descripcion.Size = new System.Drawing.Size(877, 162);
            this.Tbp_descripcion.TabIndex = 1;
            this.Tbp_descripcion.Text = "Nota";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_descripcion.Location = new System.Drawing.Point(3, 3);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(871, 156);
            this.Txt_descripcion.TabIndex = 12;
            this.Txt_descripcion.TextChanged += new System.EventHandler(this.Txt_descripcion_TextChanged);
            // 
            // Frm_MovimientosInventarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(923, 642);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_MovimientosInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos de Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_MovimientosInventarios_FormClosed);
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimientoDetalle)).EndInit();
            this.Grp_producto.ResumeLayout(false);
            this.Grp_producto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).EndInit();
            this.Gpb_eliminar.ResumeLayout(false);
            this.Gpb_agregar.ResumeLayout(false);
            this.Grp_DatosMovimiento.ResumeLayout(false);
            this.Tbc_Datos.ResumeLayout(false);
            this.Tbp_Datos.ResumeLayout(false);
            this.Pnl_datos.ResumeLayout(false);
            this.Pnl_datos.PerformLayout();
            this.Grp_cancelar.ResumeLayout(false);
            this.Grp_guardar.ResumeLayout(false);
            this.Tbp_descripcion.ResumeLayout(false);
            this.Tbp_descripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.GroupBox Grp_producto;
        private System.Windows.Forms.GroupBox Grp_DatosMovimiento;
        private System.Windows.Forms.TabControl Tbc_Datos;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.Panel Pnl_datos;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
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
        private System.Windows.Forms.CheckBox Chk_codigo;
        private System.Windows.Forms.GroupBox Gpb_eliminar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Gpb_agregar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_producto;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.Label Lbl_costoTotal;
        private System.Windows.Forms.TextBox Txt_costoTotal;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.DataGridView Dgv_movimientoDetalle;
        private System.Windows.Forms.TextBox Txt_costo;
        private System.Windows.Forms.Label Lbl_costo;
        private System.Windows.Forms.NumericUpDown Nud_cantidad;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.TextBox Txt_producto;
        private System.Windows.Forms.CheckBox Chk_estado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_buscar;
        private CapaVista.Combo combo1;
        private System.Windows.Forms.ComboBox Cbo_tipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio;
        private System.Windows.Forms.Label ZZ;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_Verificar;
    }
}