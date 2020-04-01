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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_desarrollo = new System.Windows.Forms.Panel();
            this.Grp_movimientoDetalle = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_movimientoDetalle = new System.Windows.Forms.DataGridView();
            this.Grp_DatosMovimiento = new System.Windows.Forms.GroupBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Grp_cancelar = new System.Windows.Forms.GroupBox();
            this.Cbo_bodegaEntrada = new System.Windows.Forms.ComboBox();
            this.Grp_guardar = new System.Windows.Forms.GroupBox();
            this.Lbl_bodegaEntrada = new System.Windows.Forms.Label();
            this.Cbo_bodegaSalida = new System.Windows.Forms.ComboBox();
            this.Lbl_bodegaSalida = new System.Windows.Forms.Label();
            this.Cbo_tipoMovimiento = new System.Windows.Forms.ComboBox();
            this.Lbl_tipoMovimiento = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_precioTotal = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Lbl_costoTotal = new System.Windows.Forms.Label();
            this.Txt_costoTotal = new System.Windows.Forms.TextBox();
            this.Tbl_movimientoInventario.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_desarrollo.SuspendLayout();
            this.Grp_movimientoDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimientoDetalle)).BeginInit();
            this.Grp_DatosMovimiento.SuspendLayout();
            this.Grp_cancelar.SuspendLayout();
            this.Grp_guardar.SuspendLayout();
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
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(1189, 624);
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
            this.Pnl_titulo.Size = new System.Drawing.Size(1183, 118);
            this.Pnl_titulo.TabIndex = 0;
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
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 127);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(1183, 494);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // Grp_movimientoDetalle
            // 
            this.Grp_movimientoDetalle.Controls.Add(this.Lbl_costoTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Txt_costoTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Lbl_precioTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.Txt_precioTotal);
            this.Grp_movimientoDetalle.Controls.Add(this.groupBox1);
            this.Grp_movimientoDetalle.Controls.Add(this.Dgv_movimientoDetalle);
            this.Grp_movimientoDetalle.Location = new System.Drawing.Point(3, 178);
            this.Grp_movimientoDetalle.Name = "Grp_movimientoDetalle";
            this.Grp_movimientoDetalle.Size = new System.Drawing.Size(1172, 313);
            this.Grp_movimientoDetalle.TabIndex = 15;
            this.Grp_movimientoDetalle.TabStop = false;
            this.Grp_movimientoDetalle.Text = "DETALLE DE PRODUCTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(955, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR PRODUCTO";
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
            this.Dgv_movimientoDetalle.Location = new System.Drawing.Point(6, 109);
            this.Dgv_movimientoDetalle.Name = "Dgv_movimientoDetalle";
            this.Dgv_movimientoDetalle.ReadOnly = true;
            this.Dgv_movimientoDetalle.RowHeadersVisible = false;
            this.Dgv_movimientoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_movimientoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_movimientoDetalle.Size = new System.Drawing.Size(1160, 198);
            this.Dgv_movimientoDetalle.TabIndex = 0;
            // 
            // Grp_DatosMovimiento
            // 
            this.Grp_DatosMovimiento.Controls.Add(this.Dtp_fecha);
            this.Grp_DatosMovimiento.Controls.Add(this.label1);
            this.Grp_DatosMovimiento.Controls.Add(this.Grp_cancelar);
            this.Grp_DatosMovimiento.Controls.Add(this.Cbo_bodegaEntrada);
            this.Grp_DatosMovimiento.Controls.Add(this.Grp_guardar);
            this.Grp_DatosMovimiento.Controls.Add(this.Lbl_bodegaEntrada);
            this.Grp_DatosMovimiento.Controls.Add(this.Cbo_bodegaSalida);
            this.Grp_DatosMovimiento.Controls.Add(this.Lbl_bodegaSalida);
            this.Grp_DatosMovimiento.Controls.Add(this.Cbo_tipoMovimiento);
            this.Grp_DatosMovimiento.Controls.Add(this.Lbl_tipoMovimiento);
            this.Grp_DatosMovimiento.Controls.Add(this.Txt_nombre);
            this.Grp_DatosMovimiento.Controls.Add(this.Lbl_codigo);
            this.Grp_DatosMovimiento.Controls.Add(this.Txt_codigo);
            this.Grp_DatosMovimiento.Controls.Add(this.Lbl_nombre);
            this.Grp_DatosMovimiento.Location = new System.Drawing.Point(3, 3);
            this.Grp_DatosMovimiento.Name = "Grp_DatosMovimiento";
            this.Grp_DatosMovimiento.Size = new System.Drawing.Size(1175, 169);
            this.Grp_DatosMovimiento.TabIndex = 14;
            this.Grp_DatosMovimiento.TabStop = false;
            this.Grp_DatosMovimiento.Text = "DATOS DE MOVIMIENTO DE INVENTARIO";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dtp_fecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Dtp_fecha.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fecha.Location = new System.Drawing.Point(73, 120);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 27);
            this.Dtp_fecha.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "FECHA";
            // 
            // Grp_cancelar
            // 
            this.Grp_cancelar.Controls.Add(this.Btn_cancelar);
            this.Grp_cancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_cancelar.Location = new System.Drawing.Point(1062, 20);
            this.Grp_cancelar.Name = "Grp_cancelar";
            this.Grp_cancelar.Size = new System.Drawing.Size(110, 77);
            this.Grp_cancelar.TabIndex = 8;
            this.Grp_cancelar.TabStop = false;
            this.Grp_cancelar.Text = "CANCELAR";
            // 
            // Cbo_bodegaEntrada
            // 
            this.Cbo_bodegaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cbo_bodegaEntrada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_bodegaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_bodegaEntrada.FormattingEnabled = true;
            this.Cbo_bodegaEntrada.Location = new System.Drawing.Point(614, 86);
            this.Cbo_bodegaEntrada.Name = "Cbo_bodegaEntrada";
            this.Cbo_bodegaEntrada.Size = new System.Drawing.Size(306, 28);
            this.Cbo_bodegaEntrada.TabIndex = 18;
            // 
            // Grp_guardar
            // 
            this.Grp_guardar.Controls.Add(this.Btn_guardar);
            this.Grp_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_guardar.Location = new System.Drawing.Point(949, 20);
            this.Grp_guardar.Name = "Grp_guardar";
            this.Grp_guardar.Size = new System.Drawing.Size(107, 77);
            this.Grp_guardar.TabIndex = 7;
            this.Grp_guardar.TabStop = false;
            this.Grp_guardar.Text = "GUARDAR";
            // 
            // Lbl_bodegaEntrada
            // 
            this.Lbl_bodegaEntrada.AutoSize = true;
            this.Lbl_bodegaEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_bodegaEntrada.Location = new System.Drawing.Point(458, 90);
            this.Lbl_bodegaEntrada.Name = "Lbl_bodegaEntrada";
            this.Lbl_bodegaEntrada.Size = new System.Drawing.Size(150, 19);
            this.Lbl_bodegaEntrada.TabIndex = 17;
            this.Lbl_bodegaEntrada.Text = "BODEGA ENTRADA";
            // 
            // Cbo_bodegaSalida
            // 
            this.Cbo_bodegaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cbo_bodegaSalida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_bodegaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_bodegaSalida.FormattingEnabled = true;
            this.Cbo_bodegaSalida.Location = new System.Drawing.Point(146, 86);
            this.Cbo_bodegaSalida.Name = "Cbo_bodegaSalida";
            this.Cbo_bodegaSalida.Size = new System.Drawing.Size(306, 28);
            this.Cbo_bodegaSalida.TabIndex = 16;
            // 
            // Lbl_bodegaSalida
            // 
            this.Lbl_bodegaSalida.AutoSize = true;
            this.Lbl_bodegaSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_bodegaSalida.Location = new System.Drawing.Point(7, 90);
            this.Lbl_bodegaSalida.Name = "Lbl_bodegaSalida";
            this.Lbl_bodegaSalida.Size = new System.Drawing.Size(133, 19);
            this.Lbl_bodegaSalida.TabIndex = 15;
            this.Lbl_bodegaSalida.Text = "BODEGA SALIDA";
            // 
            // Cbo_tipoMovimiento
            // 
            this.Cbo_tipoMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Cbo_tipoMovimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_tipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_tipoMovimiento.FormattingEnabled = true;
            this.Cbo_tipoMovimiento.Location = new System.Drawing.Point(101, 52);
            this.Cbo_tipoMovimiento.Name = "Cbo_tipoMovimiento";
            this.Cbo_tipoMovimiento.Size = new System.Drawing.Size(226, 28);
            this.Cbo_tipoMovimiento.TabIndex = 14;
            // 
            // Lbl_tipoMovimiento
            // 
            this.Lbl_tipoMovimiento.AutoSize = true;
            this.Lbl_tipoMovimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoMovimiento.Location = new System.Drawing.Point(7, 56);
            this.Lbl_tipoMovimiento.Name = "Lbl_tipoMovimiento";
            this.Lbl_tipoMovimiento.Size = new System.Drawing.Size(88, 19);
            this.Lbl_tipoMovimiento.TabIndex = 13;
            this.Lbl_tipoMovimiento.Text = "TIPO MOV.";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.BackColor = System.Drawing.Color.White;
            this.Txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(421, 26);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(470, 20);
            this.Txt_nombre.TabIndex = 12;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(6, 26);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_codigo.TabIndex = 9;
            this.Lbl_codigo.Text = "CODIGO";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_codigo.Enabled = false;
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(94, 26);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(233, 20);
            this.Txt_codigo.TabIndex = 10;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(333, 26);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(74, 19);
            this.Lbl_nombre.TabIndex = 11;
            this.Lbl_nombre.Text = "NOMBRE";
            // 
            // Btn_MovInventario
            // 
            this.Btn_MovInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.BackgroundImage = global::CapaVistaSCM.Properties.Resources._092_package;
            this.Btn_MovInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_MovInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_MovInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.BorderSize = 0;
            this.Btn_MovInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MovInventario.Location = new System.Drawing.Point(1045, 0);
            this.Btn_MovInventario.Name = "Btn_MovInventario";
            this.Btn_MovInventario.Size = new System.Drawing.Size(138, 118);
            this.Btn_MovInventario.TabIndex = 3;
            this.Btn_MovInventario.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.button1.BackgroundImage = global::CapaVistaSCM.Properties.Resources._065_edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(3, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 51);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.Btn_cancelar.Size = new System.Drawing.Size(104, 54);
            this.Btn_cancelar.TabIndex = 4;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
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
            this.Btn_guardar.Size = new System.Drawing.Size(101, 54);
            this.Btn_guardar.TabIndex = 2;
            this.Btn_guardar.UseVisualStyleBackColor = false;
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
            // Lbl_precioTotal
            // 
            this.Lbl_precioTotal.AutoSize = true;
            this.Lbl_precioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precioTotal.Location = new System.Drawing.Point(6, 37);
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
            this.Txt_precioTotal.Location = new System.Drawing.Point(126, 37);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(233, 20);
            this.Txt_precioTotal.TabIndex = 22;
            // 
            // Lbl_costoTotal
            // 
            this.Lbl_costoTotal.AutoSize = true;
            this.Lbl_costoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costoTotal.Location = new System.Drawing.Point(6, 63);
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
            this.Txt_costoTotal.Location = new System.Drawing.Point(126, 63);
            this.Txt_costoTotal.Name = "Txt_costoTotal";
            this.Txt_costoTotal.Size = new System.Drawing.Size(233, 20);
            this.Txt_costoTotal.TabIndex = 24;
            // 
            // Frm_MovimientosInventarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1189, 624);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_MovimientosInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.Grp_movimientoDetalle.ResumeLayout(false);
            this.Grp_movimientoDetalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimientoDetalle)).EndInit();
            this.Grp_DatosMovimiento.ResumeLayout(false);
            this.Grp_DatosMovimiento.PerformLayout();
            this.Grp_cancelar.ResumeLayout(false);
            this.Grp_guardar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.GroupBox Grp_cancelar;
        private System.Windows.Forms.GroupBox Grp_guardar;
        private System.Windows.Forms.DataGridView Dgv_movimientoDetalle;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.GroupBox Grp_movimientoDetalle;
        private System.Windows.Forms.GroupBox Grp_DatosMovimiento;
        private System.Windows.Forms.ComboBox Cbo_tipoMovimiento;
        private System.Windows.Forms.Label Lbl_tipoMovimiento;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_bodegaEntrada;
        private System.Windows.Forms.Label Lbl_bodegaEntrada;
        private System.Windows.Forms.ComboBox Cbo_bodegaSalida;
        private System.Windows.Forms.Label Lbl_bodegaSalida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Label Lbl_costoTotal;
        private System.Windows.Forms.TextBox Txt_costoTotal;
        private System.Windows.Forms.Label Lbl_precioTotal;
        private System.Windows.Forms.TextBox Txt_precioTotal;
    }
}