using CapaControladorSCM.Mensajes;
using CapaControladorSCM.Objetos;
using System.Collections.Generic;
using System.Data.Odbc;

namespace CapaControladorSCM.Query
{
    public class SQL_OrdenCompraDetalle
    {
        Mensaje mensaje;
        transaccion transaccion = new transaccion();


        //obtener datos para el datagrid de detalle de movimiento
        public List<OrdenCompraDetalle> llenarDGVMovimientoDetalle(int id_orden_compra_encabezado)
        {
            SQL_Producto sql_Producto = new SQL_Producto();
            SQL_CotizacionEncabezado sql_CotizacionEncabezado = new SQL_CotizacionEncabezado();
            SQL_Proveedor sql_Proveedor = new SQL_Proveedor();
            List<OrdenCompraDetalle> ordenCompraDetalle = new List<OrdenCompraDetalle>();

            try
            {
                string sComando = string.Format("" +
                    "SELECT " +
                        "id_movimiento_inventario_detalle, " +
                        "id_cotizacion, " +
                        "id_proveedor, " +
                        "id_producto, " +
                        "cantidad, " +
                        "precio_unitario " +
                    "FROM movimientos_inventario_detalle " +
                    "WHERE id_movimiento_inventario_encabezado = {0}; ",
                    id_orden_compra_encabezado);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrdenCompraDetalle ordenCompraDetalleTmp = new OrdenCompraDetalle();
                        ordenCompraDetalleTmp.ID_ORDEN_COMPRA_DETALLE = reader.GetInt32(0);
                        ordenCompraDetalleTmp.COTIZACION_ENCABEZADO = sql_CotizacionEncabezado.obtenerCotizacionEncabezado( reader.GetInt32(2));
                        ordenCompraDetalleTmp.PROVEEDOR = sql_Proveedor.obtenerProveedor(reader.GetInt32(2));
                        ordenCompraDetalleTmp.PRODUCTO = sql_Producto.obtenerProducto(reader.GetInt32(3));
                        ordenCompraDetalleTmp.CANTIDAD = reader.GetInt32(4);
                        ordenCompraDetalleTmp.PRECIO_UNITARIO = reader.GetDouble(5);
                        ordenCompraDetalle.Add(ordenCompraDetalleTmp);
                    }
                }
                return ordenCompraDetalle;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

        }

        //Ingreso de orden de compra detalle
        public void ingresarOrdenCompraDetalle(string[] valores)
        {
            string sCommando = string.Format(
                    "INSERT INTO `erp`.`movimientos_inventario_detalle` ( " +
                        "id_movimiento_inventario_detalle, " +
                        "id_movimiento_inventario_encabezado, " +
                        "id_cotizacion, " +
                        "id_proveedor, " +
                        "id_producto, " +
                        "cantidad, " +
                        "precio_unitario) " +
                    "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}); ",
                    valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], valores[6]);

            try
            {
                transaccion.insertarDatos(sCommando);

            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
            }

        }

        //eliminar un dato de orden de compra detalle
        public void eliminarOrdenCompraDetalle(int id_orden_compra_encabezado, int id_orden_compra_detalle)
        {
            string sCommando = string.Format(
                    "DELETE FROM ordenes_compras_detalle " +
                    "WHERE id_orden_compra_detalle = {1} " +
                    "AND id_orden_compra_encabezado = {0}; ",
                    id_orden_compra_encabezado, id_orden_compra_detalle);

            try
            {
                transaccion.eliminarDatos(sCommando);

            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("ERROR: \n" + ex.Message);
                mensaje.Show();
            }
        }

        //eliminar todos los datos de una orden de compra detalle
        public void eliminarOrdenCompraDetalle(int id_orden_compra_encabezado)
        {
            string sCommando = string.Format(
                    "DELETE FROM ordenes_compras_detalle " +
                    "WHERE id_orden_compra_encabezado = {0}; ",
                    id_orden_compra_encabezado);

            try
            {
                transaccion.eliminarDatos(sCommando);

            }
            catch (OdbcException ex)
            {
                mensaje.Show();
            }
        }

    }
}
