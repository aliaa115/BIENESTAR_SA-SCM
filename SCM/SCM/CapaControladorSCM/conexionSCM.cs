using System;
using System.Data.Odbc;

namespace CapaControladorSCM
{
    public class conexionSCM
    {
        public OdbcConnection conexion(string bd)
        {
            OdbcConnection conn = new OdbcConnection("Dsn="+bd+"");// creacion de la conexion via ODBC
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        public void desconexion(OdbcConnection conn)
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
