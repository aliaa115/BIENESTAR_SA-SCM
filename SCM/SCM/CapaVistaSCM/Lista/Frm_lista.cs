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
        Panel panel;
        int tabla;
        string usuario;

        public Frm_lista(Panel panel, int tabla, Form form, string usuario)
        {
            InitializeComponent();
            this.panel = panel;
            this.usuario = usuario;
            this.tabla = tabla;
                        
        }

        private void establecerDatos()
        {

            Dgv_lista.Columns.Clear();

            Cls_listas datos = new Cls_listas();

            ListaData listaDatos = datos.DatosLista(tabla, Dgv_lista);
            switch (tabla)
            {
                case 1:
                    Text = "1002 - Lista " + listaDatos.form;
                    Lbl_titulo.Text = listaDatos.titulo;
                    break;
                case 2:
                    Text = "1002 - Lista " + listaDatos.form;
                    Lbl_titulo.Text = listaDatos.titulo;
                    break;
                case 3:
                    Text = "1003 - Lista " + listaDatos.form;
                    Lbl_titulo.Text = listaDatos.titulo;
                    break;
                case 4:
                    Text = "1003 - Lista " + listaDatos.form;
                    Lbl_titulo.Text = listaDatos.titulo;
                    break;
                default:
                    break;
            }

            Dgv_lista.Update();


        }

        private void setVentana(int tabla, int modo, int encab)
        {
            switch (tabla)
            {
                case 1:
                    this.form = new Frm_MovimientosInventarios(this, modo, encab );
                    break;
                case 2:
                    break;
                case 3:
                    this.form = new Frm_OrdenCompra(this, modo, encab);
                    break;

            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            setVentana(tabla, 1 , Dgv_lista.RowCount );
            form.Show();
            form.TopLevel = false;
            form.TopMost = true;
            panel.Controls.Add(form);
            Visible = false;
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
            if (Dgv_lista.RowCount > 0)
            {
                setVentana(tabla, 2, int.Parse(Dgv_lista.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                form.TopLevel = false;
                form.TopMost = true;
                panel.Controls.Add(form);
                Visible = false;
                switch (tabla)
                {
                    case 1:
                        //sn.insertarBitacora(usuario, "Ingreso a ventana para visualizar un registro de movimientos de invenrario", "movimientos_inventario_encabezado");
                        break;
                }
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Dgv_lista.RowCount > 0)
            {
                setVentana(tabla, 3, int.Parse(Dgv_lista.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                form.TopLevel = false;
                form.TopMost = true;
                panel.Controls.Add(form);
                Visible = false;
                switch (tabla)
                {
                    case 1:
                        //sn.insertarBitacora(usuario, "Ingreso a ventana para visualizar un registro de movimientos de invenrario", "movimientos_inventario_encabezado");
                        break;
                }
            }
        }

        private void Frm_lista_Load(object sender, EventArgs e)
        {
            establecerDatos();
        }

        private void Frm_lista_VisibleChanged(object sender, EventArgs e)
        {
            establecerDatos();
        }
    }
}
