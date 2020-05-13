using CapaControladorSCM.Mensajes;
using CapaControladorSCM.Objetos;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorSCM.Query
{
    public class SQL_MovimientoEncabezado
    {
        Mensaje mensaje;
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
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

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
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
                return null;
            }

            return null;
        }

        //Ingreso del movimiento encabezado
        public void ingresarMovimientoEncabezado(string [] valores)
        {
            string sCommando = string.Format("INSERT INTO `erp`.`movimientos_inventario_encabezado` ( " +
                    "id_movimiento_inventario_encabezado, " +
                    "id_tipo_movimiento, " +
                    "nombre_movimiento, " +
                    "descripcion_movimiento, " +
                    "fecha_movimiento) VALUES " +
                    "    ({0}, {2}, '{3}', '{4}', '{5}'); ",
                    valores[0], valores[1], valores[2], valores[3], valores[4], valores[5]);

            try
            {
                transaccion.insertarDatos(sCommando);
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
            }

        }


        //Actualizacion del movimiento encabezado
        public void actualizarMovimientoEncabezado(string[] valores)
        {
            string sCommando = string.Format("UPDATE `erp`.`movimientos_inventario_encabezado` SET " +
                    "id_tipo_movimiento = {2}, " +
                    "nombre_movimiento = '{3}', " +
                    "descripcion_movimiento = '{4}', " +
                    "fecha_movimiento = '{5}'" +
                    "WHERE id_movimiento_inventario_encabezado = {0}; ",
                    valores[0], valores[1], valores[2], valores[3], valores[4], valores[5]);

            try
            {
                transaccion.insertarDatos(sCommando);
            }
            catch (OdbcException ex)
            {
                mensaje = new Mensaje("Error en la operacion con la Base de Datos: \n" + ex.Message);
                mensaje.Show();
            }

        }

        //obtener el ultimo id
        public int obtenerUltimoId()
        {
            int dato = 0;
                string sComando = string.Format(
                    "SELECT " +
                        "id_movimiento_inventario_encabezado " +
                    "FROM `erp`.`movimientos_inventario_encabezado` ;");
            try
            {

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

