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
    public partial class Frm_MovimientosInventarios : Form
    {
        public Frm_MovimientosInventarios()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MovimientosInventarios.Frm_movimientoInventarioDetalle inventarioDetalle =
                new MovimientosInventarios.Frm_movimientoInventarioDetalle();

            inventarioDetalle.Show();
        }
    }
}
