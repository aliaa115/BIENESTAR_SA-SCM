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
    public class SQL_Cotizacion
    {
        transaccion transaccion = new transaccion();
        Mensaje mensaje;

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



    }
}
