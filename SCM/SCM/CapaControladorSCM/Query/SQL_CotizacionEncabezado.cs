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
    public class SQL_CotizacionEncabezado
    {
        transaccion transaccion = new transaccion();
        Mensaje mensaje;
        CotizacionEncabezado cotizacionEncabezado = new CotizacionEncabezado();

        //obtener datos para los combobox de cotizaciones segun proveedor
        public List<TipoMovimiento> llenarComboTipoMovimiento(int id_proveedor)
        {
            List<TipoMovimiento> tipoMovimientoList = new List<TipoMovimiento>();

            try
            {
                string sComando = string.Format("SELECT id_cotizacion_encabezado, nombre_cotizacion " +
                    "FROM cotizaciones_encabezado " +
                    "WHERE id_proveedor = {0}" +
                    "AND fecha_caducidad > NOW();");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TipoMovimiento tipoMovimientottmp = new TipoMovimiento();
                        tipoMovimientottmp.ID_TIPO_MOVIMIENTO = reader.GetInt32(0);
                        tipoMovimientottmp.NOMBRE_TIPO_MOVIMIENTO = reader.GetString(1);
                        tipoMovimientottmp.SIGNO = reader.GetChar(2);
                        tipoMovimientoList.Add(tipoMovimientottmp);
                    }
                }
                return tipoMovimientoList;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }
        }

        //obtener datos para consulta de detalles de orden de compra 
        public CotizacionEncabezado obtenerCotizacionEncabezado(int id_cotizacion_encabezado, int id_proveedor)
        {
            try
            {
                string sComando = string.Format(
                    "select " +
                        "id_cotizacion_encabezado, " +
                        "id_proveedor, " +
                        "nombre_cotizacion " +
                    "from " +
                        "cotizaciones_encabezado " +
                    "where " +
                        "id_cotizacion_encabezado = {0} and " +
                        "id_proveedor = {1}; ",
                    id_cotizacion_encabezado, id_proveedor);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cotizacionEncabezado.ID_COTIZACION = reader.GetInt32(0);
                        cotizacionEncabezado.NOMBRE_COTIZACION = reader.GetString(2);
                    }
                }
                return cotizacionEncabezado;
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
