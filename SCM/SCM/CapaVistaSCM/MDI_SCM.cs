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
<<<<<<< HEAD
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
=======

        public MDI_SCM()
        {
            InitializeComponent();
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
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
<<<<<<< HEAD
            Frm_lista lista = null;

            switch (tabla)
            {
                case 1:
                    lista = new Frm_lista(tabla, form, usuario);
                    break;
            }
=======
            Frm_lista lista = new Frm_lista(panel1, tabla, form, usuario);
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9

            lista.MdiParent = this;
            lista.Show();
            lista.TopLevel = false;
            lista.TopMost = true;
            panel1.Controls.Add(lista);
        }

<<<<<<< HEAD
        private void listaDeOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaOrdenesCompra listaOrdenesCompra = new Frm_listaOrdenesCompra();
            listaOrdenesCompra.Show();
            listaOrdenesCompra.MdiParent = this;
        }

        private void movimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
=======
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
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(2);
        }

<<<<<<< HEAD
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
=======
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
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(6);
        }

<<<<<<< HEAD
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(7);
        }

<<<<<<< HEAD
        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(8);
        }

<<<<<<< HEAD
        private void impuestosSobreProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(4);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void lineasToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(9);
        }
        private void presentacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant(10);
        }

<<<<<<< HEAD
        private void acreedoresToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(11);
        }

<<<<<<< HEAD
        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void tiposDeMovimientosToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(13);
        }

<<<<<<< HEAD
        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(14);
        }

<<<<<<< HEAD
        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void inventarioToolStripMenuItem2_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            mant(15);
        }

<<<<<<< HEAD
        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void movimientoDeInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            Frm_MovimientosInventarios movimientosInventarios = null;
            listas(1, movimientosInventarios);
        }

<<<<<<< HEAD
        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void trasladoDeInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            Frm_trasladoDeProducto trasladoProducto = null;
            listas(2, trasladoProducto);
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
