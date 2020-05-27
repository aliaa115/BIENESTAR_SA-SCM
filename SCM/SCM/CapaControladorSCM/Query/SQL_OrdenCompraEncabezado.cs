using CapaControladorSCM.Mensajes;
using CapaControladorSCM.Objetos;
using System;
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
                        "fecha_estimada_entrega, " +
                        "fecha_emision, " +
                        "entregado, " +
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
                        ordenCompraEncabezado.FECHA_ESTIMADA_ENTREGA = reader.GetDate(4);
                        ordenCompraEncabezado.FECHA_EMISION = reader.GetDate(5);
                        ordenCompraEncabezado.ENTREGADO = reader.GetInt32(6);
                        ordenCompraEncabezado.ESTADO = reader.GetInt32(7);
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

        public void insertarOrdenCompraEncabezado(string[] valores)
        {
            string sCommando = string.Format("insert into ordenes_compras_encabezado (" +
                "id_orden_compra_encabezado, " +
                "id_proveedor, " +
                "nombre_orden_compra, " +
                "descripcion_orden_compra, " +
                "fecha_emision, " +
                "fecha_estimada_entrega, " +
                "entregado, " +
                "estado) " +
                    "values({0}, {2}, '{3}', '{4}', '{5}', '{6}', {7}, {8}); ",
                    valores[0], valores[1], valores[2], valores[3], valores[4], valores[5],
                    valores[6], valores[7], valores[8]);

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

        //actualiza el encabezado de una compra
        public void actualizarOrdenCompraEncabezado(string[] valores)
        {
            string sCommando = string.Format("UPDATE ordenes_compras_encabezado SET " +
                            "nombre_orden_compra = '{3}', " +
                            "descripcion_orden_compra = '{4}', " +
                            "fecha_emision = '{5}', " +
                            "fecha_estimada_entrega = '{6}', " +
                            "entregado = {7}, " +
                            "estado = {8} " +
                            "WHERE id_orden_compra_encabezado = {0} and id_proveedor = {2}; ",
                                valores[0], valores[1], valores[2], valores[3], valores[4], valores[5],
                                valores[6], valores[7], valores[8]);

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

    }
}
