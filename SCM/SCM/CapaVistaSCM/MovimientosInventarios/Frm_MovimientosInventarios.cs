using CapaModeloSCM.Movimientos;
using System;
using System.Windows.Forms;
using CapaModeloSCM.Mensajes;

namespace CapaVistaSCM
{
    public partial class Frm_MovimientosInventarios : Form
    {
        //Objeto para manejar procesos de movimientos de inventario
        MovimientoInventario_proceso movimientoInventario = new MovimientoInventario_proceso(); 

        //Objeto para manejar el llenado del combo de tipos de movimientos
        ComboTipoMovimiento_proceso comboTipoMovimiento = new ComboTipoMovimiento_proceso();

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

        public Frm_MovimientosInventarios(Form form, int modo, int encabezado)
        {
            InitializeComponent();
            

            //inicializacion de variables globales y campos segun el modo del form: 
            Text = "1002 - " + Text;        //Se le agrega el codigo de la aplicacion al form
                //se define el formato del dateTimePicker
            Dtp_fecha.Format = DateTimePickerFormat.Custom; 
            Dtp_fecha.CustomFormat = "dd MM yyyy";
                //se inicializa la variable para el form de lista
            this.form = form;
                //se crea un string[] pra almacenar los datos del encabezado
            string[] datos;
                //se inicializa la variable global del modo del form
            this.modo = modo;
                //se indica que no se ha realizado ningun cambio de informacion
            cambioDet = 0;
                //se establece el tipo de ingreso de codigo como codigo automatico 
            Chk_codigo.Checked = true;
                //Se establece el mostrar el impuesto como falso-
            Chk_iva.Checked = false;
                //Se inicializa el numero de encabezado para modos 2 y 3
            this.idEncabezado = encabezado;

            Txt_precioTotal.Text = "0";
            Txt_costoTotal.Text = "0";

            //Segun el modo se modo del form

            switch (modo)
            {
                case 1: // ingreso de nuevo registro
                    llenarCombos();
                    estadoCodigo();
                    //se obtiene el ultimo id de los movimientos de inventario
                    idEncabezado = movimientoInventario.obtenerUltimoIdEnc();
                    Btn_ayuda.AsignarAyuda("");
                    break;

                case 2: // Vista de Registro

                    Grp_guardar.Visible = false;
                    Grp_guardar.Enabled = false;
                    Grp_cancelar.Visible = false;
                    Grp_cancelar.Enabled = false;
                    Chk_codigo.Visible = false;
                    Chk_codigo.Enabled = false;
                    Chk_iva.Visible = false;
                    Chk_iva.Enabled = false;
                    Grp_producto.Visible = false;
                    Grp_producto.Enabled = false;
                    Pnl_datos.Enabled = false;
                    Txt_descripcion.Enabled = false;
                    Chk_estado.Enabled = false;

                    Btn_ayuda.AsignarAyuda("");
                    llenarEncabezado();
                    llenarTotales();
                    break;

                case 3: // Edicion de Registro

                    Chk_codigo.Enabled = false;
                    Chk_codigo.Visible = false;
                    Chk_codigo.Enabled = false;

                    llenarCombos();

                    Btn_ayuda.AsignarAyuda("");
                    llenarEncabezado();
                    llenarTotales();
                    cambioEnc = 0;
                    cambioDet = 0;
                    break;

            }

        }

        // accion a tomar en caso de cerrar el form
        private void Frm_MovimientosInventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
        }

        // Establece el texto en el textbox de codigo segun el tipo de codigo que se desea
        private void estadoCodigo()
        {
            if (!Chk_codigo.Checked)
            {
                Txt_codigo.Text = "";
                Txt_codigo.Enabled = true;
            }
            else
            {
                Txt_codigo.Text = idEncabezado + "";
                Txt_codigo.Enabled = false;
            }
        }

        // en caso de cambiar el checkbox del codigo 
        private void Chk_codigo_CheckedChanged(object sender, EventArgs e)
        {
            estadoCodigo();
        }

        // al dar click en el boton buscar
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            // toma el producto seleccionado en el combobox y lo coloca en el textbox de producto
            
            Txt_producto.Text = combo1.ObtenerIndif();

            string prod = combo1.ObtenerIndif();
            idProd = "";
            int i = 0;
            while (prod[i] != '-')
            {
                idProd = idProd + prod[i];
                i++;
            }

