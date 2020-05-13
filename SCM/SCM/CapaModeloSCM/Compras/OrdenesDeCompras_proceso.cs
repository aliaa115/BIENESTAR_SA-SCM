using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Query;
using CapaControladorSCM.Objetos;
using CapaModeloSCM.Mensajes;
using System.Windows.Forms;

namespace CapaModeloSCM.Compras
{ 
    public class OrdenesDeCompras_proceso
    {
        SQL_OrdenCompraEncabezado sql_ordenCompraEncabezado = new SQL_OrdenCompraEncabezado();
        SQL_OrdenCompraDetalle sql_ordencompraDetalle = new SQL_OrdenCompraDetalle();
        SQL_Producto sql_producto = new SQL_Producto();
        SQL_TipoMovimiento sql_tipoMovimiento = new SQL_TipoMovimiento();
        SQL_CotizacionDetalle sql_cotizacionDetalle = new SQL_CotizacionDetalle();
        Producto producto = new Producto();
        OrdenCompraEncabezado ordenCompraEncabezado = new OrdenCompraEncabezado();
        CotizacionEncabezado cotizacionEncabezado = new CotizacionEncabezado();
        CotizacionDetalle cotizacionDetalle = new CotizacionDetalle();
        Mensaje mensaje;

        //Obtener datos de Orden de compra encabezado
        public string[] ordenCompraEncab(int encabezado)
        {
            ordenCompraEncabezado = sql_ordenCompraEncabezado.obtenerOrdenEncabezado(encabezado);

            string[] datos =  {
                ordenCompraEncabezado.ID_ORDEN_COMPRA_ENCABEZADO.ToString(),
                ordenCompraEncabezado.NOMBRE_ORDEN_COMPRA,
                ordenCompraEncabezado.DESCRIPCION_ORDEN_COMPRA,
                ordenCompraEncabezado.PROVEEDOR.ID_PROVEEDOR.ToString() +
                    " - " + ordenCompraEncabezado.PROVEEDOR.NOMBRE_PROVEEDOR,
                ordenCompraEncabezado.COTIZACION_ENCABEZADO.ID_COTIZACION.ToString() + 
                    " - " + ordenCompraEncabezado.COTIZACION_ENCABEZADO.NOMBRE_COTIZACION.ToString(),
                ordenCompraEncabezado.FECHA_ESTIMADA_ENTREGA.ToString(),
                ordenCompraEncabezado.FECHA_EMISION.ToString(),
                ordenCompraEncabezado.ENTREGADO.ToString(),
                ordenCompraEncabezado.ESTADO.ToString()
                };

            return datos;
        }

        //Obtener el siguiente ID para la secuencia de documentos a registrar
        public int ultimoId()
        {
            return sql_ordenCompraEncabezado.obtenerUltimoId();
        }

        //verifica la cantidad de inventario disponible para el movimineto
        public int existenciasPosibles(int producto, int cotizacionEncabezado)
        {
            return sql_cotizacionDetalle.obtenerCantidadProducto(producto, cotizacionEncabezado);
        }

        //obtener producto para detalle
        public string[] obtenerProducto(int id_producto)
        {
            sql_producto = new SQL_Producto();

            producto = sql_producto.obtenerProductoDetalle(id_producto);

            string[] datos = {
                producto.ID_PRODUCTO.ToString(),
                producto.NOMBRE_PRODUCTO,
                producto.COSTO_PRODUCTO.ToString(),
                producto.PRECIO_PRODUCTO.ToString()
            };

            return datos;
        }

        //obtener signo de tipo movimiento
        public string signoTipoMovimiento()
        {
            return "+";
        }

        //realiza la operacion pertinente segun el tipo de movimiento seleccionado
        public bool operacionMovimiento(int producto, int cantidad, int tipoMovimiento)
        {
            sql_tipoMovimiento = new SQL_TipoMovimiento();

            int[] MaximoActual = sql_producto.obtenerMaximoYActualProducto(producto);

            string signo = sql_tipoMovimiento.obtenerSignoTipoMovimiento(tipoMovimiento);

            int posible = MaximoActual[0] - MaximoActual[1];

            switch (signo)
            {
                case "+":

                    if (cantidad < posible)
                    {
                        return true;
                    }

                    return false;
                case "-":
                    if (cantidad < posible)
                    {
                        return true;
                    }


                    return false;
            }

            return false;

        }

        //elimina todas las ordenes detalle realcionados a un encabezado detalle
        public void eliminarOrdenDetalle(int encabezado)
        {
            sql_ordencompraDetalle.eliminarOrdenCompraDetalle(encabezado);
        }

        //elimina un elemento del detalle de una orden de compra
        public void eliminarOrdenDetalle(int encabezado, int detalle)
        {
            sql_ordencompraDetalle.eliminarOrdenCompraDetalle(encabezado, detalle);
        }

        //ingresa una orden de compra detalle a la base de datos
        public void insertarOrdenDetalle(string[] detalle)
        {
            sql_ordencompraDetalle.ingresarOrdenCompraDetalle(detalle);
        }

        //agrega el producto al entregarse la compra
        public void entregaProducto( int producto, string cantidad)
        {
            sql_producto.actualizarStockProducto(producto, cantidad);
        }

        public void insertarOrdenEncabezado(string[] encabezado)
        {
            sql_ordenCompraEncabezado.insertarOrdenCompraEncabezado(encabezado);
        }

        public void actualizarOrdenEncabezado(string[] encabezado)
        {
            sql_ordenCompraEncabezado.actualizarOrdenCompraEncabezado(encabezado);
        }

        public void llenarDGV(DataGridView dgv, int encabezado)
        {
            dgv.Rows.Clear();
            int fila = 0;

            foreach(OrdenCompraDetalle ordenTmp in sql_ordencompraDetalle.llenarDGVOrdenDetalle(encabezado))
            {
                dgv.Rows.Add();
                dgv.Rows[fila].Cells[0].Value = ordenTmp.ID_ORDEN_COMPRA_DETALLE.ToString();
                dgv.Rows[fila].Cells[1].Value = ordenTmp.PRODUCTO.ID_PRODUCTO.ToString();
                dgv.Rows[fila].Cells[2].Value = ordenTmp.PRODUCTO.NOMBRE_PRODUCTO.ToString();
                dgv.Rows[fila].Cells[3].Value = ordenTmp.CANTIDAD.ToString();
                dgv.Rows[fila].Cells[4].Value = ordenTmp.PRECIO_UNITARIO.ToString();
                fila++;
            }

        }
    }
}
