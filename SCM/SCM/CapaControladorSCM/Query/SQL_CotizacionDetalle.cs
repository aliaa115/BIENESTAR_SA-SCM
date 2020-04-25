using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Mensajes;

namespace CapaControladorSCM.Query
{
    public class SQL_CotizacionDetalle
    {
        transaccion transaccion = new transaccion();
        Mensaje mensaje;

        //obtener la cantidad de producto posible en la cotizacion 
        public int obtenerCantidadProducto(int id_producto, int id_cotizacion_encabezado)
        {
            int dato = 0;
            try
            {
                string sComando = string.Format(
                    "SELECT " +
                        "cantidad_cotizacion " +
                    "FROM cotizaciones_detalle " +
                    "WHERE id_cotizacion_encabezado = {0} AND id_producto = {1};",
                     id_cotizacion_encabezado, id_producto);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dato = reader.GetInt32(0);
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
    }
}
