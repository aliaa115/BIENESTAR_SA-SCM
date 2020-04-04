using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSCM
{
    public partial class MDI_SCM : Form
    {
        public MDI_SCM()
        {
            InitializeComponent();
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

        private void MantenimientoEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoBase mantenimiento = new MantenimientoBase("usuario");
            mantenimiento.Show();
        }

        private void CotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListaDeCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listaCotizaciones listaCotizaciones = new Frm_listaCotizaciones();
            listaCotizaciones.Show();
        }
    }
}
