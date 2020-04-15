using CapaControladorSCM.Objetos;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorSCM.MovimientosInventario
{
    public class SQL_Producto
    {
        transaccion transaccion = new transaccion();

        public Producto obtenerProducto(int id_producto)
        {
            Producto producto = new Producto();

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
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return null;
        }
    }
}
