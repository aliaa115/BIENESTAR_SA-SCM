using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Objetos;
using CapaControladorSCM.Mensajes;

using System.Data.Odbc;

namespace CapaControladorSCM.Query
{
    public class SQL_Inventario
    {
        transaccion transaccion = new transaccion();
        Mensaje mensaje;

        //obtener el total de existencias de un producto
        public int obtenerTotalExistenciasPorProducto(int id_producto)
        {
            int dato = 0;
            try
            {
                string sComando = string.Format(
                    "SELECT " +
                        "SUM(existencia_inventario) " +
                    "FROM inventarios " +
                    "WHERE id_producto = {0};",
                    id_producto);
               
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

        //
    }
}
