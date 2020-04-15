using CapaDatos;
using CapaModeloSCM.Mantenimientos;
using CapaModeloSCM.Mantenimientos.ListaDatos;
using System;
using System.Windows.Forms;

namespace CapaVistaSCM.Lista
{
    public partial class Frm_lista : Form
    {
        //sentencia sn = new sentencia();
        Form form;
        int tabla;
        string usuario;

        public Frm_lista(int tabla, Form form, string usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.tabla = tabla;
            establecerDatos();

            Grp_editar.Visible = false;
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
            switch (tabla)
            {
                case 1:
                    //sn.insertarBitacora(usuario,  "Ingreso a ventana para ingresar un nuevo registro de movimientos de invenrario",  "movimientos_inventario_encabezado");
                    break;
            }
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
            switch (tabla)
            {
                case 1:
                    //sn.insertarBitacora(usuario, "Ingreso a ventana para visualizar un registro de movimientos de invenrario", "movimientos_inventario_encabezado");
                    break;
            }
        }
    }
}