            Nud_cantidad.Maximum = movimientoInventario.existenciasPosibles(int.Parse(idProd));

        }

        // cuando se da click en el boton agregar
        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Mensajes.Mensaje ms = null;
            string prod = "";
            // se verifica que se halla legido un producto
            if (Txt_producto.Text == "")
            {
                ms = new Mensajes.Mensaje("No se ha elegido ningun producto");
                ms.Show();
            }
            // se verifica que si halla una cantidad de producto a mover
            else if (Nud_cantidad.Value == 0)
            {
                ms = new Mensajes.Mensaje("No se ha indicado una cantidad valida de producto");
                ms.Show();
            }
            // se agrea el movimiento de producto
            else
            {
                // se obtiene los datos del movimiento
                string[] produ = movimientoInventario.obtenerProducto(int.Parse(idProd));

                // se agrega el producto al movimiento
                alterarDetalle(produ, 1);
            }

        }

        // cuando se da click en el boton guardar
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            Mensajes.Mensaje ms = null;
            switch (modo)
            {

                case 1:
                    try
                    {
                        if (guardarEncabezado())
                        {
                            int fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {

                                insertarDetalle(fila);
                                fila++;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        ms = new Mensajes.Mensaje("Error al guardar el movimiento: \n " + ex.ToString());
                        ms.Show();
                    }
                    break;

                case 3:
                    if (cambioEnc != 0)
                    {
                        guardarEncabezado();
                    }
                    if (cambioDet != 0)
                    {
                        alterarDetalle(null, 2);

                    }
                    break;
            }
            ms = new Mensajes.Mensaje("Movimiento Guardado con exito");
            ms.Show();
            this.Close();
        }

        // cuando se da click en el boton eliminar
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            string[] cambioExistencias = eliminarDetalle();

            cambioDet = 1;

            movimientoInventario.eliminarMovimientoDetalle(
                int.Parse(Txt_codigo.Text),
                int.Parse(Dgv_movimientoDetalle.CurrentRow.Cells[0].Value.ToString()),
                int.Parse(cambioExistencias[1]),
                cambioExistencias[0]
                );

            Txt_precioTotal.Text =
               (double.Parse(Txt_precioTotal.Text) -
               double.Parse(Dgv_movimientoDetalle.Rows[Dgv_movimientoDetalle.CurrentRow.Index].Cells[5].Value.ToString())).ToString();

            Txt_costoTotal.Text =
                (double.Parse(Txt_costoTotal.Text) -
                double.Parse(Dgv_movimientoDetalle.Rows[Dgv_movimientoDetalle.CurrentRow.Index].Cells[4].Value.ToString())).ToString();

            Dgv_movimientoDetalle.Rows.RemoveAt(Dgv_movimientoDetalle.CurrentRow.Index);

        }

        private void cambioEncabezado()
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            cambioEncabezado();
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {
            cambioEncabezado();
        }

        private void Txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            cambioEncabezado();
        }

        private void Dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            cambioEncabezado();
        }

        private void Cbo_tipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambioEncabezado();
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

                            insertarDetalles();

                            break;
                    }
                    break;
                case 3:
                    switch (tipo)
                    {
                        case 1:

                            agregarProductoADGV(prod);

                            movimientoInventario.eliminarMovimientoDetalle(int.Parse(Txt_codigo.Text));

                            insertarDetalles();

                            break;

                        case 2:
                            movimientoInventario.eliminarMovimientoDetalle(int.Parse(Txt_codigo.Text));

                            insertarDetalles();

                            break;
                    }
                    break;

            }

        }

        private string[] eliminarDetalle()
        {
            int cant = int.Parse(Dgv_movimientoDetalle.CurrentRow.Cells[3].Value.ToString());
            string signo = movimientoInventario.signoTipoMovimiento(int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString()));
            string cantidad = "";
            if (signo == "-")
            {
                cantidad = "+ " + cant;
            }
            else
            {
                cantidad = "- " + cant;
            }

            string productoID = Dgv_movimientoDetalle.CurrentRow.Cells[1].Value.ToString();

            string[] ret = { cantidad, productoID };

            return ret;
        }

        private void insertarDetalle(int fila)
        {
            string[] detalle = {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value.ToString(),
                                Txt_codigo.Text,
                                Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[4].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[5].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[7].Value.ToString()
                                };
            int producto = int.Parse(Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString());
            int cant = int.Parse(Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString());
            string signo = movimientoInventario.signoTipoMovimiento(int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString()));


            string cantidad = signo + " " + cant;
            if (movimientoInventario.operacionMovimiento(producto, cant, int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString())))
            {
                movimientoInventario.insertarMovimientoDetalle(detalle, producto, cantidad);
                Dgv_movimientoDetalle.Rows[fila].Cells[7].Value = "1";
            }
            else
            {
                mensaje = new Mensaje("Error al operar el moviiento del producto: [ " + producto + " ]\n Prfavor verificar las existencias");
            }

        }

        private void Chk_iva_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_iva.Checked == true)
            {
                Dgv_movimientoDetalle.Columns[6].Visible = true;
            }
            else
            {
                Dgv_movimientoDetalle.Columns[6].Visible = false;
            }
        }

        private void llenarCombos()
        {
            combo1.llenarse("productos", "id_producto", "nombre_producto");

            Cbo_tipoMovimiento.ValueMember = "ID_TIPO_MOVIMIENTO";
            Cbo_tipoMovimiento.DisplayMember = "NOMBRE_TIPO_MOVIMIENTO";
            Cbo_tipoMovimiento.DataSource = comboTipoMovimiento.tipoMov();
        }

        private void llenarEncabezado()
        {
            string[] datos;
            datos = movimientoInventario.datosMovimiento(idEncabezado);

            Txt_codigo.Text = datos[0];
            Cbo_tipoMovimiento.Text = datos[1];
            Txt_nombre.Text = datos[2];
            Txt_descripcion.Text = datos[3];
            Dtp_fecha.Value = DateTime.Parse(datos[4]);

            if (datos[5] == "1")
            {
                Chk_estado.Checked = true;
            }
            else
            {
                Chk_estado.Checked = false;
            }

            movimientoInventario.llenarDGV(Dgv_movimientoDetalle, idEncabezado);
        }

        private bool guardarEncabezado()
        {
            string estado;
            if (Chk_estado.Checked) { estado = "1"; } else { estado = "0"; }
            if (Txt_codigo.Text == "")
            {
                mensaje = new Mensaje("No ha ingresado el codigo del Movimiento.");
                mensaje.Show();
            }
            if (Dgv_movimientoDetalle.RowCount < 1)
            {
                mensaje = new Mensaje("Se debe ingresarr al menos un producto al detalle.");
                mensaje.Show();
            }
            else
            {
                string[] encabezado = {
                                Txt_codigo.Text,
                                Txt_codigo.Text,
                                Cbo_tipoMovimiento.SelectedValue.ToString(),
                                Txt_nombre.Text,
                                Txt_descripcion.Text,
                                Dtp_fecha.Value.Date.ToString("yyyy-MM-dd"),
                                estado
                            };
                switch (modo)
                {
                    case 1:
                        movimientoInventario.insertarMovimientoEncabezado(encabezado);
                        break;
                    case 3:
                        movimientoInventario.actualizarMovimientoEncabezado(encabezado);
                        break;
                }

                return true;
            }
            return false;
        }

        private void agregarProductoADGV(string[] prod)
        {
            int fila = Dgv_movimientoDetalle.RowCount;

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
            mensaje = new Mensaje(prod[4]);
            Dgv_movimientoDetalle.Rows[fila].Cells[6].Value = (double.Parse(prod[4]));
            Dgv_movimientoDetalle.Rows[fila].Cells[7].Value = "0";

            Txt_costoTotal.Text =
                (double.Parse(Txt_costoTotal.Text) +
                (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]))).ToString();

            Txt_precioTotal.Text =
                (double.Parse(Txt_precioTotal.Text) +
                (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]))).ToString();

        }

        private void insertarDetalles()
        {
            int fila = 0;

            while (fila < Dgv_movimientoDetalle.RowCount)
            {

                insertarDetalle(fila);
                fila++;
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_movimientoDetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //llenarTotales();
        }

        private void Dgv_movimientoDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //llenarTotales();
        }

        private void llenarTotales()
        {
            
            if(Dgv_movimientoDetalle.RowCount > 0)
            {
                double sumaCosto = 0, sumaPrecio = 0;
                int i = 0, fila = Dgv_movimientoDetalle.RowCount;

                while (i < fila)
                {
                    sumaCosto += double.Parse(Dgv_movimientoDetalle.Rows[i].Cells[4].Value.ToString());
                    sumaPrecio += double.Parse(Dgv_movimientoDetalle.Rows[i].Cells[5].Value.ToString());
                    i++;
                }
                Txt_precioTotal.Text = "" + sumaPrecio;
                Txt_costoTotal.Text = "" + sumaCosto;
            }

        }

        private void Gpb_agregar_Enter(object sender, EventArgs e)
        {

        }
    }
}
