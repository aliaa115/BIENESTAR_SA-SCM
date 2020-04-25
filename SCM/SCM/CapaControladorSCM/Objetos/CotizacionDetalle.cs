using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class CotizacionDetalle
    {
        public int ID_COTIZACION_DETALLE { get; set; }
        public CotizacionEncabezado COTIZACION_ENCABEZADO { get; set; }
        public Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public float PRECIO_UNITARIO { get; set; }
    }
}
