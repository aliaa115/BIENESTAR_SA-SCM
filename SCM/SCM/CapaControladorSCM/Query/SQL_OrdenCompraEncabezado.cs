using CapaControladorSCM.Mensajes;
using CapaControladorSCM.Objetos;
using System.Collections.Generic;
using System.Data.Odbc;

namespace CapaControladorSCM.Query
{
    public class SQL_OrdenCompraEncabezado
    {
        Mensaje mensaje;
        transaccion transaccion = new transaccion();
        OrdenCompraEncabezado ordenCompraEncabezado = new OrdenCompraEncabezado();
        SQL_Proveedor sql_proveedor = new SQL_Proveedor();
        SQL_CotizacionEncabezado sql_cotizacionEncabezado = new SQL_CotizacionEncabezado();

        //obtener datos para el datagrid de encabezados de ordenes de compra
        public List<OrdenCompraEncabezado> llenarDGVOrdenCompraEncabezado()
        {
            List<OrdenCompraEncabezado> ordenCompraEncabezadoList = new List<OrdenCompraEncabezado>();

            try
            {
                string sComando = string.Format("SELECT id_orden_compra_encabezado, nombre_orden_compra, fecha_emision, ESTADO " +
                    "FROM ordenes_compras_encabezado;");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrdenCompraEncabezado movimientoEncabezadoTmp = new OrdenCompraEncabezado();
                        movimientoEncabezadoTmp.ID_ORDEN_COMPRA_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezadoTmp.NOMBRE_ORDEN_COMPRA = reader.GetString(1);
                        movimientoEncabezadoTmp.FECHA_EMISION = reader.GetDate(2);
                        movimientoEncabezadoTmp.ESTADO = reader.GetInt32(3);
                        ordenCompraEncabezadoList.Add(movimientoEncabezadoTmp);
                    }
                }
                return ordenCompraEncabezadoList;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

        }

        //obtener datos de una orden de compra
        public OrdenCompraEncabezado obtenerOrdenEncabezado(int encabezado)
        {
            try
            {
                string sComando = string.Format("" +
                    "select " +
                        "id_orden_compra_encabezado, " +
                        "nombre_orden_compra, " +
                        "descripcion_orden_compra, " +
                        "id_proveedor, " +
                        "id_cotizacion_encabezado, " +
                        "fecha_entrega, " +
                        "fecha_emision, " +
                        "ESTADO " +
                    "from " +
                        "ordenes_compras_encabezado " +
                    "where " +
                        "id_orden_compra_encabezado = {0};",
                        encabezado);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ordenCompraEncabezado.ID_ORDEN_COMPRA_ENCABEZADO = reader.GetInt32(0);
                        ordenCompraEncabezado.NOMBRE_ORDEN_COMPRA = reader.GetString(1);
                        ordenCompraEncabezado.DESCRIPCION_ORDEN_COMPRA = reader.GetString(2);
                        ordenCompraEncabezado.PROVEEDOR = sql_proveedor.obtenerProveedor(reader.GetInt32(3));
                        ordenCompraEncabezado.COTIZACION_ENCABEZADO =
                            sql_cotizacionEncabezado.obtenerCotizacionEncabezado(reader.GetInt32(3), reader.GetInt32(3));
                        ordenCompraEncabezado.FECHA_ENTREGA = reader.GetDate(4);
                        ordenCompraEncabezado.FECHA_EMISION = reader.GetDate(5);
                        ordenCompraEncabezado.ESTADO = reader.GetInt32(6);
                    }
                }
                return ordenCompraEncabezado;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }
        }

        //obtener el ultimo id
        public int obtenerUltimoId()
        {
            int dato = 0;
            try
            {
                string sComando = string.Format("" +
                    "SELECT " +
                        "id_orden_compra_encabezado " +
                    "FROM ordenes_compras_encabezado ;");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dato = reader.GetInt32(0);
                    }
                }
                return dato + 1;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return 0;
            }

        }


    }
}
