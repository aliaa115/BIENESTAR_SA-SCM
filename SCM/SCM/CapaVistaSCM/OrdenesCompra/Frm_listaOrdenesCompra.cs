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
    public partial class Frm_listaOrdenesCompra : Form
    {
        public Frm_listaOrdenesCompra()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_OrdenCompra ordenCompra = new Frm_OrdenCompra();
            ordenCompra.Show();
        }
    }
}
