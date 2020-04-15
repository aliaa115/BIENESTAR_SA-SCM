using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloSCM.Mantenimientos.ListaDatos;
using CapaControladorSCM.MovimientosInventario;
using CapaControladorSCM.Objetos;

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
        public ListaData DatosLista(int tipoLista, DataGridView dgv)
        {
            ListaData data = new ListaData();
            switch (tipoLista)
            {
                case 1:
                    dataGV(tipoLista, dgv);
                    data.titulo = "MOVIMIENTOS DE INVENTARIO";
                    data.form = " de Movimientos de Inventario";
                    return data;
                case 2:
                    dataGV(tipoLista, dgv);
                    data.titulo = "TRASLADO DE INVENTARIO";
                    data.form = " de Traslado de Inventario";
                    return data;
                case 3:
                    dataGV(tipoLista, dgv);
                    data.titulo = "COMPRAS";
                    data.form = " de Compras";
                    return data;
            }
            return null;
        }

        public void dataGV(int tipoLista, DataGridView dgv)
        {

            DataGridTextBox textBox = new DataGridTextBox();
            switch (tipoLista)
            {
                case 1:
                    //CapaControladoSCM.Listas dgvLlenar = new CapaControladoSCM.Listas();
                    //string[] arreglo = dgvLlenar.obtenerDatosMovimientoInv();
                    dgv.Columns.Add("codigo", "CODIGO");
                    dgv.Columns.Add("nombre", "NOMBRE");
                    dgv.Columns.Add("tipoMovimiento", "TIPO MOVIMIENTO");
                    dgv.Columns.Add("estado", "ESTADO");
                    llenarDGV(tipoLista, dgv);
                    break;

            }
        }

        public void llenarDGV(int tipoLista, DataGridView dgv)
        {

            switch (tipoLista)
            {
                case 1:

                    SQL_MovimientoEncabezado movimientoEncabezado = new SQL_MovimientoEncabezado();

                    dgv.Rows.Clear();
                    int fila = 0;

                    foreach (MovimientoEncabezado movEncTmp in movimientoEncabezado.llenarDGVMovimientoEncabezado())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[fila].Cells[0].Value = movEncTmp.ID_MOVIMIENTO_ENCABEZADO.ToString();
                        dgv.Rows[fila].Cells[1].Value = movEncTmp.NOMBRE_MOVIMIENTO;
                        dgv.Rows[fila].Cells[2].Value = movEncTmp.TIPO_MOVIMIENTO.NOMBRE_TIPO_MOVIMIENTO;
                        dgv.Rows[fila].Cells[3].Value = movEncTmp.ESTADO.ToString();
                        fila++;
                    }

                    break;
            }

        }

    }
}
