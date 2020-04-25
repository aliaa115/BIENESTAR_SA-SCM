using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaControladorSCM.Objetos;
using CapaControladorSCM.Mensajes;

namespace CapaControladorSCM.Query
{
    public class SQL_TipoMovimiento
    {
        Mensaje mensaje;
        transaccion transaccion = new transaccion();
        TipoMovimiento tipoMovimiento;
        List<TipoMovimiento> tipoMovimientoList;

        //obtener datos para los combobox del tipo de movimiento
        public List<TipoMovimiento> llenarComboTipoMovimiento()
        {
            tipoMovimientoList = new List<TipoMovimiento>();

            try
            {
                string sComando = string.Format("SELECT id_tipo_movimiento, nombre_tipo_movimiento, signo " +
                    "FROM tipos_movimientos;");

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

            return null;
        }

        //obtener el tipo de movimiento para el ingreso de movimiento
        public TipoMovimiento obtenerTipoMovimiento(int id_tipo_movimiento)
        {
            tipoMovimiento = new TipoMovimiento();

            try
            {
                string sComando = string.Format("SELECT id_tipo_movimiento, nombre_tipo_movimiento, signo " +
                    "FROM tipos_movimientos " +
                    "WHERE id_tipo_movimiento = {0} ;",
                    id_tipo_movimiento);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tipoMovimiento.ID_TIPO_MOVIMIENTO = reader.GetInt32(0);
                        tipoMovimiento.NOMBRE_TIPO_MOVIMIENTO = reader.GetString(1);
                        tipoMovimiento.SIGNO = reader.GetChar(2);
                    }
                }
                return tipoMovimiento;
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

        }

        //obtener el signo del tipo de movimiento
        public string obtenerSignoTipoMovimiento(int id_tipo_movimiento) {

            string signo = "";

            try
            {
                string sComando = string.Format("SELECT signo " +
                    "FROM tipos_movimientos " +
                    "WHERE id_tipo_movimiento = {0} ;",
                    id_tipo_movimiento);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        signo = reader.GetString(0);
                    }
                }
                return signo;
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
