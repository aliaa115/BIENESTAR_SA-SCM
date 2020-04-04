namespace CapaVistaSCM
{
    partial class Frm_listaMovimientosInventario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Grp_guardar = new System.Windows.Forms.GroupBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tbl_movimientoInventario.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_desarrollo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Grp_guardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Tbl_movimientoInventario.TabIndex = 4;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Pnl_titulo.Controls.Add(this.Btn_MovInventario);
            this.Pnl_titulo.Controls.Add(this.Lbl_titulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_titulo.Location = new System.Drawing.Point(3, 3);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(794, 64);
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
            this.Btn_MovInventario.Location = new System.Drawing.Point(656, 0);
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
            this.Lbl_titulo.Size = new System.Drawing.Size(605, 47);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "MOVIMIENTOS DE INVENTARIO";
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.groupBox2);
            this.Pnl_desarrollo.Controls.Add(this.groupBox1);
            this.Pnl_desarrollo.Controls.Add(this.Grp_guardar);
            this.Pnl_desarrollo.Controls.Add(this.dataGridView1);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 73);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(794, 562);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox2.Location = new System.Drawing.Point(216, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 55);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINAR";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.button2.BackgroundImage = global::CapaVistaSCM.Properties.Resources._223_trash;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_nuevo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(114, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 55);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO";
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
            this.Btn_nuevo.Size = new System.Drawing.Size(90, 32);
            this.Btn_nuevo.TabIndex = 9;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Grp_guardar
            // 
            this.Grp_guardar.Controls.Add(this.Btn_guardar);
            this.Grp_guardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_guardar.Location = new System.Drawing.Point(9, 3);
            this.Grp_guardar.Name = "Grp_guardar";
            this.Grp_guardar.Size = new System.Drawing.Size(99, 55);
            this.Grp_guardar.TabIndex = 26;
            this.Grp_guardar.TabStop = false;
            this.Grp_guardar.Text = "VER";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_guardar.BackgroundImage = global::CapaVistaSCM.Properties.Resources._179_open_book_2;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Location = new System.Drawing.Point(3, 20);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(93, 32);
            this.Btn_guardar.TabIndex = 9;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_listaMovimientosInventario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_listaMovimientosInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Movimientos de Inventario";
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Grp_guardar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Grp_guardar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
    }
}