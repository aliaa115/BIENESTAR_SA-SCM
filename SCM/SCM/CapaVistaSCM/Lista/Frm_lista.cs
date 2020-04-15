using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloSCM.Mantenimientos.ListaDatos;
using CapaModeloSCM.Mantenimientos;
using System;

namespace CapaVistaSCM.Lista
{
    public partial class Frm_lista : Form
    {

        Form form;
        int tabla;

        public Frm_lista(int tabla, Form form)
        {
            InitializeComponent();

            this.tabla = tabla;
            establecerDatos();
        }

        private void establecerDatos()
        {
                        
            Cls_listas datos = new Cls_listas();

            ListaData listaDatos = datos.DatosLista(tabla, Dgv_lista);
            
            Text = Text + listaDatos.form;
            Lbl_titulo.Text = listaDatos.titulo;

            Dgv_lista.Update();


        }

        private void setVentana(int tabla, int modo, int encab)
        {
            switch (tabla)
            {
                case 1:
                    this.form = new Frm_MovimientosInventarios(this, modo, encab );
                    break;
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            setVentana(tabla, 1 , 0 );
            form.Show();
            Hide();
        }

        private void Dgv_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_lista.Rows[Dgv_lista.CurrentRow.Index].Selected = true;
        }

        private void Btn_ver_Click(object sender, EventArgs e)
        {
            setVentana(tabla, 2, int.Parse(Dgv_lista.CurrentRow.Cells[0].Value.ToString()));
            form.Show();
            Hide();
        }
    }
}
