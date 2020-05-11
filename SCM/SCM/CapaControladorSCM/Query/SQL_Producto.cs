using CapaControladorSCM.Objetos;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaControladorSCM.Mensajes;

namespace CapaControladorSCM.Query
{
    public class SQL_Producto
    {
        Mensaje mensaje;
        Producto producto;
        SQL_Impuesto sql_impuesto = new SQL_Impuesto();
        transaccion transaccion = new transaccion();

        //obtener datos para consulta de detalles de movimientos 
        public Producto obtenerProducto(int id_producto)
        {
            producto = new Producto();

            try
            {
                string sComando = string.Format("SELECT id_producto, nombre_producto " +
                    "FROM productos " +
                    "WHERE id_producto = {0} ;",
                    id_producto);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto.ID_PRODUCTO = reader.GetInt32(0);
                        producto.NOMBRE_PRODUCTO = reader.GetString(1);
                    }
                }
                return producto;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

        }

        //obtener datos para el ingreso de productos
        public Producto obtenerProductoDetalle(int id_producto)
        {
            producto = new Producto();

            try
            {
                string sComando = string.Format(
                    "SELECT id_producto, nombre_producto, costo_producto, precio_producto, id_impuesto " +
                    "FROM productos " +
                    "WHERE id_producto = {0} ;",
                    id_producto);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto.ID_PRODUCTO = reader.GetInt32(0);
                        producto.NOMBRE_PRODUCTO = reader.GetString(1);
                        producto.COSTO_PRODUCTO = reader.GetDouble(2);
                        producto.PRECIO_PRODUCTO = reader.GetDouble(3);
                        producto.IMPUESTO = sql_impuesto.obtenerImpuestos(reader.GetInt32(0));
                    }
                }
                return producto;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

        }

        //obtener el maximo para stock en producto
        public int[] obtenerMaximoYActualProducto(int id_producto)
        {
            int[] dato = {0, 0};
            try
            {
                string sComando = string.Format(
                    "SELECT cantidad_maxima_producto, stock_producto " +
                    "FROM productos " +
                    "WHERE id_producto = {0};",
                    id_producto);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dato[0] = reader.GetInt32(0);
                        dato[1] = reader.GetInt32(1);
                    }
                }
                return dato;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return dato;
            }
        }

        //actualiza el stock actual
        public void actualizarStockProducto(int producto, string valor)
        {
            string sCommando = string.Format("UPDATE `erp`.`productos` SET " +
                    "stock_producto = stock_producto {1} " +
                    "WHERE id_producto = {0}; ",
                    producto, valor);
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

    }
}
