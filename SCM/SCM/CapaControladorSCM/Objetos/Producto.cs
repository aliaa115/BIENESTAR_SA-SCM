using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSCM.Objetos
{
    public class Producto
    {
        public int ID_PRODUCTO { get; set; }
        public Impuesto IMPUESTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public double COSTO_PRODUCTO { get; set; }
        public double PRECIO_PRODUCTO { get; set; }
    }
}
