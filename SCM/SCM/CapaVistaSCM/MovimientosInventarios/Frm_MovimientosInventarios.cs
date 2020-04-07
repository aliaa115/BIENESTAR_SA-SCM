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
        Form form;
        public Frm_MovimientosInventarios(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_MovimientosInventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
