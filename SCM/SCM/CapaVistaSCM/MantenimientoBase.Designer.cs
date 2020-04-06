﻿namespace CapaVistaSCM
{
    partial class MantenimientoBase
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
            this.navegador1 = new CapaDeDiseno.Navegador();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.Tbl_movimientoInventario.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_desarrollo.SuspendLayout();
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
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(844, 721);
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
            this.Pnl_titulo.Size = new System.Drawing.Size(838, 64);
            this.Pnl_titulo.TabIndex = 0;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.Lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(138, 47);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "TABLA";
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.navegador1);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 73);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(838, 645);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.navegador1.Location = new System.Drawing.Point(3, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(838, 650);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.Navegador1_Load_1);
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
            this.Btn_MovInventario.Location = new System.Drawing.Point(700, 0);
            this.Btn_MovInventario.Name = "Btn_MovInventario";
            this.Btn_MovInventario.Size = new System.Drawing.Size(138, 64);
            this.Btn_MovInventario.TabIndex = 3;
            this.Btn_MovInventario.UseVisualStyleBackColor = false;
            // 
            // MantenimientoBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 721);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MantenimientoBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private CapaDeDiseno.Navegador navegador1;
    }
}