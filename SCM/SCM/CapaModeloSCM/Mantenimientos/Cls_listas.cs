using CapaControladorSCM.Query;
using CapaControladorSCM.Objetos;
using CapaModeloSCM.Mantenimientos.ListaDatos;
using System.Windows.Forms;
using CapaModeloSCM.Mensajes;

namespace CapaModeloSCM.Mantenimientos
{
    public class Cls_listas
    {
        /*
         ID DE LISTAS:
            1 = Movimientos de Inventario
            2 = Traslado de Inventario
            3 = Compras
            4 = Cotizacion
         */
        Mensaje mensaje;

        public ListaData DatosLista(int tipoLista, DataGridView dgv)
        {
            ListaData data = new ListaData();
            switch (tipoLista)
            {
                case 1:
                    dataGV(tipoLista, dgv);
                    data.titulo = "MOVIMIENTOS DE INVENTARIO";
                    data.form = " de Movimientos de Inventario";
                    return data;
                case 2:
                    dataGV(tipoLista, dgv);
                    data.titulo = "TRASLADO DE INVENTARIO";
                    data.form = " de Traslado de Inventario";
                    return data;
                case 3:
                    dataGV(tipoLista, dgv);
                    data.titulo = "COMPRAS";
                    data.form = " de Compras";
                    return data;
                case 4:
                    dataGV(tipoLista, dgv);
                    data.titulo = "COTIZACIONES";
                    data.form = " de Cotizaciones";
                    return data;
                default:
                    mensaje = new Mensaje("Error al obtener el tipo de lista que se desea deplegar.");
                    mensaje.Show();
                    return null;
            }
        }

        public void dataGV(int tipoLista, DataGridView dgv)
        {

            DataGridTextBox textBox = new DataGridTextBox();
            switch (tipoLista)
            {
                case 1:
                    //CapaControladoSCM.Listas dgvLlenar = new CapaControladoSCM.Listas();
                    //string[] arreglo = dgvLlenar.obtenerDatosMovimientoInv();
                    dgv.Columns.Add("codigo", "CODIGO");
                    dgv.Columns.Add("nombre", "NOMBRE");
                    dgv.Columns.Add("tipoMovimiento", "TIPO MOVIMIENTO");
                    dgv.Columns.Add("estado", "ESTADO");
                    llenarDGV(tipoLista, dgv);
                    break;

                case 2:
                    dgv.Columns.Add("codigo", "CODIGO");
                    dgv.Columns.Add("nombre", "NOMBRE");
                    dgv.Columns.Add("tipoMovimiento", "TIPO MOVIMIENTO");
                    dgv.Columns.Add("bodega_salida", "BODEGA SALIDA");
                    dgv.Columns.Add("estado", "ESTADO");
                    llenarDGV(tipoLista, dgv);
                    break;

                case 3:
                    dgv.Columns.Add("codigo", "CODIGO");
                    dgv.Columns.Add("nombre", "NOMBRE");
                    dgv.Columns.Add("fecha_emision", "FECHA EMISIION");
                    dgv.Columns.Add("estado", "ESTADO");
                    llenarDGV(tipoLista, dgv);
                    break;

                default:
                    mensaje = new Mensaje("Error al obtener los datos para la tabla.");
                    mensaje.Show();
                    break;

            }
        }

        public void llenarDGV(int tipoLista, DataGridView dgv)
        {
            SQL_MovimientoEncabezado movimientoEncabezado;
            SQL_OrdenCompraEncabezado ordenCompraEncabezado;
            int fila;
            switch (tipoLista)
            {
                case 1:
                    movimientoEncabezado = new SQL_MovimientoEncabezado();

                    dgv.Rows.Clear();
                    fila = 0;

                    foreach (MovimientoEncabezado movEncTmp in movimientoEncabezado.llenarDGVMovimientoEncabezado())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[fila].Cells[0].Value = movEncTmp.ID_MOVIMIENTO_ENCABEZADO.ToString();
                        dgv.Rows[fila].Cells[1].Value = movEncTmp.NOMBRE_MOVIMIENTO;
                        dgv.Rows[fila].Cells[2].Value = movEncTmp.TIPO_MOVIMIENTO.NOMBRE_TIPO_MOVIMIENTO;
                        dgv.Rows[fila].Cells[3].Value = movEncTmp.ESTADO.ToString();
                        fila++;
                    }

                    break;

                case 2:

                    movimientoEncabezado = new SQL_MovimientoEncabezado();

                    dgv.Rows.Clear();
                    fila = 0;

                    foreach (MovimientoEncabezado movEncTmp in movimientoEncabezado.llenarDGVMovimientoEncabezado())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[fila].Cells[0].Value = movEncTmp.ID_MOVIMIENTO_ENCABEZADO.ToString();
                        dgv.Rows[fila].Cells[1].Value = movEncTmp.NOMBRE_MOVIMIENTO;
                        dgv.Rows[fila].Cells[2].Value = movEncTmp.TIPO_MOVIMIENTO.NOMBRE_TIPO_MOVIMIENTO;
                        dgv.Rows[fila].Cells[3].Value = movEncTmp.BODEGA_SALIDA;
                        dgv.Rows[fila].Cells[4].Value = movEncTmp.ESTADO.ToString();
                        fila++;
                    }

                    break;

                case 3:

                    ordenCompraEncabezado = new SQL_OrdenCompraEncabezado();

                    dgv.Rows.Clear();
                    fila = 0;

                    foreach (OrdenCompraEncabezado OrdCompTmp in ordenCompraEncabezado.llenarDGVOrdenCompraEncabezado())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[fila].Cells[0].Value = OrdCompTmp.ID_ORDEN_COMPRA_ENCABEZADO.ToString();
                        dgv.Rows[fila].Cells[1].Value = OrdCompTmp.NOMBRE_ORDEN_COMPRA;
                        dgv.Rows[fila].Cells[2].Value = OrdCompTmp.FECHA_EMISION.ToString();
                        dgv.Rows[fila].Cells[3].Value = OrdCompTmp.ESTADO.ToString();
                        fila++;
                    }

                    break;
                default:
                    mensaje = new Mensaje("Error al llenar la tabla.");
                    mensaje.Show();
                    break;
            }

        }

    }
}
