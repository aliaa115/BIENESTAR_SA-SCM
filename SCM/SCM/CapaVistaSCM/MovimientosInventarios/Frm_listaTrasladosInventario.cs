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
    public partial class Frm_listaTrasladosInventario : Form
    {
        public Frm_listaTrasladosInventario()
        {
            InitializeComponent();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_trasladoDeProducto trasladoDeProducto = new Frm_trasladoDeProducto();
            trasladoDeProducto.Show();
        }
    }
}
