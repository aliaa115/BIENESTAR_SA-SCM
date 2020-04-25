using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Query;
using CapaControladorSCM.Objetos;
using CapaModeloSCM.Mensajes;

namespace CapaModeloSCM.Compras
{ 
    public class OrdenesDeCompras_proceso
    {
        SQL_OrdenCompraEncabezado ordenCompraEncabezado = new SQL_OrdenCompraEncabezado();
        SQL_Producto sql_producto = new SQL_Producto();
        SQL_TipoMovimiento sql_tipoMovimiento = new SQL_TipoMovimiento();
        SQL_CotizacionDetalle sql_cotizacionDetalle = new SQL_CotizacionDetalle();
        Producto producto = new Producto();
        CotizacionEncabezado cotizacionEncabezado = new CotizacionEncabezado();
        CotizacionDetalle cotizacionDetalle = new CotizacionDetalle();
        Mensaje mensaje;

        public int ultimoId()
        {
            return ordenCompraEncabezado.obtenerUltimoId();
        }


        //verifica la cantidad de inventario disponible para el movimineto
        public int existenciasPosibles(int producto, int cotizacionEncabezado)
        {
            return sql_cotizacionDetalle.obtenerCantidadProducto(producto, cotizacionEncabezado);
        }

        //obtener producto para detalle
        public string[] obtenerProducto(int id_producto)
        {
            sql_producto = new SQL_Producto();

            producto = sql_producto.obtenerProductoDetalle(id_producto);

            string[] datos = {
                producto.ID_PRODUCTO.ToString(),
                producto.NOMBRE_PRODUCTO,
                producto.COSTO_PRODUCTO.ToString(),
                producto.PRECIO_PRODUCTO.ToString()
            };

            return datos;
        }

        //obtener signo de tipo movimiento
        public string signoTipoMovimiento()
        {
            return "+";
        }

        //realiza la operacion pertinente segun el tipo de movimiento seleccionado
        public bool operacionMovimiento(int producto, int cantidad, int tipoMovimiento)
        {
            sql_tipoMovimiento = new SQL_TipoMovimiento();

            int[] MaximoActual = sql_producto.obtenerMaximoYActualProducto(producto);

            string signo = sql_tipoMovimiento.obtenerSignoTipoMovimiento(tipoMovimiento);

            int posible = MaximoActual[0] - MaximoActual[1];

            switch (signo)
            {
                case "+":

                    if (cantidad < posible)
                    {
                        return true;
                    }

                    return false;
                case "-":
                    if (cantidad < posible)
                    {
                        return true;
                    }


                    return false;
            }

            return false;

        }

    }
}
