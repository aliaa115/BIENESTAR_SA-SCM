using CapaControladorSCM.Mensajes;
using CapaControladorSCM.Objetos;
using System.Data.Odbc;

namespace CapaControladorSCM.Query
{
    public class SQL_Impuesto
    {
        Mensaje mensaje;
        Producto producto;
        Impuesto impuesto;
        transaccion transaccion = new transaccion();

        public Impuesto obtenerImpuestos(int id_impuesto)
        {
            Impuesto impuesto = new Impuesto();
            try
            {
                string sComando = string.Format(
                    "SELECT tasa_impuesto " +
                    "FROM impuestos " +
                    "WHERE id_impuesto = {0};",
                    id_impuesto);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        impuesto.TASA_IMPUESTO = reader.GetDouble(0);
                    }
                }
                return impuesto;
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

