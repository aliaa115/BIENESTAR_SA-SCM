using CapaControladorSCM.Objetos;
using CapaControladorSCM.Query;
using System.Windows.Forms;
using CapaControladorSCM.Mensajes;

namespace CapaModeloSCM.Movimientos
{
    public class MovimientoInventario_proceso
    {
        SQL_MovimientoEncabezado sql_MovimientoEncabezado = new SQL_MovimientoEncabezado();
        SQL_MovimientoDetalle sql_movimientoDetalle = new SQL_MovimientoDetalle();
        SQL_Producto sql_producto = new SQL_Producto();
        SQL_Inventario sql_Inventario = new SQL_Inventario();
        SQL_TipoMovimiento sql_tipoMovimiento;
        MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
        Producto producto = new Producto();
        Mensaje mensaje;

        //devuelve los datos del movimiento por encabezado
        public string[] datosMovimiento(int encabezado)
        {
            sql_MovimientoEncabezado = new SQL_MovimientoEncabezado();

            movimientoEncabezado = sql_MovimientoEncabezado.obtenerMovimientoEncabezado(encabezado);

            string[] datos =  {
                movimientoEncabezado.ID_MOVIMIENTO_ENCABEZADO.ToString(),
                movimientoEncabezado.TIPO_MOVIMIENTO.NOMBRE_TIPO_MOVIMIENTO,
                movimientoEncabezado.NOMBRE_MOVIMIENTO,
                movimientoEncabezado.DESCRIPCION_MOVIMIENTO,
                movimientoEncabezado.FECHA_MOVIMIENTO.ToString(),
                movimientoEncabezado.ESTADO.ToString()
                };

            return datos;
        }

        //llena el data grid de movimientos de inventarios
        public void llenarDGV(DataGridView dgv, int encabezado)
        {

            sql_movimientoDetalle = new SQL_MovimientoDetalle();

            dgv.Rows.Clear();
            int fila = 0;

            foreach (MovimientoDetalle movDetTmp in sql_movimientoDetalle.llenarDGVMovimientoDetalle(encabezado))
            {
                dgv.Rows.Add();
                dgv.Rows[fila].Cells[0].Value = movDetTmp.ID_MOVIMIENTO_INVENTARIO_DETALLE.ToString();
                dgv.Rows[fila].Cells[1].Value = movDetTmp.PRODUCTO.ID_PRODUCTO.ToString();
                dgv.Rows[fila].Cells[2].Value = movDetTmp.PRODUCTO.NOMBRE_PRODUCTO;
                dgv.Rows[fila].Cells[3].Value = movDetTmp.CANTIDAD.ToString();
                dgv.Rows[fila].Cells[4].Value = (movDetTmp.COSTO * movDetTmp.CANTIDAD).ToString();
                dgv.Rows[fila].Cells[5].Value = (movDetTmp.PRECIO * movDetTmp.CANTIDAD).ToString();
                fila++;
            }
        }

        //ingresa un movimiento encabezado a la base de datos
        public void insertarMovimientoEncabezado(string[] encabezado)
        {
            sql_MovimientoEncabezado = new SQL_MovimientoEncabezado();

            sql_MovimientoEncabezado.ingresarMovimientoEncabezado(encabezado);

        }

        //actualiza un movimiento encabezado en la base de datos
        public void actualizarMovimientoEncabezado(string[] encabezado)
        {
            sql_MovimientoEncabezado = new SQL_MovimientoEncabezado();

            sql_MovimientoEncabezado.actualizarMovimientoEncabezado(encabezado);

        }

        //ingressa un movimiento detalle a la base de datos
        public void insertarMovimientoDetalle(string[] detalle, int producto, string cantidad)
        {
            sql_movimientoDetalle = new SQL_MovimientoDetalle();

            sql_movimientoDetalle.ingresarMovimientoDetalle(detalle);

            sql_producto.actualizarStockProducto(producto, cantidad);
        }

        //elimina un movimiento detalle de la base de datos
        public void eliminarMovimientoDetalle(int encabezado, int detalle)
        {
            sql_movimientoDetalle = new SQL_MovimientoDetalle();

            sql_movimientoDetalle.eliminarMovimientoDetalle(detalle, encabezado);
        }

        //elimina todos los movimientos detalle relacionados a un encabezado detalle
        public void eliminarMovimientoDetalle(int encabezado)
        {
            sql_movimientoDetalle = new SQL_MovimientoDetalle();

            sql_movimientoDetalle.eliminarMovimientoDetalle(encabezado);
        }

        //Obtiene el producto asociado al detalle
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

        //obtener el ultimo id de detalle movimiento
        public int obtenerUltimoId(int encabezado)
        {
            sql_movimientoDetalle = new SQL_MovimientoDetalle();
            return sql_movimientoDetalle.obtenerUltimoId(encabezado);
        }

        //obtener el ultimo id de encabezado movimiento
        public int obtenerUltimoIdEnc()
        {
            int id = sql_MovimientoEncabezado.obtenerUltimoId();
            return id;
        }

        //verifica la cantidad de inventario disponible para el movimineto
        public int existenciasPosibles(int producto)
        {
            int posible;
            int[] Maximo;

            Maximo = sql_producto.obtenerMaximoYActualProducto(producto);

            posible = Maximo[0] - Maximo[1];

            mensaje = new Mensaje(""+posible );
            if (posible > 0)
            {
                return posible;
            } else
            {
                mensaje = new Mensaje("Se ha alcanzado el limite del producto para agregar\n" +
                    "porfavor verificar el maximo de producto en caso de querer agregar producto");
                return 0;
            }
        }

        //obtener signo de tipo movimiento
        public string signoTipoMovimiento(int tipomovimiento)
        {
            sql_tipoMovimiento = new SQL_TipoMovimiento();

            return sql_tipoMovimiento.obtenerSignoTipoMovimiento(tipomovimiento);
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
