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

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void mant(int tabla)
        {
            Frm_manteniminto contacto = new Frm_manteniminto(usuario, tabla);
            contacto.Show();
        }

        private void listas(int tabla, Form form)
        {
            Frm_lista lista = null;

            switch (tabla)
            {
                case 1:
                    lista = new Frm_lista(tabla, form, usuario);
                    break;
            }

            lista.Show();
        }

        private void listaDeOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaOrdenesCompra listaOrdenesCompra = new Frm_listaOrdenesCompra();
            listaOrdenesCompra.Show();
        }

        private void movimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovimientosInventarios movimientosInventarios = null;
            listas(1, movimientosInventarios);
            // movimientosInventarios.Show();
        }

        private void listaDeCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaCotizaciones listaCotizaciones = new Frm_listaCotizaciones();
            listaCotizaciones.Show();
        }

        private void trasladoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_trasladoDeProducto trasladoDeProducto = null;
            listas(2, trasladoDeProducto);
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(1);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(2);
        }

        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(3);
        }

        private void impuestosSobreProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(4);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(5);
        }

        private void acreedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(6);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(7);
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(8);
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(9);
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(10);
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(11);
        }

        private void tiposDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(13);
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(14);
        }
        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void MDI_SCM1_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuario = Lbl_usuario.Text;
        }
    }
}
