using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Objetos;

namespace CapaControladorSCM.Objetos
{
    public class Inventario
    {
        public string NOMBRE { get; set; }
        public Producto PRODUCTO { get; set; }
        public Bodega BODEGA { get; set; }
        public string DESCRIPCION_INVENTARIO { get; set; }
        public int CANTIDAD_MAXIMA { get; set; }
        public int CANTIDAD_MINIMA { get; set; }
        public int NUMERO_ESTANTERIA { get; set; }
        public int EXISTENCIAS_INVENTARIO { get; set; }
        public int ESTADO { get; set; }
    }
}
