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
        OrdenesDeCompras_proceso ordenesDeCompras = new OrdenesDeCompras_proceso();
        Form form;
        int modo;
        int codigoSig;
        Mensaje mensaje;
        string idProd;
        string idCot;
        string idProv;

        public Frm_OrdenCompra(Form Form, int modo, int encabezado)
        {
            InitializeComponent();
            this.form = Form;
            this.modo = modo;

            Text = "1003 - " + Text;
            codigoSig = encabezado;

            Chk_codigo.Checked = true;
                    Lbl_costo.Visible = false;
                    Lbl_precio.Visible = false;

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
                Txt_codigo.Text = codigoSig.ToString(); 
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
            Cbo_cotizacion.llenarse("cotizaciones_encabezado", "id_cotizacion_encabezado", "nombre_cotizacion");
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

                    if (Txt_cotizacion.Text != "" || Txt_Proveedor.Text != "")
                    {
                        if (Chk_estado.Checked)
                        {
                            estado = "1";
                        }
                        else
                        {
                            estado = "0";
                        }


                        string cot = Txt_cotizacion.Text;
                        idCot = "";
                        int i = 0;
                        while (cot[i] != '-')
                        {
                            idCot = idCot + cot[i];
                            i++;
                        }

                        string prov = Txt_Proveedor.Text;
                        idProv = "";
                        i = 0;
                        while (prov[i] != '-')
                        {
                            idProv = idProv + prov[i];
                            i++;
                        }
                        string[] encabezado =
                        {
                        Txt_codigo.Text,
                        idCot,
                        idProv,
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
                    }
                    else
                    {
                        mensaje = new Mensaje("Se debe elegir un proveedor y la cotizacion pertinente para continuar");
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

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Proveedor.Text == "" || Txt_cotizacion.Text == "")
            {
                mensaje = new Mensaje("Para agregar un producto se debe ingresar una cotizacion y un proveedor antes.");
                mensaje.Show();
            } else
            { 
                Txt_producto.Text = Cbo_producto.ObtenerIndif();

                string prod = Cbo_producto.ObtenerIndif();
                idProd = "";
                int i = 0;
                while (prod[i] != '-')
                {
                    idProd = idProd + prod[i];
                    i++;
                }

                string cot = Txt_cotizacion.Text;
                idCot = "";
                i = 0;
                while (cot[i] != '-')
                {
                    idCot = idCot + cot[i];
                    i++;
                }

                Nud_cantidad.Maximum = ordenesDeCompras.existenciasPosibles(int.Parse(idProd), int.Parse(idCot));
            }
        }

        private void Btn_proveedor_Click(object sender, EventArgs e)
        {
            string prov = Cbo_proveedor.ObtenerIndif();
            Txt_Proveedor.Text = prov;
            idProv = "";
            int i = 0;
            while (prov[i] != '-')
            {
                idProv = idProv + prov[i];
                i++;
            }
        }

        private void Btn_cotizacion_Click(object sender, EventArgs e)
        {
            string cot = Cbo_cotizacion.ObtenerIndif();
            Txt_cotizacion.Text = cot;
            idCot = "";
            int i = 0;
            while (cot[i] != '-')
            {
                idCot = idCot + cot[i];
                i++;
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                //ingreso de un nuevo producto a la orden de compra
                case 1:

                    if (Txt_producto.Text == "")
                    {
                        mensaje = new Mensajes.Mensaje("No se ha elegido ningun producto");
                        mensaje.Show();
                    }
                    else if (Nud_cantidad.Value == 0)
                    {
                        mensaje = new Mensajes.Mensaje("No se ha indicado una cantidad valida de producto");
                        mensaje.Show();
                    }
                    else
                    {

                        string[] prod = ordenesDeCompras.obtenerProducto(int.Parse(idProd));

                        alterarDetalle(prod, 1);

                    }
                    break;

                    break;
                case 2:
                    break;

            }
        }


        private void alterarDetalle(string[] prod, int tipo)
        {

            int fila;
            switch (modo)
            {
                case 1:
                    switch (tipo)
                    {
                        case 1:
                            fila = Dgv_movimientoDetalle.RowCount;

                            Dgv_movimientoDetalle.Rows.Add();
                            if (fila == 0)
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila;
                            }
                            else
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = int.Parse(Dgv_movimientoDetalle.Rows[fila - 1].Cells[0].Value.ToString()) + 1;
                            }
                            Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = prod[0];
                            Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod[1];
                            Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
                            Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
                            Dgv_movimientoDetalle.Rows[fila].Cells[5].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]));

                            break;

                        case 2:
                            fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {

                                insertarDetalle(fila);
                                fila++;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (tipo) 
                    {
                        case 1:
                            fila = Dgv_movimientoDetalle.RowCount;

                            Dgv_movimientoDetalle.Rows.Add();
                            if (fila == 0)
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila;
                            }
                            else
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = int.Parse(Dgv_movimientoDetalle.Rows[fila - 1].Cells[0].Value.ToString()) + 1;
                            }
                            Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = prod[0];
                            Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod[1];
                            Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
                            Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
                            Dgv_movimientoDetalle.Rows[fila].Cells[5].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]));

                            movimientoInventario.eliminarMovimientoDetalle(int.Parse(Txt_codigo.Text));

                            fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {
                                insertarDetalle(fila);
                                fila++;
                            }
                            break;

                        case 2:
                            movimientoInventario.eliminarMovimientoDetalle(int.Parse(Txt_codigo.Text));

                            fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {
                                insertarDetalle(fila);
                                fila++;
                            }
                            break;
                    }
                    break;

            }

        }

        private void insertarDetalle(int fila)
        {
            string[] detalle = {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value.ToString(),
                                Txt_codigo.Text,
                                Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[4].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[5].Value.ToString()
                                };
            int producto = int.Parse(Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString());
            int cant = int.Parse(Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString());
            string signo = movimientoInventario.signoTipoMovimiento(int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString()));


            string cantidad = signo + " " + cant;
            if (movimientoInventario.operacionMovimiento(producto, cant, int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString())))
            {
                movimientoInventario.insertarMovimientoDetalle(detalle, producto, cantidad);
            }
            else
            {
                mensaje = new Mensaje("Error al operar el moviiento del producto: [ " + producto + " ]\n Prfavor verificar las existencias");
            }

        }

    }
}
