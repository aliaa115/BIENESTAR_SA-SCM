using CapaVistaSCM.Lista;
using CapaVistaSCM.Mantenimiento;
using System;
using System.Windows.Forms;
using CapaDiseno;

namespace CapaVistaSCM
{
    public partial class MDI_SCM : Form
    {
        private int childFormNumber = 0;
        string usuario;

        public MDI_SCM()
        {
            InitializeComponent();
        }

        //funcion para mantenimientos
        private void mant(int tabla)
        {
            Frm_manteniminto mantenimiento = new Frm_manteniminto(usuario, tabla);
            mantenimiento.Show();
            mantenimiento.TopLevel = false;
            mantenimiento.TopMost = true;
            panel1.Controls.Add(mantenimiento);
        }
         //funcion para abrir las listas de encabezados segun sea necesario
        private void listas(int tabla, Form form)
        {
            Frm_lista lista = new Frm_lista(panel1, tabla, form, usuario);

            lista.MdiParent = this;
            lista.Show();
            lista.TopLevel = false;
            lista.TopMost = true;
            panel1.Controls.Add(lista);
        }

        private void MDI_SCM1_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuario = Lbl_usuario.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void contactosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(1);
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(2);
        }

        private void tiposDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(3);
        }

        private void impuestoSobreProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(4);
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(5);
        }

        private void acreedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(6);
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(7);
        }

        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(8);
        }

        private void lineasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(9);
        }
        private void presentacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(10);
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(11);
        }

        private void tiposDeMovimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(13);
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(14);
        }

        private void inventarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mant(15);
        }

        private void movimientoDeInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_MovimientosInventarios movimientosInventarios = null;
            listas(1, movimientosInventarios);
        }

        private void trasladoDeInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdenCompra ordenCompra = null;
            listas(3, ordenCompra);
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            Frm_cotizacionProveedores cotizacionProveedores = null;
            listas(4, cotizacionProveedores);*/
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();

        }
    }
}
