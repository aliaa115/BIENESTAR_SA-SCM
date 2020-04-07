using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloSCM.Mantenimientos.ListaDatos;

namespace CapaModeloSCM.Mantenimientos
{
    public class Cls_listas
    {
        /*
         ID DE LISTAS:
            1 = Movimientos de Inventario
            2 = Traslado de Inventario
            3 = Compras
            4 = Cotizacion
         */
        public ListaData DatosLista(int tipoLista)
        {
            ListaData data = new ListaData();
            switch (tipoLista)
            {
                case 1:
                    List<DataGridViewColumn> dgv1 = columns(tipoLista);
                    data.columns = dgv1;
                    data.titulo = "MOVIMIENTOS DE INVENTARIO";
                    data.form = " de Movimientos de Inventario";
                    return data;
                case 2:
                    List<DataGridViewColumn> dgv2 = columns(tipoLista);
                    data.columns = dgv2;
                    data.titulo = "TRASLADO DE INVENTARIO";
                    data.form = " de Traslado de Inventario";
                    return data;
                case 3:
                    List<DataGridViewColumn> dgv3 = columns(tipoLista);
                    data.columns = dgv3;
                    data.titulo = "COMPRAS";
                    data.form = " de Compras";
                    return data;
            }
            return null;
        }

        public List<DataGridViewColumn> columns(int tipoLista)
        {
            List<DataGridViewColumn> columnas = new List<DataGridViewColumn>();

            switch (tipoLista)
            {
                case 1 | 2:
                    DataGridViewColumn codigo = new DataGridViewColumn();
                    codigo.HeaderText = "CODIGO";
                    DataGridViewColumn nombre = new DataGridViewColumn();
                    nombre.HeaderText = "NOMBRE";
                    DataGridViewColumn tipoMovimiento = new DataGridViewColumn();
                    tipoMovimiento.HeaderText = "TIPO MOVIMIENTO";
                    DataGridViewColumn estado = new DataGridViewColumn();
                    estado.HeaderText = "ESTADO";

                    columnas.Add(codigo);
                    columnas.Add(nombre);
                    columnas.Add(tipoMovimiento);
                    columnas.Add(estado);
                    return columnas;
            }

            return null;
        }

    }
}
