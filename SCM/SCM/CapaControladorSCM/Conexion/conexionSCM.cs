using System;
using System.Data.Odbc;

namespace CapaControladorSCM
{
    public class conexionSCM
    { 
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
                Console.WriteLine("No Conectó");
            }

        }
    }
}
