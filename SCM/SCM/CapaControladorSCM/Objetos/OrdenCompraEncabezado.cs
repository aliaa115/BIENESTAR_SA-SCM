using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class OrdenCompraEncabezado
    {
        public int ID_ORDEN_COMPRA_ENCABEZADO { get; set; }
        public CotizacionEncabezado COTIZACION_ENCABEZADO { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public string NOMBRE_ORDEN_COMPRA { get; set; }
        public string DESCRIPCION_ORDEN_COMPRA { get; set; }
        public DateTime FECHA_EMISION { get; set; }
        public DateTime FECHA_ENTREGA { get; set; }
        public DateTime FECHA_ESTIMADA_ENTREGA { get; set; }
        public int ENTREGADO { get; set; }
        public int ESTADO { get; set; }
    }
}
