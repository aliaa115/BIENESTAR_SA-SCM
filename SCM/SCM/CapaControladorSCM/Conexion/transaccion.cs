using System.Data.Odbc;
using System.Windows.Forms;
using CapaControladorSCM.Mensajes;

namespace CapaControladorSCM
{
    public class transaccion
    {
        Mensaje mensaje;   
        public void insertarDatos(params string[] sSentencia)
        {
            conexionSCM conexion = new conexionSCM();
            var resultado = conexion.conexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaccion = resultado.Item2;
            comando.Transaction = transaccion;

            try
            {
                foreach (string sentencia in sSentencia)
                {
                    comando.CommandText = sentencia;
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch (OdbcException ex)
            {
                transaccion.Rollback();
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
            }
            finally
            {
                conexion.desconexion();
            }
        }

        public void eliminarDatos(params string[] sSentencia)
        {
            conexionSCM conexion = new conexionSCM();
            var resultado = conexion.conexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaccion = resultado.Item2;
            comando.Transaction = transaccion;

            try
            {
                foreach (string sentencia in sSentencia)
                {
                    comando.CommandText = sentencia;
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch (OdbcException ex)
            {
                transaccion.Rollback();
                mensaje = new Mensaje("Error en la eliminacion a nivel de la Base de Datos: \n" + ex.Message);
                mensaje.Show();
            }
            finally
            {
                conexion.desconexion();
            }
        }

        public OdbcDataReader ConsultarDatos(string sParametro)
        {
            conexionSCM conexion = new conexionSCM();
            var resultado = conexion.conexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaction = resultado.Item2;
            OdbcDataReader reader;
            try
            {
                comando.Transaction = transaction;
                comando.CommandText = sParametro;
                reader = comando.ExecuteReader();
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }
            return reader;
        }
    }
}
