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

        //objeto utilizado para mostrar los mensajes del sistema
        Mensaje mensaje;

        //Objeto utilizado para que al cerrar el form actual se muestre de nuevo el form de lsta
        Form form;

        //Variables Globales
        int modo;   //modo de uso del form: [1 = nuevo ; 2 = ver ; 3 = editar]
        int cambioDet;  //identifica cuando se realizo un cambio en el area de detalle a la hora de intrar en modo 1 o 3
        int cambioEnc;  //identifica cuando se realizo un cambio en el area de encabezado a la hora de intrar en modo 1 o 3
        int idEncabezado; //almacena el id del movimiento en el que se esta trabajando
        string idProd = ""; //almacena el producto para su manejo en el edetalle

        int entregado;

        int codigoSig;
        string idCot;
        string idProv;

        public Frm_OrdenCompra(Form form, int modo, int encabezado)
        {
            InitializeComponent();

            //inicializacion de variables globales y campos segun el modo del form: 
            Text = "1003 - " + Text;        //Se le agrega el codigo de la aplicacion al form
            //se define el formato del dateTimePicker
            DateTimePicker Dtp = new DateTimePicker();
            Dtp.Format = DateTimePickerFormat.Custom;
            Dtp.CustomFormat = "dd MM yyyy";
            Dtp_entrega = Dtp;
            Dtp_emision = Dtp;

            //se inicializa la variable para el form de lista
            this.form = form;
            //se inicializa la variable global del modo del form
            this.modo = modo;
            //Se inicializa el numero de encabezado para modos 2 y 3
            codigoSig = encabezado;
            //se indica que no se ha realizado ningun cambio de informacion
            cambioDet = 0;
            //se establece el tipo de ingreso de codigo como codigo automatico 
            Chk_codigo.Checked = true;

            idEncabezado = encabezado;

            Chk_codigo.Checked = true;

            Chk_estado.Checked = true;

            Txt_precioTotal.Text = "0";

            switch (modo)
            {
                //nueva ordent de compra
                case 1:
                    tipoCodigo();

                    llenarCombos();

                    entregado = 0;

                    cambioEnc = 0;
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
                    Cbo_proveedor.Enabled = false;
                    Dgv_ordenCompraDetalle.Enabled = false;
                    Grp_BuscarProv.Visible = false;
                    Grp_BuscarProv.Enabled = false;
                    Dtp_emision.Enabled = false;
                    Dtp_entrega.Enabled = false;

                    llenarEncabezado();
                    break;

                //editar una orden de compra
                case 3:
                    Chk_codigo.Enabled = false;
                    Chk_codigo.Visible = false;

                    llenarCombos();

                    Grp_BuscarProv.Visible = false;
                    Grp_BuscarProv.Enabled = false;
                    Cbo_proveedor.Visible = false;
                    Cbo_proveedor.Enabled = false;
                    Dtp_emision.Enabled = false;
                    Dtp_entrega.Enabled = false;

                    llenarEncabezado();
                    cambioEnc = 0;
                    entregado = 0;
                    break;

            }

        }

        private void llenarEncabezado()
        {
            string[] datos;
            datos = ordenesDeCompras.ordenCompraEncab(idEncabezado);

            Txt_codigo.Text = datos[0];
            Txt_nombre.Text = datos[1];
            Txt_descripcion.Text = datos[2];
            Txt_proveedor.Text = datos[3];
            //Txt_cotizacion.Text = datos[4];
            Dtp_entrega.Value = DateTime.Parse(datos[5]);
            Dtp_emision.Value = DateTime.Parse(datos[6]);
            
            if (datos[7] == "1")
            {
                Chk_entregado.Checked = true;
                entregado = 0;
            }
            else
            {
                Chk_entregado.Checked = false;
                entregado = 1;
            }

            if (datos[8] == "1")
            {
                Chk_estado.Checked = true;
            }
            else
            {
                Chk_estado.Checked = false;
            }

            ordenesDeCompras.llenarDGV(Dgv_ordenCompraDetalle, idEncabezado, int.Parse(datos[7]));

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

        private void llenarCombos()
        {
            Cbo_proveedor.llenarse("proveedores", "id_proveedor", "nombre_proveedor");
            Cbo_producto.llenarse("productos", "id_producto", "nombre_producto");
            //Cbo_cotizacion.llenarse("cotizaciones_encabezado", "id_cotizacion_encabezado", "nombre_cotizacion");
        }

        private void Frm_OrdenCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form.Show();
        }

        private void Chk_codigo_CheckedChanged(object sender, EventArgs e)
        {
            tipoCodigo();

            cambioEnc = 1;

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            switch (modo)
            {
                case 1:

                    if (guardarEncabezado())
                    {
                        int fila = 0;
                        while (fila < Dgv_ordenCompraDetalle.RowCount)
                        {
                            insertarDetalle(fila);
                            fila++;
                        }
                    mensaje = new Mensaje("La orden de compra se guardo con exito");
                    mensaje.Show();
                    //this.Close();
                    }

                    break;
                //editar una orden de compra
                case 3:

                    if (cambioEnc != 0)
                    {
                        guardarEncabezado();
                    }
                    if (cambioDet != 0)
                    {
                        alterarDetalle(null, 2);
                    }
                    mensaje = new Mensaje("La orden de compra se guardo con exito");
                    mensaje.Show();
                    //this.Close();

                    break;
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Txt_proveedor.Text == "")
            {
                mensaje = new Mensaje("Para agregar un producto se debe ingresar una cotizacion y un proveedor antes.");
                mensaje.Show();
            }
            else
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


                //idCot = obtenerCodigoDeCombo(Txt_cotizacion.Text);
                //Nud_cantidad.Maximum = ordenesDeCompras.existenciasPosibles(int.Parse(idProd), int.Parse(idCot));
            }
        }

        private void Btn_proveedor_Click(object sender, EventArgs e)
        {
            string prov = Cbo_proveedor.ObtenerIndif();
            Txt_proveedor.Text = prov;
            idProv = obtenerCodigoDeCombo(prov);
        }

        private string obtenerCodigoDeCombo(string dato)
        {
            string codigo = "";

            int i = 0;
            while (dato[i] != '-')
            {
                codigo = codigo + dato[i];
                i++;
            }

            return codigo;
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
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
                cambioDet = 1;

                string[] prod = ordenesDeCompras.obtenerProducto(int.Parse(idProd));

                alterarDetalle(prod, 1);
            }
        }


        private void alterarDetalle(string[] prod, int tipo)
        {
            switch (modo)
            {
                case 1:
                    switch (tipo)
                    {
                        case 1:
                            agregarProductoADGV(prod);
                            break;

                        case 2:
                            insertarDetalle();
                            break;
                    }
                    break;
                case 3:
                    switch (tipo)
                    {
                        case 1:

                            agregarProductoADGV(prod);

                            ordenesDeCompras.eliminarOrdenDetalle(int.Parse(Txt_codigo.Text));

                            insertarDetalle();

                            break;

                        case 2:
                            ordenesDeCompras.eliminarOrdenDetalle(int.Parse(Txt_codigo.Text));

                            insertarDetalle();

                            break;
                    }
                    break;
            }

        }

        private void insertarDetalle()
        {
            int fila = 0;

            while (fila < Dgv_ordenCompraDetalle.RowCount)
            {

                insertarDetalle(fila);
                fila++;
            }
        }
        private void insertarDetalle(int fila)
        {


            string[] detalle =
            {
                Dgv_ordenCompraDetalle.Rows[fila].Cells[0].Value.ToString(),
                Txt_codigo.Text,
                "",//obtenerCodigoDeCombo(Txt_cotizacion.Text),
                obtenerCodigoDeCombo(Txt_proveedor.Text),
                Dgv_ordenCompraDetalle.Rows[fila].Cells[1].Value.ToString(),
                Dgv_ordenCompraDetalle.Rows[fila].Cells[3].Value.ToString(),
                Dgv_ordenCompraDetalle.Rows[fila].Cells[4].Value.ToString()
            };
            
            if (Chk_entregado.Checked && entregado != 1)
            {
                int producto = int.Parse(Dgv_ordenCompraDetalle.Rows[fila].Cells[1].Value.ToString());
                int cant = int.Parse(Dgv_ordenCompraDetalle.Rows[fila].Cells[3].Value.ToString());

                string signo = " + " + cant;

                if (Dgv_ordenCompraDetalle.Rows[fila].Cells[5].Value.ToString() == "1")
                {
                    ordenesDeCompras.entregaProducto(producto, signo);
                    Dgv_ordenCompraDetalle.Rows[fila].Cells[5].Value = 0;
                }
            }

            ordenesDeCompras.insertarOrdenDetalle(detalle);

        }

        private void Cbo_proveedor_Load(object sender, EventArgs e)
        {

        }

        private void Pnl_datos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Dtp_entrega_ValueChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Dtp_emision_ValueChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Chk_estado_CheckedChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Grp_BuscarProv_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_ordenCompraDetalle.RowCount > 0)
            {
                string[] cambioExistencias = eliminarDetalle();

                cambioDet = 1;

                if (Chk_entregado.Checked && entregado != 1)
                {
                    ordenesDeCompras.entregaProducto(int.Parse(cambioExistencias[1]), cambioExistencias[0]);
                }


                ordenesDeCompras.eliminarOrdenDetalle(
                    int.Parse(Txt_codigo.Text),
                    int.Parse(Dgv_ordenCompraDetalle.Rows[Dgv_ordenCompraDetalle.CurrentRow.Index].Cells[0].Value.ToString()));

                Txt_precioTotal.Text =
                           (double.Parse(Txt_precioTotal.Text) -
                           double.Parse(Dgv_ordenCompraDetalle.Rows[Dgv_ordenCompraDetalle.CurrentRow.Index].Cells[4].Value.ToString())).ToString();

                Dgv_ordenCompraDetalle.Rows.RemoveAt(Dgv_ordenCompraDetalle.CurrentRow.Index);


            }
        }

        private string[] eliminarDetalle()
        {
            int cant = int.Parse(Dgv_ordenCompraDetalle.CurrentRow.Cells[3].Value.ToString());
            string cantidad = "- " + cant;


            string productoID = Dgv_ordenCompraDetalle.CurrentRow.Cells[1].Value.ToString();

            string[] ret = { cantidad, productoID };

            return ret;
        }

        private void agregarProductoADGV(string[] prod)
        {
            int fila = Dgv_ordenCompraDetalle.RowCount;

            Dgv_ordenCompraDetalle.Rows.Add();
            if (fila == 0)
            {
                Dgv_ordenCompraDetalle.Rows[fila].Cells[0].Value = fila;
            }
            else
            {
                Dgv_ordenCompraDetalle.Rows[fila].Cells[0].Value = int.Parse(Dgv_ordenCompraDetalle.Rows[fila-1].Cells[0].Value.ToString())+1;
            }
            Dgv_ordenCompraDetalle.Rows[fila].Cells[1].Value = prod[0];
            Dgv_ordenCompraDetalle.Rows[fila].Cells[2].Value = prod[1];
            Dgv_ordenCompraDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
            Dgv_ordenCompraDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
            Dgv_ordenCompraDetalle.Rows[fila].Cells[5].Value = "1";

            Txt_precioTotal.Text =
                (double.Parse(Txt_precioTotal.Text) +
                double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2])).ToString();

        }

        private bool guardarEncabezado()
        {
            string estado, entregado;
            if (Chk_estado.Checked) { estado = "1"; } else { estado = "0"; }
            if (Chk_entregado.Checked) { entregado = "1"; } else { entregado = "0"; }

            if (Txt_codigo.Text == "")
            {
                mensaje = new Mensaje("No ha ingresado el codigo del Movimiento.");
                mensaje.Show();
                return false;
            }
            if(Txt_proveedor.Text == "")
            {
                mensaje = new Mensaje("Se debe elegir un proveedor y la cotizacion pertinente para continuar.");
                mensaje.Show();
                return false;
            }
            if (Dgv_ordenCompraDetalle.RowCount < 1)
            {
                mensaje = new Mensaje("Se debe ingresarr al menos un producto al detalle.");
                mensaje.Show();
                return false;
            }
            else
            {
                string[] encabezado = {
                                Txt_codigo.Text,
                                "",//obtenerCodigoDeCombo(Txt_cotizacion.Text),
                                obtenerCodigoDeCombo(Txt_proveedor.Text),
                                Txt_nombre.Text,
                                Txt_descripcion.Text,
                                Dtp_emision.Value.Date.ToString("yyyy-MM-dd"),
                                Dtp_entrega.Value.Date.ToString("yyyy-MM-dd"),
                                entregado,
                                estado
                            };
                switch (modo)
                {
                    case 1:
                        ordenesDeCompras.insertarOrdenEncabezado(encabezado);
                        break;
                    case 3:
                        ordenesDeCompras.actualizarOrdenEncabezado(encabezado);
                        break;
                }

                return true;
            }
            return false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chk_entregado_CheckedChanged(object sender, EventArgs e)
        {
            cambioEnc = 1;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"Ayudas\ayudaOrdNuev.chm");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Ayudas\ayudaOrdVer.chm");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Ayudas\ayudaOrdEdit.chm");
                    break;
            }
        }
    }
}
