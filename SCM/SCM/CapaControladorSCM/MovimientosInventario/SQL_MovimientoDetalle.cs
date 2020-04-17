using CapaControladorSCM.Objetos;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorSCM.MovimientosInventario
{
    public class SQL_MovimientoDetalle
    {
        transaccion transaccion = new transaccion();

        //obtener datos para el datagrid de detalle de movimiento
        public List<MovimientoDetalle> llenarDGVMovimientoDetalle(int id_movimiento_inventario_encabezado)
        {
            SQL_Producto producto = new SQL_Producto();
            List<MovimientoDetalle> movimientoDetalleList = new List<MovimientoDetalle>();

            try
            {
                string sComando = string.Format("" +
                    "SELECT " +
                        "id_movimiento_inventario_detalle, " +
                        "id_producto, " +
                        "cantidad_movimiento, " +
                        "costo_producto, " +
                        "precio_producto " +
                    "FROM movimientos_inventario_detalle " +
                    "WHERE id_movimiento_inventario_encabezado = {0}; ",
                    id_movimiento_inventario_encabezado);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoDetalle movimientoDetalleTmp = new MovimientoDetalle();
                        movimientoDetalleTmp.ID_MOVIMIENTO_INVENTARIO_DETALLE = reader.GetInt32(0);
                        movimientoDetalleTmp.PRODUCTO = producto.obtenerProducto(reader.GetInt32(1));
                        movimientoDetalleTmp.CANTIDAD = reader.GetInt32(2);
                        movimientoDetalleTmp.COSTO = reader.GetDouble(3);
                        movimientoDetalleTmp.PRECIO = reader.GetDouble(4);
                        movimientoDetalleList.Add(movimientoDetalleTmp);
                    }
                }
                return movimientoDetalleList;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return null;
        }


        //Ingreso del movimiento detalle
        public void ingresarMovimientoDetalle(string[] valores)
        {
            string sCommando = string.Format(
                    "INSERT INTO `erp`.`movimientos_inventario_detalle` ( " +
                        "id_movimiento_inventario_detalle, " +
                        "id_movimiento_inventario_encabezado, " +
                        "id_producto, " +
                        "cantidad_movimiento, " +
                        "costo_producto, " +
                        "precio_producto) " +
                    "VALUES ({0}, {1}, {2}, '{3}', '{4}', '{5}'); ",
                    valores[0], valores[1], valores[2], valores[3], valores[4], valores[5]);

            try
            {
                transaccion.insertarDatos(sCommando);

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void eliminarMovimientoDetalle(int id_movimiento_inventario_detalle, int id_movimiento_inventario_encabezado)
        {
            string sCommando = string.Format(
                    "DELETE FROM movimientos_inventario_detalle " +
                    "WHERE id_movimiento_inventario_encabezado = {1} " +
                    "AND id_movimiento_inventario_detalle = {0}; ",
                    id_movimiento_inventario_detalle, id_movimiento_inventario_encabezado);

            try
            {
                transaccion.insertarDatos(sCommando);

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
