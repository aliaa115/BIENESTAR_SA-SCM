using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class MovimientoEncabezado
    {
        public int ID_MOVIMIENTO_ENCABEZADO { get; set; }
        public Documento DOCUMENTO { get; set; }
        public TipoMovimiento TIPO_MOVIMIENTO { get; set; }
        public string NOMBRE_MOVIMIENTO { get; set; }
        public string DESCRIPCION_MOVIMIENTO { get; set; }
        public DateTime FECHA_MOVIMIENTO { get; set; }
        public Bodega BODEGA_SALIDA { get; set; }
        public Bodega BODEGA_ENTRADA { get; set; }
        public OrdenTransporte ORDEN_TRANSPORTE { get; set; }
        public int ESTADO { get; set; }
    }
}
