using System;
using System.Data.Odbc;
using CapaControladorSCM.Mensajes;

namespace CapaControladorSCM
{
    public class conexionSCM
    { 
        Mensaje mensaje;
        OdbcConnection conn;
        public Tuple<OdbcConnection, OdbcTransaction> conexion()
        {
            conn = new OdbcConnection("Dsn=ERP");// creacion de la conexion via ODBC
            OdbcTransaction transaccion = null;
            try
            {
                conn.Open();
                transaccion = conn.BeginTransaction();
            }
            catch (OdbcException)
            {
                mensaje = new Mensaje("No se ha podido conectar a la Base de datos");
                mensaje.Show();
                Console.WriteLine("No Conectó");
            }

            return Tuple.Create(conn, transaccion);
        }

        public void desconexion()
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                mensaje = new Mensaje("No se ha podido conectar a la Base de datos");
                mensaje.Show();
                Console.WriteLine("No Conectó");
            }

        }
    }
}
