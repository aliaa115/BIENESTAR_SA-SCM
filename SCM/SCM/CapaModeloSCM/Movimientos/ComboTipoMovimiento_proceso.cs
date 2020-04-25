using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSCM.Query;
using CapaControladorSCM.Objetos;
using System.Windows.Forms;

namespace CapaModeloSCM.Movimientos
{
    public class ComboTipoMovimiento_proceso
    {

        public List<TipoMovimiento> tipoMov()
        {
            SQL_TipoMovimiento tipoMovimiento = new SQL_TipoMovimiento();

            return tipoMovimiento.llenarComboTipoMovimiento();

        }
    }
}
