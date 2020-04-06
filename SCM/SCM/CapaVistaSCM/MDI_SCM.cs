using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSCM.Mantenimiento;

namespace CapaVistaSCM
{
    public partial class MDI_SCM : Form
    {
        string usuario;
        public MDI_SCM(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void mant(int tabla)
        {
            Frm_manteniminto contacto = new Frm_manteniminto(usuario, tabla);
            contacto.Show();
        }

        private void ListaDeOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaOrdenesCompra listaOrdenesCompra = new Frm_listaOrdenesCompra();
            listaOrdenesCompra.Show();
        }

        private void MovimientosInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrasladoDeInventarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_listaTrasladosInventario trasladosInventario = new Frm_listaTrasladosInventario();
            trasladosInventario.Show();
        }

        private void MovimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaMovimientosInventario listaMovimientosInventario =
                new Frm_listaMovimientosInventario();
            listaMovimientosInventario.Show();
        }

        private void CotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListaDeCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaCotizaciones listaCotizaciones = new Frm_listaCotizaciones();
            listaCotizaciones.Show();
        }

        private void ContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(1);
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(2);
        }

        private void MantenimientoEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(3);
        }

        private void ImpuestoSobreProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(4);
        }

        private void CategoriasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(5);
        }
    }
}
