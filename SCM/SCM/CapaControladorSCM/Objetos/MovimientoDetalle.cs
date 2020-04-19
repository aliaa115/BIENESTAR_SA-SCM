using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class MovimientoDetalle
    {
        public MovimientoEncabezado MOVIMIENTO_ENCABEZADO { get; set; }
        public int ID_MOVIMIENTO_INVENTARIO_DETALLE { get; set; }
        public Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public double COSTO { get; set; }
    }
}
