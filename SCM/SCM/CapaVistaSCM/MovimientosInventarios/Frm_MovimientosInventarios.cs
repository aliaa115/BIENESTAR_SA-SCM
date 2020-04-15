using CapaModeloSCM.Movimientos;
using System;
using System.Windows.Forms;

namespace CapaVistaSCM
{
    public partial class Frm_MovimientosInventarios : Form
    {
        Form form;
        public Frm_MovimientosInventarios(Form form, int modo, int encabezado)
        {
            InitializeComponent();

            this.form = form;

            switch (modo)
            {
                case 1: // ingreso de nuevo registro
                    combo1.llenarse("productos", "id_producto", "nombre_producto");

                    ComboTipoMovimiento comboTipoMovimiento = new ComboTipoMovimiento();
                    Cbo_tipoMovimiento.ValueMember = "ID_TIPO_MOVIMIENTO";
                    Cbo_tipoMovimiento.DisplayMember = "NOMBRE_TIPO_MOVIMIENTO";
                    Cbo_tipoMovimiento.DataSource = comboTipoMovimiento.tipoMov();
                    estadoCodigo();
                    break;

                case 2: // Vista de Registro

                    Grp_guardar.Visible = false;
                    Grp_guardar.Enabled = false;
                    Grp_cancelar.Visible = false;
                    Grp_cancelar.Enabled = false;
                    Grp_editar.Visible = false;
                    Grp_editar.Enabled = false;
                    Chk_codigo.Visible = false;
                    Chk_codigo.Enabled = false;
                    Chk_iva.Visible = false;
                    Chk_iva.Enabled = false;
                    Pnl_datos.Enabled = false;
                    Txt_descripcion.Enabled = false;
                    Chk_estado.Enabled = false;
                    Grp_producto.Visible = false;
                    Grp_producto.Enabled = false;

                    MovimientoInventario movimientoInventario = new MovimientoInventario();
                    string []  datos = movimientoInventario.datosMovimiento(encabezado);

                    Txt_codigo.Text = datos[0];
                    Cbo_tipoMovimiento.Text = datos[1];
                    Txt_nombre.Text = datos[2];
                    Txt_descripcion.Text = datos[3];
                    Dtp_fecha.Value = DateTime.Parse(datos[4]);

                    if(datos[5] == "1")
                    {
                        Chk_estado.Checked = true;
                    }
                    else
                    {
                        Chk_estado.Checked = false;
                    }

                    movimientoInventario.llenarDGV(Dgv_movimientoDetalle, encabezado);

                    break;

            }





        }

        private void Frm_MovimientosInventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void estadoCodigo()
        {
            if (!Chk_codigo.Checked)
            {
                Txt_codigo.Text = "";
                Txt_codigo.Enabled = true;
            }
            else
            {
                Txt_codigo.Text = "";
                Txt_codigo.Enabled = false;
            }
        }

        private void Chk_codigo_CheckedChanged(object sender, EventArgs e)
        {
            estadoCodigo();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Txt_producto.Text = combo1.obtenerP() + " " + combo1.obtenerU();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Mensajes.Mesaje ms = null;
            if(Txt_producto.Text == "")
            {
                ms = new Mensajes.Mesaje("No se ha elegido ningun producto");
                ms.Show();
            }
            if (Nud_cantidad.Value == 0)
            {
                ms = new Mensajes.Mesaje("No se ha indicado una cantidad valida de producto");
                ms.Show();
            }
            else
            {

            }
        }
    }
} 
