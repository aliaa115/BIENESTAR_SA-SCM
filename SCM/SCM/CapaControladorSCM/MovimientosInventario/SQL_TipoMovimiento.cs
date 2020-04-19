using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaControladorSCM.Objetos;

namespace CapaControladorSCM.MovimientosInventario
{
    public class SQL_TipoMovimiento
    {
        transaccion transaccion = new transaccion();

        //obtener datos para los combobox del tipo de movimiento
        public List<TipoMovimiento> llenarComboTipoMovimiento()
        {
            List<TipoMovimiento> tipoMovimientoList = new List<TipoMovimiento>();

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
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return null;
        }

        public TipoMovimiento obtenerTipoMovimiento(int id_tipo_movimiento)
        {
            TipoMovimiento tipoMovimiento = new TipoMovimiento();

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
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return null;
        }
    }
}
