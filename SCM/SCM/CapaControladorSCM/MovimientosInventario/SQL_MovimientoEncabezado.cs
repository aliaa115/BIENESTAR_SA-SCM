using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorSCM.Objetos;

namespace CapaControladorSCM.MovimientosInventario
{
    public class SQL_MovimientoEncabezado
    {
        transaccion transaccion = new transaccion();

        //obtener datos para el datagrid de encabezado de movimiento
        public List<MovimientoEncabezado> llenarDGVMovimientoEncabezado()
        {
            SQL_TipoMovimiento tipoMovimiento = new SQL_TipoMovimiento();
            List<MovimientoEncabezado> movimientoEncabezadoList = new List<MovimientoEncabezado>();

            try
            {
                string sComando = string.Format("SELECT ID_MOVIMIENTO_INVENTARIO_ENCABEZADO, NOMBRE_MOVIMIENTO, ID_TIPO_MOVIMIENTO, ESTADO " +
                    "FROM movimientos_inventario_encabezado;");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoEncabezado movimientoEncabezadoTmp = new MovimientoEncabezado();
                        movimientoEncabezadoTmp.ID_MOVIMIENTO_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezadoTmp.NOMBRE_MOVIMIENTO = reader.GetString(1);
                        movimientoEncabezadoTmp.TIPO_MOVIMIENTO = tipoMovimiento.obtenerTipoMovimiento(reader.GetInt32(2));
                        movimientoEncabezadoTmp.ESTADO = reader.GetInt32(3);
                        movimientoEncabezadoList.Add(movimientoEncabezadoTmp);
                    }
                }
                return movimientoEncabezadoList;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return null;
        }

        //obtener un solo movimiento encabezado
        public MovimientoEncabezado obtenerMovimientoEncabezado(int id_movimiento_inventario_encabezado)
        {
            SQL_TipoMovimiento tipoMovimiento = new SQL_TipoMovimiento();
            MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();

            try
            {
                string sComando = string.Format("" +
                    "SELECT " + 
                        "ID_MOVIMIENTO_INVENTARIO_ENCABEZADO, " +
                        "ID_TIPO_MOVIMIENTO, " +
                        "NOMBRE_MOVIMIENTO, " +
                        "DESCRIPCION_MOVIMIENTO, " +
                        "FECHA_MOVIMIENTO, " +
                        "ESTADO " +
                    "FROM movimientos_inventario_encabezado " +
                    "WHERE ID_MOVIMIENTO_INVENTARIO_ENCABEZADO = {0}; ",
                    id_movimiento_inventario_encabezado);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movimientoEncabezado.ID_MOVIMIENTO_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezado.TIPO_MOVIMIENTO = tipoMovimiento.obtenerTipoMovimiento(reader.GetInt32(1));
                        movimientoEncabezado.NOMBRE_MOVIMIENTO = reader.GetString(2);
                        movimientoEncabezado.DESCRIPCION_MOVIMIENTO = reader.GetString(3);
                        movimientoEncabezado.FECHA_MOVIMIENTO = reader.GetDate(4);
                        movimientoEncabezado.ESTADO = reader.GetInt32(5);
                    }
                }
                return movimientoEncabezado;
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

