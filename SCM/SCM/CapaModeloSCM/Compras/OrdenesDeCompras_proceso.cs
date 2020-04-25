using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Query;
using CapaControladorSCM.Objetos;
using CapaModeloSCM.Mensajes;

namespace CapaModeloSCM.Compras
{
    public class OrdenesDeCompras_proceso
    {
        SQL_OrdenCompraEncabezado ordenCompraEncabezado;
        public int ultimoId()
        {
            return ordenCompraEncabezado.obtenerUltimoId();
        }
    }
}
