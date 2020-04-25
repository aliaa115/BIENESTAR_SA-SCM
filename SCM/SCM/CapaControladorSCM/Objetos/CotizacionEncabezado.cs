using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class CotizacionEncabezado
    {
        public int ID_COTIZACION { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public string NOMBRE_COTIZACION { get; set; }
        public string DESCRIPCION_COTIZACION { get; set; }
        public DateTime FECHA_COTIZACION { get; set; }
        public DateTime FECHA_CADUCIDAD { get; set; }
        public int ESTADO { get; set; }
    }
}
