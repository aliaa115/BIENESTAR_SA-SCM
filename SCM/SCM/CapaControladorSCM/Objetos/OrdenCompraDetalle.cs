using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class OrdenCompraDetalle
    {
        public int ID_ORDEN_COMPRA_DETALLE { get; set; }
        public OrdenCompraEncabezado ORDEN_COMPRA_ENCABEZADO { get; set; }
        public Producto PRODUCTO { get; set; } 
        public int CANTIDAD { get; set; }
        public int precio_unitario { get; set; }
    }
}
