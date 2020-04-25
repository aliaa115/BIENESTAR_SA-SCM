using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloSCM.Compras;
using CapaVistaSCM.Mensajes;

namespace CapaVistaSCM
{
    public partial class Frm_OrdenCompra : Form
    {
        OrdenesDeCompras_proceso ordenesDeCompras;
        Form form;
        int modo;
        int codigoSig;
        Mensaje mensaje;

        public Frm_OrdenCompra(Form Form, int modo, int encabezado)
        {
            InitializeComponent();
            this.form = Form;
            this.modo = modo;

            Text = "1003 - " + Text;


            if (encabezado == 0)
            {
                codigoSig = encabezado;
            }
            else
            {
                codigoSig = ordenesDeCompras.ultimoId();
            }


            switch (modo)
            {
                //nueva ordent de compra
                case 1:
                    tipoCodigo();
                    iniciarCombo();
                    break;

                //ver una orden de compra
                case 2:
                    Grp_guardar.Enabled = false;
                    Grp_guardar.Visible = false;
                    Grp_cancelar.Enabled = false;
                    Grp_cancelar.Visible = false;
                    Grp_agregar.Enabled = false;
                    Grp_agregar.Visible = false;
                    Grp_producto.Enabled = false;
                    Grp_producto.Visible = false;
                    Txt_codigo.Enabled = false;
                    Txt_nombre.Enabled = false;
                    Txt_descripcion.Enabled = false;
                    Dtp_emision.Enabled = false;
                    Dtp_entrega.Enabled = false;
                    Cbo_cotizacion.Enabled = false;
                    Cbo_proveedor.Enabled = false;
                    Dgv_movimientoDetalle.Enabled = false;



                    break;

                //editar una orden de compra
                case 3:
                    break;

            }

        }

        private void tipoCodigo()
        {
            if (Chk_codigo.Checked)
            {
                Txt_codigo.Enabled = false;
                Txt_codigo.Text = ""; 
            }
            else
            {
                Txt_codigo.Enabled = true;
                Txt_codigo.Text = "";
            }
        }

        private void iniciarCombo()
        {
            Cbo_proveedor.llenarse("proveedores", "id_proveedor", "nombre_proveedor");
            Cbo_producto.llenarse("productos", "id_producto", "nombre_producto");
        }

        private void Frm_OrdenCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void Chk_codigo_CheckedChanged(object sender, EventArgs e)
        {
            tipoCodigo();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string estado;
            switch (modo)
            {
                //nueva ordent de compra
                case 1:

                    if (Chk_estado.Checked)
                    {
                        estado = "1";
                    }
                    else
                    {
                        estado = "0";
                    }

                    string[] encabezado =
                    {
                        Txt_codigo.Text,
                        Cbo_cotizacion.SelectedValue.ToString(),
                        Cbo_proveedor.obtener(),
                        Txt_nombre.Text,
                        Txt_descripcion.Text,
                        Dtp_emision.Value.Date.ToString("yyyy-MM-dd"),
                        Dtp_entrega.Value.Date.ToString("yyyy-MM-dd"),
                        estado
                    };


                    if (Dgv_movimientoDetalle.RowCount < 1)
                    {
                        mensaje = new Mensaje("Se debe incluir al menos un producto a la orden de compra");
                        mensaje.Show();
                    }

                    break;

                //ver una orden de compra
                case 2:
                    // no se habilita el boton en este modo
                    break;

                //editar una orden de compra
                case 3:

                    break;

            }
        }
    }
}
