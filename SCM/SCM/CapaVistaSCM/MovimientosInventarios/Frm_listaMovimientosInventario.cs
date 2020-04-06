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
    public partial class Frm_listaMovimientosInventario : Form
    {
        public Frm_listaMovimientosInventario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_MovimientosInventarios movimientosInventarios = new Frm_MovimientosInventarios();
            movimientosInventarios.Show();
        }
    }
}
