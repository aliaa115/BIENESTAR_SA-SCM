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
            this.Tbl_movimientoInventario = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_desarrollo = new System.Windows.Forms.Panel();
            this.Grp_movimientoDetalle = new System.Windows.Forms.GroupBox();
            this.Lbl_costoTotal = new System.Windows.Forms.Label();
            this.Txt_costoTotal = new System.Windows.Forms.TextBox();
            this.Lbl_precioTotal = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Grp_agregarProducto = new System.Windows.Forms.GroupBox();
            this.Btn_agregarProducto = new System.Windows.Forms.Button();
            this.Dgv_movimientoDetalle = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_DatosMovimiento = new System.Windows.Forms.GroupBox();
            this.Tbc_Datos = new System.Windows.Forms.TabControl();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.Pnl_datos = new System.Windows.Forms.Panel();
            this.Cmb_ordenTransporte = new System.Windows.Forms.ComboBox();
            this.Lbl_ordenTransporte = new System.Windows.Forms.Label();
            this.Cmb_documentoAsociado = new System.Windows.Forms.ComboBox();
            this.Lbl_DocAsociado = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Grp_cancelar = new System.Windows.Forms.GroupBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Cbo_bodegaEntrada = new System.Windows.Forms.ComboBox();
            this.Grp_guardar = new System.Windows.Forms.GroupBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_bodegaEntrada = new System.Windows.Forms.Label();
            this.Cbo_bodegaSalida = new System.Windows.Forms.ComboBox();
            this.Lbl_bodegaSalida = new System.Windows.Forms.Label();
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
            this.Grp_movimientoDetalle.SuspendLayout();
            this.Grp_agregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimientoDetalle)).BeginInit();
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
            this.Tbl_movimientoInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tbl_movimientoInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(1189, 650);
            this.Tbl_movimientoInventario.TabIndex = 1;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Pnl_titulo.Controls.Add(this.Btn_MovInventario);
            this.Pnl_titulo.Controls.Add(this.Lbl_titulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_titulo.Location = new System.Drawing.Point(3, 3);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1183, 124);
            this.Pnl_titulo.TabIndex = 0;
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
            this.Btn_MovInventario.Location = new System.Drawing.Point(1045, 0);
            this.Btn_MovInventario.Name = "Btn_MovInventario";
            this.Btn_MovInventario.Size = new System.Drawing.Size(138, 124);
            this.Btn_MovInventario.TabIndex = 3;
            this.Btn_MovInventario.UseVisualStyleBackColor = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(894, 80);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Movimientos de Inventario";
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.Grp_movimientoDetalle);
            this.Pnl_desarrollo.Controls.Add(this.Grp_DatosMovimiento);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 133);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(1183, 514);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // Grp_movimientoDetalle
            // 
            this.Grp_movimientoDetalle.Controls.Add(this.Lbl_costoTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Txt_costoTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Lbl_precioTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Txt_precioTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Grp_agregarProducto);
            this.Grp_movimientoDetalle.Controls.Add(this.Dgv_movimientoDetalle);
            this.Grp_movimientoDetalle.Location = new System.Drawing.Point(3, 223);
            this.Grp_movimientoDetalle.Name = "Grp_movimientoDetalle";
            this.Grp_movimientoDetalle.Size = new System.Drawing.Size(1172, 288);
            this.Grp_movimientoDetalle.TabIndex = 15;
            this.Grp_movimientoDetalle.TabStop = false;
            this.Grp_movimientoDetalle.Text = "DETALLE DE PRODUCTOS";
            // 
            // Lbl_costoTotal
            // 
            this.Lbl_costoTotal.AutoSize = true;
            this.Lbl_costoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costoTotal.Location = new System.Drawing.Point(5, 52);
            this.Lbl_costoTotal.Name = "Lbl_costoTotal";
            this.Lbl_costoTotal.Size = new System.Drawing.Size(112, 19);
            this.Lbl_costoTotal.TabIndex = 23;
            this.Lbl_costoTotal.Text = "COSTO TOTAL";
            // 
            // Txt_costoTotal
            // 
            this.Txt_costoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_costoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_costoTotal.Enabled = false;
            this.Txt_costoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_costoTotal.Location = new System.Drawing.Point(125, 52);
            this.Txt_costoTotal.Name = "Txt_costoTotal";
            this.Txt_costoTotal.Size = new System.Drawing.Size(233, 20);
            this.Txt_costoTotal.TabIndex = 24;
            // 
            // Lbl_precioTotal
            // 
            this.Lbl_precioTotal.AutoSize = true;
            this.Lbl_precioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precioTotal.Location = new System.Drawing.Point(5, 26);
            this.Lbl_precioTotal.Name = "Lbl_precioTotal";
            this.Lbl_precioTotal.Size = new System.Drawing.Size(114, 19);
            this.Lbl_precioTotal.TabIndex = 21;
            this.Lbl_precioTotal.Text = "PRECIO TOTAL";
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_precioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_precioTotal.Enabled = false;
            this.Txt_precioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(125, 26);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(233, 20);
            this.Txt_precioTotal.TabIndex = 22;
            // 
            // Grp_agregarProducto
            // 
            this.Grp_agregarProducto.Controls.Add(this.Btn_agregarProducto);
            this.Grp_agregarProducto.Location = new System.Drawing.Point(954, 26);
            this.Grp_agregarProducto.Name = "Grp_agregarProducto";
            this.Grp_agregarProducto.Size = new System.Drawing.Size(211, 54);
            this.Grp_agregarProducto.TabIndex = 8;
            this.Grp_agregarProducto.TabStop = false;
            this.Grp_agregarProducto.Text = "AGREGAR PRODUCTO";
            // 
            // Btn_agregarProducto
            // 
            this.Btn_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_agregarProducto.BackgroundImage = global::CapaVistaSCM.Properties.Resources._065_edit;
            this.Btn_agregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_agregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.Btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarProducto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Btn_agregarProducto.Location = new System.Drawing.Point(3, 23);
            this.Btn_agregarProducto.Name = "Btn_agregarProducto";
            this.Btn_agregarProducto.Size = new System.Drawing.Size(205, 28);
            this.Btn_agregarProducto.TabIndex = 8;
            this.Btn_agregarProducto.UseVisualStyleBackColor = false;
            this.Btn_agregarProducto.Click += new System.EventHandler(this.Button1_Click);
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
            this.Producto,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Costo});
            this.Dgv_movimientoDetalle.Location = new System.Drawing.Point(5, 86);
            this.Dgv_movimientoDetalle.Name = "Dgv_movimientoDetalle";
            this.Dgv_movimientoDetalle.ReadOnly = true;
            this.Dgv_movimientoDetalle.RowHeadersVisible = false;
            this.Dgv_movimientoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_movimientoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_movimientoDetalle.Size = new System.Drawing.Size(1160, 198);
            this.Dgv_movimientoDetalle.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Grp_DatosMovimiento
            // 
            this.Grp_DatosMovimiento.Controls.Add(this.Tbc_Datos);
            this.Grp_DatosMovimiento.Location = new System.Drawing.Point(3, 3);
            this.Grp_DatosMovimiento.Name = "Grp_DatosMovimiento";
            this.Grp_DatosMovimiento.Size = new System.Drawing.Size(1175, 214);
            this.Grp_DatosMovimiento.TabIndex = 14;
            this.Grp_DatosMovimiento.TabStop = false;
            this.Grp_DatosMovimiento.Text = "DATOS DE MOVIMIENTO DE INVENTARIO";
            // 
            // Tbc_Datos
            // 
            this.Tbc_Datos.Controls.Add(this.Tbp_Datos);
            this.Tbc_Datos.Controls.Add(this.Tbp_descripcion);
            this.Tbc_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Datos.Location = new System.Drawing.Point(3, 23);
            this.Tbc_Datos.Name = "Tbc_Datos";
            this.Tbc_Datos.SelectedIndex = 0;
            this.Tbc_Datos.Size = new System.Drawing.Size(1169, 188);
            this.Tbc_Datos.TabIndex = 0;
            // 
            // Tbp_Datos
            // 
            this.Tbp_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Tbp_Datos.Controls.Add(this.Pnl_datos);
            this.Tbp_Datos.Location = new System.Drawing.Point(4, 30);
            this.Tbp_Datos.Name = "Tbp_Datos";
            this.Tbp_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Datos.Size = new System.Drawing.Size(1161, 154);
            this.Tbp_Datos.TabIndex = 0;
            this.Tbp_Datos.Text = "Datos";
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_datos.Controls.Add(this.Cmb_ordenTransporte);
            this.Pnl_datos.Controls.Add(this.Lbl_ordenTransporte);
            this.Pnl_datos.Controls.Add(this.Cmb_documentoAsociado);
            this.Pnl_datos.Controls.Add(this.Lbl_DocAsociado);
            this.Pnl_datos.Controls.Add(this.Dtp_fecha);
            this.Pnl_datos.Controls.Add(this.Lbl_fecha);
            this.Pnl_datos.Controls.Add(this.Grp_cancelar);
            this.Pnl_datos.Controls.Add(this.Cbo_bodegaEntrada);
            this.Pnl_datos.Controls.Add(this.Grp_guardar);
            this.Pnl_datos.Controls.Add(this.Lbl_bodegaEntrada);
            this.Pnl_datos.Controls.Add(this.Cbo_bodegaSalida);
            this.Pnl_datos.Controls.Add(this.Lbl_bodegaSalida);
            this.Pnl_datos.Controls.Add(this.Cbo_tipoMovimiento);
            this.Pnl_datos.Controls.Add(this.Lbl_tipoMovimiento);
            this.Pnl_datos.Controls.Add(this.Txt_nombre);
            this.Pnl_datos.Controls.Add(this.Lbl_codigo);
            this.Pnl_datos.Controls.Add(this.Txt_codigo);
            this.Pnl_datos.Controls.Add(this.Lbl_nombre);
            this.Pnl_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_datos.Location = new System.Drawing.Point(3, 3);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(1155, 148);
            this.Pnl_datos.TabIndex = 0;
            // 
            // Cmb_ordenTransporte
            // 
            this.Cmb_ordenTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cmb_ordenTransporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_ordenTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_ordenTransporte.FormattingEnabled = true;
            this.Cmb_ordenTransporte.Location = new System.Drawing.Point(692, 110);
            this.Cmb_ordenTransporte.Name = "Cmb_ordenTransporte";
            this.Cmb_ordenTransporte.Size = new System.Drawing.Size(238, 28);
            this.Cmb_ordenTransporte.TabIndex = 8;
            // 
            // Lbl_ordenTransporte
            // 
            this.Lbl_ordenTransporte.AutoSize = true;
            this.Lbl_ordenTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ordenTransporte.Location = new System.Drawing.Point(488, 114);
            this.Lbl_ordenTransporte.Name = "Lbl_ordenTransporte";
            this.Lbl_ordenTransporte.Size = new System.Drawing.Size(183, 19);
            this.Lbl_ordenTransporte.TabIndex = 41;
            this.Lbl_ordenTransporte.Text = "ORDEN DE TRASNPORTE";
            // 
            // Cmb_documentoAsociado
            // 
            this.Cmb_documentoAsociado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cmb_documentoAsociado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_documentoAsociado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_documentoAsociado.FormattingEnabled = true;
            this.Cmb_documentoAsociado.Location = new System.Drawing.Point(215, 110);
            this.Cmb_documentoAsociado.Name = "Cmb_documentoAsociado";
            this.Cmb_documentoAsociado.Size = new System.Drawing.Size(242, 28);
            this.Cmb_documentoAsociado.TabIndex = 7;
            // 
            // Lbl_DocAsociado
            // 
            this.Lbl_DocAsociado.AutoSize = true;
            this.Lbl_DocAsociado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DocAsociado.Location = new System.Drawing.Point(11, 114);
            this.Lbl_DocAsociado.Name = "Lbl_DocAsociado";
            this.Lbl_DocAsociado.Size = new System.Drawing.Size(198, 19);
            this.Lbl_DocAsociado.TabIndex = 39;
            this.Lbl_DocAsociado.Text = "DOCUMENTO ASOCIADO";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dtp_fecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Dtp_fecha.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fecha.Location = new System.Drawing.Point(404, 41);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(477, 27);
            this.Dtp_fecha.TabIndex = 4;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(338, 47);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(60, 19);
            this.Lbl_fecha.TabIndex = 37;
            this.Lbl_fecha.Text = "FECHA";
            // 
            // Grp_cancelar
            // 
            this.Grp_cancelar.Controls.Add(this.Btn_cancelar);
            this.Grp_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_cancelar.Location = new System.Drawing.Point(1050, -4);
            this.Grp_cancelar.Name = "Grp_cancelar";
            this.Grp_cancelar.Size = new System.Drawing.Size(110, 60);
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
            this.Btn_cancelar.Location = new System.Drawing.Point(3, 20);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(104, 37);
            this.Btn_cancelar.TabIndex = 10;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // Cbo_bodegaEntrada
            // 
            this.Cbo_bodegaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cbo_bodegaEntrada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_bodegaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_bodegaEntrada.FormattingEnabled = true;
            this.Cbo_bodegaEntrada.Location = new System.Drawing.Point(644, 74);
            this.Cbo_bodegaEntrada.Name = "Cbo_bodegaEntrada";
            this.Cbo_bodegaEntrada.Size = new System.Drawing.Size(286, 28);
            this.Cbo_bodegaEntrada.TabIndex = 6;
            // 
            // Grp_guardar
            // 
            this.Grp_guardar.Controls.Add(this.Btn_guardar);
            this.Grp_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_guardar.Location = new System.Drawing.Point(937, -4);
            this.Grp_guardar.Name = "Grp_guardar";
            this.Grp_guardar.Size = new System.Drawing.Size(107, 60);
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
            this.Btn_guardar.Location = new System.Drawing.Point(3, 20);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(101, 37);
            this.Btn_guardar.TabIndex = 9;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Lbl_bodegaEntrada
            // 
            this.Lbl_bodegaEntrada.AutoSize = true;
            this.Lbl_bodegaEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_bodegaEntrada.Location = new System.Drawing.Point(488, 78);
            this.Lbl_bodegaEntrada.Name = "Lbl_bodegaEntrada";
            this.Lbl_bodegaEntrada.Size = new System.Drawing.Size(150, 19);
            this.Lbl_bodegaEntrada.TabIndex = 35;
            this.Lbl_bodegaEntrada.Text = "BODEGA ENTRADA";
            // 
            // Cbo_bodegaSalida
            // 
            this.Cbo_bodegaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cbo_bodegaSalida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_bodegaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_bodegaSalida.FormattingEnabled = true;
            this.Cbo_bodegaSalida.Location = new System.Drawing.Point(151, 74);
            this.Cbo_bodegaSalida.Name = "Cbo_bodegaSalida";
            this.Cbo_bodegaSalida.Size = new System.Drawing.Size(306, 28);
            this.Cbo_bodegaSalida.TabIndex = 5;
            // 
            // Lbl_bodegaSalida
            // 
            this.Lbl_bodegaSalida.AutoSize = true;
            this.Lbl_bodegaSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_bodegaSalida.Location = new System.Drawing.Point(12, 78);
            this.Lbl_bodegaSalida.Name = "Lbl_bodegaSalida";
            this.Lbl_bodegaSalida.Size = new System.Drawing.Size(133, 19);
            this.Lbl_bodegaSalida.TabIndex = 33;
            this.Lbl_bodegaSalida.Text = "BODEGA SALIDA";
            // 
            // Cbo_tipoMovimiento
            // 
            this.Cbo_tipoMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cbo_tipoMovimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_tipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_tipoMovimiento.FormattingEnabled = true;
            this.Cbo_tipoMovimiento.Location = new System.Drawing.Point(106, 43);
            this.Cbo_tipoMovimiento.Name = "Cbo_tipoMovimiento";
            this.Cbo_tipoMovimiento.Size = new System.Drawing.Size(226, 28);
            this.Cbo_tipoMovimiento.TabIndex = 3;
            // 
            // Lbl_tipoMovimiento
            // 
            this.Lbl_tipoMovimiento.AutoSize = true;
            this.Lbl_tipoMovimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoMovimiento.Location = new System.Drawing.Point(12, 47);
            this.Lbl_tipoMovimiento.Name = "Lbl_tipoMovimiento";
            this.Lbl_tipoMovimiento.Size = new System.Drawing.Size(88, 19);
            this.Lbl_tipoMovimiento.TabIndex = 31;
            this.Lbl_tipoMovimiento.Text = "TIPO MOV.";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.White;
            this.Txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(426, 17);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(454, 20);
            this.Txt_nombre.TabIndex = 2;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(11, 17);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_codigo.TabIndex = 27;
            this.Lbl_codigo.Text = "CODIGO";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_codigo.Enabled = false;
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(99, 17);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(233, 20);
            this.Txt_codigo.TabIndex = 1;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(338, 17);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(74, 19);
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
            this.Tbp_descripcion.Size = new System.Drawing.Size(1161, 159);
            this.Tbp_descripcion.TabIndex = 1;
            this.Tbp_descripcion.Text = "Nota";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(3, 6);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(1152, 142);
            this.Txt_descripcion.TabIndex = 12;
            // 
            // Frm_MovimientosInventarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1189, 650);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_MovimientosInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMIENTO DE INVENTARIO ";
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.Grp_movimientoDetalle.ResumeLayout(false);
            this.Grp_movimientoDetalle.PerformLayout();
            this.Grp_agregarProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimientoDetalle)).EndInit();
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
        private System.Windows.Forms.DataGridView Dgv_movimientoDetalle;
        private System.Windows.Forms.GroupBox Grp_movimientoDetalle;
        private System.Windows.Forms.GroupBox Grp_DatosMovimiento;
        private System.Windows.Forms.GroupBox Grp_agregarProducto;
        private System.Windows.Forms.Button Btn_agregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Label Lbl_costoTotal;
        private System.Windows.Forms.TextBox Txt_costoTotal;
        private System.Windows.Forms.Label Lbl_precioTotal;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.TabControl Tbc_Datos;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.Panel Pnl_datos;
        private System.Windows.Forms.ComboBox Cmb_ordenTransporte;
        private System.Windows.Forms.Label Lbl_ordenTransporte;
        private System.Windows.Forms.ComboBox Cmb_documentoAsociado;
        private System.Windows.Forms.Label Lbl_DocAsociado;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.GroupBox Grp_cancelar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.ComboBox Cbo_bodegaEntrada;
        private System.Windows.Forms.GroupBox Grp_guardar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_bodegaEntrada;
        private System.Windows.Forms.ComboBox Cbo_bodegaSalida;
        private System.Windows.Forms.Label Lbl_bodegaSalida;
        private System.Windows.Forms.ComboBox Cbo_tipoMovimiento;
        private System.Windows.Forms.Label Lbl_tipoMovimiento;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TabPage Tbp_descripcion;
        private System.Windows.Forms.TextBox Txt_descripcion;
    }
}