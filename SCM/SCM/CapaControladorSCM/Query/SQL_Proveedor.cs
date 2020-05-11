using CapaControladorSCM.Objetos;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaControladorSCM.Mensajes;

namespace CapaControladorSCM.Query
{
    public class SQL_Proveedor
    {
        Proveedor proveedor;
        Mensaje mensaje;
        transaccion transaccion = new transaccion();

        //obtener datos para consulta de detalles de orden de compra 
        public Proveedor obtenerProveedor(int id_proveedor)
        {
            proveedor = new Proveedor();

            try
            {
                string sComando = string.Format("SELECT id_proveedor, nombre_proveedor " +
                    "FROM proveedores " +
                    "WHERE id_proveedor = {0} ;",
                    id_proveedor);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        proveedor.ID_PROVEEDOR = reader.GetInt32(0);
                        proveedor.NOMBRE_PROVEEDOR = reader.GetString(1);
                    }
                }
                return proveedor;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

        }

    }
}
