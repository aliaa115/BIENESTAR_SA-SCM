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

            MessageBox.Show(tabla + "");
            
            Cls_listas datos = new Cls_listas();

            ListaData listaDatos = datos.DatosLista(tabla);
            
            Text = Text + listaDatos.form;
            Lbl_titulo.Text = listaDatos.titulo;

            List<DataGridViewColumn> columnas = listaDatos.columns;

            try
            {
                columnas.ForEach(delegate (DataGridViewColumn col)
                {
                    Dgv_lista.Columns.Add(col);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }


        }

        private void setVentana(int tabla)
        {
            switch (tabla)
            {
                case 1:
                    this.form = new Frm_MovimientosInventarios(this);
                    break;
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            setVentana(tabla);
            form.Show();
            Hide();
        }
    }
}
