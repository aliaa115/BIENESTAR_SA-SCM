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
using CapaVistaSCM.Lista;

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

        private void listas(int tabla, Form form)
        {
            Frm_lista lista = null;

            switch (tabla) {
                case 1:
                    lista = new Frm_lista(tabla, form);
                    break;
            }

            lista.Show();
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
            Frm_trasladoDeProducto trasladoDeProducto = null;
            listas(1, trasladoDeProducto);
        }

        private void MovimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovimientosInventarios movimientosInventarios = null;
            listas(1, movimientosInventarios);
            // movimientosInventarios.Show();
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

        private void TiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(3);
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(5);
        }

        private void AcreedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(6);
        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(7);
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(8);
        }

        private void LineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(9);
        }

        private void PresentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(10);
        }

        private void BodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(11);
        }
    }
}
