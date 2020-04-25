using CapaControladorSCM.MovimientosInventario;
using CapaControladorSCM.Objetos;
using System.Windows.Forms;

namespace CapaModeloSCM.Movimientos
{
    public class MovimientoInventario
    {
        public string[] datosMovimiento(int encabezado)
        {
            MovimientoEncabezado movimientoEncabezado;
            SQL_MovimientoEncabezado sQL_MovimientoEncabezado = new SQL_MovimientoEncabezado();

            movimientoEncabezado = sQL_MovimientoEncabezado.obtenerMovimientoEncabezado(encabezado);

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

        public void llenarDGV( DataGridView dgv , int encabezado )
        {

            SQL_MovimientoDetalle movimientoDetalle = new SQL_MovimientoDetalle();

            dgv.Rows.Clear();
            int fila = 0;

            foreach (MovimientoDetalle movDetTmp in movimientoDetalle.llenarDGVMovimientoDetalle(encabezado))
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

        public void insertarMovimientoEncabezado(string[] encabezado)
        {
            SQL_MovimientoEncabezado movimientoEncabezado = new SQL_MovimientoEncabezado();

            movimientoEncabezado.ingresarMovimientoEncabezado(encabezado);

        }

        public void actualizarMovimientoEncabezado(string[] encabezado)
        {
            SQL_MovimientoEncabezado movimientoEncabezado = new SQL_MovimientoEncabezado();

            movimientoEncabezado.actualizarMovimientoEncabezado(encabezado);

        }

        public void insertarMovimientoDetalle(string[] detalle)
        {
            SQL_MovimientoDetalle movimientoDetalle = new SQL_MovimientoDetalle();

            movimientoDetalle.ingresarMovimientoDetalle(detalle);

        }

        public void eliminarMovimientoDetalle(int encabezado, int detalle)
        {
            SQL_MovimientoDetalle movimientoDetalle = new SQL_MovimientoDetalle();

            movimientoDetalle.eliminarMovimientoDetalle(detalle, encabezado);
        }

        public string[] obtenerProducto(int id_producto)
        {
            Producto producto;
            SQL_Producto sql_producto = new SQL_Producto();
            
            producto = sql_producto.obtenerProductoDetalle(id_producto);

            string[] datos = {
                producto.ID_PRODUCTO.ToString(),
                producto.NOMBRE_PRODUCTO,
                producto.COSTO_PRODUCTO.ToString(),
                producto.PRECIO_PRODUCTO.ToString()
            };

            return datos;
        }
    }
}
