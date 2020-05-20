namespace CapaVistaSCM.Lista
{
    partial class Frm_lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_lista));
            this.Tbl_movimientoInventario = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_desarrollo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Grp_guardar = new System.Windows.Forms.GroupBox();
            this.Btn_ver = new System.Windows.Forms.Button();
            this.Grp_nuevo = new System.Windows.Forms.GroupBox();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Grp_editar = new System.Windows.Forms.GroupBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Grp_Cerrar = new System.Windows.Forms.GroupBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.Dgv_lista = new System.Windows.Forms.DataGridView();
            this.Tbl_movimientoInventario.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_desarrollo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Grp_guardar.SuspendLayout();
            this.Grp_nuevo.SuspendLayout();
            this.Grp_editar.SuspendLayout();
            this.Grp_Cerrar.SuspendLayout();
            this.pnl_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lista)).BeginInit();
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
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(800, 638);
            this.Tbl_movimientoInventario.TabIndex = 5;
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
            this.Pnl_titulo.Size = new System.Drawing.Size(794, 64);
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
            this.Btn_ayuda.Location = new System.Drawing.Point(653, 0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(37, 64);
            this.Btn_ayuda.TabIndex = 5;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_MovInventario
            // 
            this.Btn_MovInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.BackgroundImage = global::CapaVistaSCM.Properties.Resources._149_notepad_2;
            this.Btn_MovInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_MovInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_MovInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.BorderSize = 0;
            this.Btn_MovInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MovInventario.Location = new System.Drawing.Point(690, 0);
            this.Btn_MovInventario.Name = "Btn_MovInventario";
            this.Btn_MovInventario.Size = new System.Drawing.Size(104, 64);
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
            this.Lbl_titulo.Size = new System.Drawing.Size(0, 47);
            this.Lbl_titulo.TabIndex = 0;
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.tableLayoutPanel1);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 73);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(794, 562);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_contenedor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 562);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.Grp_guardar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Grp_nuevo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Grp_editar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Grp_Cerrar, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 64);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Grp_guardar
            // 
            this.Grp_guardar.Controls.Add(this.Btn_ver);
            this.Grp_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_guardar.Location = new System.Drawing.Point(3, 3);
            this.Grp_guardar.Name = "Grp_guardar";
            this.Grp_guardar.Size = new System.Drawing.Size(72, 55);
            this.Grp_guardar.TabIndex = 26;
            this.Grp_guardar.TabStop = false;
            this.Grp_guardar.Text = "VER";
            // 
            // Btn_ver
            // 
            this.Btn_ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_ver.BackgroundImage = global::CapaVistaSCM.Properties.Resources._179_open_book_2;
            this.Btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_ver.FlatAppearance.BorderSize = 0;
            this.Btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ver.Location = new System.Drawing.Point(3, 20);
            this.Btn_ver.Name = "Btn_ver";
            this.Btn_ver.Size = new System.Drawing.Size(66, 32);
            this.Btn_ver.TabIndex = 9;
            this.Btn_ver.UseVisualStyleBackColor = false;
            this.Btn_ver.Click += new System.EventHandler(this.Btn_ver_Click);
            // 
            // Grp_nuevo
            // 
            this.Grp_nuevo.Controls.Add(this.Btn_nuevo);
            this.Grp_nuevo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_nuevo.Location = new System.Drawing.Point(81, 3);
            this.Grp_nuevo.Name = "Grp_nuevo";
            this.Grp_nuevo.Size = new System.Drawing.Size(72, 55);
            this.Grp_nuevo.TabIndex = 27;
            this.Grp_nuevo.TabStop = false;
            this.Grp_nuevo.Text = "NUEVO";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_nuevo.BackgroundImage = global::CapaVistaSCM.Properties.Resources._108_inbox_4;
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Location = new System.Drawing.Point(3, 20);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(66, 32);
            this.Btn_nuevo.TabIndex = 9;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Grp_editar
            // 
            this.Grp_editar.Controls.Add(this.Btn_editar);
            this.Grp_editar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_editar.Location = new System.Drawing.Point(159, 3);
            this.Grp_editar.Name = "Grp_editar";
            this.Grp_editar.Size = new System.Drawing.Size(72, 55);
            this.Grp_editar.TabIndex = 28;
            this.Grp_editar.TabStop = false;
            this.Grp_editar.Text = "EDITAR";
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_editar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._159_pencil;
            this.Btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_editar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_editar.FlatAppearance.BorderSize = 0;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Location = new System.Drawing.Point(3, 20);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(66, 32);
            this.Btn_editar.TabIndex = 9;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Grp_Cerrar
            // 
            this.Grp_Cerrar.Controls.Add(this.Btn_Cerrar);
            this.Grp_Cerrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_Cerrar.Location = new System.Drawing.Point(709, 3);
            this.Grp_Cerrar.Name = "Grp_Cerrar";
            this.Grp_Cerrar.Size = new System.Drawing.Size(72, 55);
            this.Grp_Cerrar.TabIndex = 29;
            this.Grp_Cerrar.TabStop = false;
            this.Grp_Cerrar.Text = "CERRAR";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_Cerrar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._243_exit;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Location = new System.Drawing.Point(3, 20);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(66, 32);
            this.Btn_Cerrar.TabIndex = 9;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Controls.Add(this.Dgv_lista);
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedor.Location = new System.Drawing.Point(3, 73);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(788, 486);
            this.pnl_contenedor.TabIndex = 2;
            // 
            // Dgv_lista
            // 
            this.Dgv_lista.AllowUserToAddRows = false;
            this.Dgv_lista.AllowUserToDeleteRows = false;
            this.Dgv_lista.AllowUserToOrderColumns = true;
            this.Dgv_lista.AllowUserToResizeColumns = false;
            this.Dgv_lista.AllowUserToResizeRows = false;
            this.Dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_lista.Location = new System.Drawing.Point(0, 0);
            this.Dgv_lista.Name = "Dgv_lista";
            this.Dgv_lista.RowHeadersVisible = false;
            this.Dgv_lista.RowHeadersWidth = 51;
            this.Dgv_lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_lista.Size = new System.Drawing.Size(788, 486);
            this.Dgv_lista.TabIndex = 1;
            // 
            // Frm_lista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_lista";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_lista_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_lista_VisibleChanged);
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Grp_guardar.ResumeLayout(false);
            this.Grp_nuevo.ResumeLayout(false);
            this.Grp_editar.ResumeLayout(false);
            this.Grp_Cerrar.ResumeLayout(false);
            this.pnl_contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private System.Windows.Forms.GroupBox Grp_editar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.GroupBox Grp_nuevo;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.GroupBox Grp_guardar;
        private System.Windows.Forms.Button Btn_ver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox Grp_Cerrar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Panel pnl_contenedor;
        public System.Windows.Forms.DataGridView Dgv_lista;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}