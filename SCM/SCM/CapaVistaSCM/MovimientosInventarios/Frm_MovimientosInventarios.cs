using CapaModeloSCM.Movimientos;
using System;
using System.Windows.Forms;
using CapaModeloSCM.Mensajes;

namespace CapaVistaSCM
{
    public partial class Frm_MovimientosInventarios : Form
    {

<<<<<<< HEAD
        MovimientoInventario movimientoInventario = new MovimientoInventario();
        ComboTipoMovimiento comboTipoMovimiento = new ComboTipoMovimiento();
=======
        MovimientoInventario_proceso movimientoInventario = new MovimientoInventario_proceso();
        ComboTipoMovimiento_proceso comboTipoMovimiento = new ComboTipoMovimiento_proceso();
        Mensaje mensaje;
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        Form form;
        int modo;
        int cantidadDetalles;
        int cambioDet;
        int cambioEnc;
<<<<<<< HEAD
        public Frm_MovimientosInventarios(Form form, int modo, int encabezado)
        {
            InitializeComponent();

            Dtp_fecha.Format = DateTimePickerFormat.Custom;
            Dtp_fecha.CustomFormat = "dd MM yyyy";

=======
        int idEncabezado;
        string idProd = "";
        public Frm_MovimientosInventarios(Form form, int modo, int encabezado)
        {
            InitializeComponent();
            
            Text = "1002 - " + Text;
            Dtp_fecha.Format = DateTimePickerFormat.Custom;
            Dtp_fecha.CustomFormat = "dd MM yyyy";
            idEncabezado = movimientoInventario.obtenerUltimoIdEnc();
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
            this.form = form;
            string[] datos;
            this.modo = modo;
            cambioDet = 0;
<<<<<<< HEAD
=======
            Chk_codigo.Checked = true;
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9

            switch (modo)
            {
                case 1: // ingreso de nuevo registro
                    combo1.llenarse("productos", "id_producto", "nombre_producto");

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
                    Chk_codigo.Visible = false;
                    Chk_codigo.Enabled = false;
                    Chk_iva.Visible = false;
                    Chk_iva.Enabled = false;
                    Grp_producto.Visible = false;
                    Grp_producto.Enabled = false;
                    Pnl_datos.Enabled = false;
                    Txt_descripcion.Enabled = false;
                    Chk_estado.Enabled = false;

                    datos = movimientoInventario.datosMovimiento(encabezado);

                    Txt_codigo.Text = datos[0];
                    Cbo_tipoMovimiento.Text = datos[1];
                    Txt_nombre.Text = datos[2];
                    Txt_descripcion.Text = datos[3];
                    Dtp_fecha.Value = DateTime.Parse(datos[4]);

                    if (datos[5] == "1")
                    {
                        Chk_estado.Checked = true;
                    }
                    else
                    {
                        Chk_estado.Checked = false;
                    }

                    movimientoInventario.llenarDGV(Dgv_movimientoDetalle, encabezado);

                    break;

                case 3: // Edicion de Registro

                    Chk_codigo.Enabled = false;
                    Chk_codigo.Visible = false;
                    Chk_codigo.Enabled = false;
                    combo1.llenarse("productos", "id_producto", "nombre_producto");
<<<<<<< HEAD
                    
=======

>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
                    Cbo_tipoMovimiento.ValueMember = "ID_TIPO_MOVIMIENTO";
                    Cbo_tipoMovimiento.DisplayMember = "NOMBRE_TIPO_MOVIMIENTO";
                    Cbo_tipoMovimiento.DataSource = comboTipoMovimiento.tipoMov();

                    datos = movimientoInventario.datosMovimiento(encabezado);
<<<<<<< HEAD

                    Txt_codigo.Text = datos[0];
                    Cbo_tipoMovimiento.Text = datos[1];
                    Txt_nombre.Text = datos[2];
                    Txt_descripcion.Text = datos[3];
                    Dtp_fecha.Value = DateTime.Parse(datos[4]);

=======

                    Txt_codigo.Text = datos[0];
                    Cbo_tipoMovimiento.Text = datos[1];
                    Txt_nombre.Text = datos[2];
                    Txt_descripcion.Text = datos[3];
                    Dtp_fecha.Value = DateTime.Parse(datos[4]);

>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
                    if (datos[5] == "1")
                    {
                        Chk_estado.Checked = true;
                    }
                    else
                    {
                        Chk_estado.Checked = false;
                    }
<<<<<<< HEAD

                    movimientoInventario.llenarDGV(Dgv_movimientoDetalle, encabezado);

                    cantidadDetalles = Dgv_movimientoDetalle.RowCount;

                    break;

=======

                    movimientoInventario.llenarDGV(Dgv_movimientoDetalle, encabezado);

                    cantidadDetalles = Dgv_movimientoDetalle.RowCount;

                    break;

>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
            }

        }

        private void Frm_MovimientosInventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
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
                Txt_codigo.Text = idEncabezado + "";
                Txt_codigo.Enabled = false;
            }
        }

        private void Chk_codigo_CheckedChanged(object sender, EventArgs e)
        {
            estadoCodigo();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Txt_producto.Text = combo1.obtenerP() + " - " + combo1.obtenerU();
=======
            Txt_producto.Text = combo1.ObtenerIndif();

            string prod = combo1.ObtenerIndif();
            idProd = "";
            int i = 0;
            while (prod[i] != '-')
            {
                idProd = idProd + prod[i];
                i++;
            }

            Nud_cantidad.Maximum = movimientoInventario.existenciasPosibles(int.Parse(idProd));

>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Mensajes.Mensaje ms = null;
            switch (modo)
<<<<<<< HEAD
            {
                case 1:
                    if (Txt_producto.Text == "")
                    {
                        ms = new Mensajes.Mensaje("No se ha elegido ningun producto");
                        ms.Show();
                    }
                    else if (Nud_cantidad.Value == 0)
                    {
                        ms = new Mensajes.Mensaje("No se ha indicado una cantidad valida de producto");
                        ms.Show();
                    }
                    else
                    {
                        int ubicacion = Txt_producto.Text.IndexOf("-");
                        int largo = Txt_producto.Text.Length;
                        string id = "";

                        if (Txt_producto.Text[0] < 58 || Txt_producto.Text[0] > 47)
                        {
                            int i = 0;

                            while (i != ubicacion)
                            {
                                id += Txt_producto.Text[i];
                                i++;
                            }
                        }
                        else
                        {
                            int i = ubicacion + 1;

                            while (i != largo)
                            {
                                id += Txt_producto.Text[i];
                                i++;
                            }
                        }

                        string[] prod = movimientoInventario.obtenerProducto(int.Parse(id));

                        int fila = Dgv_movimientoDetalle.RowCount;

                        Dgv_movimientoDetalle.Rows.Add();
                        Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila + 1;
                        Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = prod[0];
                        Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod[1];
                        Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
                        Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
                        Dgv_movimientoDetalle.Rows[fila].Cells[5].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]));
                        fila++;

                    }
                    break;
                case 2:
                    break;
                case 3:
                    if (Txt_producto.Text == "")
                    {
                        ms = new Mensajes.Mensaje("No se ha elegido ningun producto");
                        ms.Show();
                    }
                    else if (Nud_cantidad.Value == 0)
                    {
                        ms = new Mensajes.Mensaje("No se ha indicado una cantidad valida de producto");
                        ms.Show();
                    }
                    else
                    {
                        cambioDet = 1;
                        int ubicacion = Txt_producto.Text.IndexOf("-");
                        int largo = Txt_producto.Text.Length;
                        string id = "";

                        if (Txt_producto.Text[0] < 58 || Txt_producto.Text[0] > 47)
                        {
                            int i = 0;

                            while (i != ubicacion)
                            {
                                id += Txt_producto.Text[i];
                                i++;
                            }
                        }
                        else
                        {
                            int i = ubicacion + 1;

                            while (i != largo)
                            {
                                id += Txt_producto.Text[i];
                                i++;
                            }
                        }

                        string[] prod = movimientoInventario.obtenerProducto(int.Parse(id));

                        int fila = Dgv_movimientoDetalle.RowCount;

                        Dgv_movimientoDetalle.Rows.Add();
                        Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila + 1;
                        Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = prod[0];
                        Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod[1];
                        Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
                        Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
                        Dgv_movimientoDetalle.Rows[fila].Cells[5].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]));
                        fila++;

                    }
                    break;
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            Mensajes.Mensaje ms = null;
            switch (modo)
            {
                case 1:
                    try
                    {
                        string estado;
                        if (Chk_estado.Checked) { estado = "1"; } else { estado = "0"; }
                        if (Txt_codigo.Text == "")
                        {
                            ms = new Mensajes.Mensaje("No ha ingresado el codigo del Movimiento.");
                            ms.Show();
                        }
                        if (Dgv_movimientoDetalle.RowCount < 1)
                        {
                            ms = new Mensajes.Mensaje("Se debe ingresarr al menos un producto al detalle.");
                            ms.Show();
                        }
                        else
                        {
                            string[] encabezado = {
                                Txt_codigo.Text,
                                Txt_codigo.Text,
                                Cbo_tipoMovimiento.SelectedValue.ToString(),
                                Txt_nombre.Text,
                                Txt_descripcion.Text,
                                Dtp_fecha.Value.Date.ToString("yyyy-MM-dd"),
                                estado
                            };
                            movimientoInventario.insertarMovimientoEncabezado(encabezado);

                            int fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {
                                string[] detalle = {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value.ToString(),
                                Txt_codigo.Text,
                                Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[4].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[5].Value.ToString()
                                };

                                movimientoInventario.insertarMovimientoDetalle(detalle);

                                fila++;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        ms = new Mensajes.Mensaje("Error al gr ul movimieeto: \n " + ex.ToString());
                        ms.Show();
                    }
                    break;
                case 2:
                    break;
                case 3:
                    if (cambioEnc != 0)
                    {
                        string estado;
                        if (Chk_estado.Checked) { estado = "1"; } else { estado = "0"; }
                        if (Txt_codigo.Text == "")
                        {
                            ms = new Mensajes.Mensaje("No ha ingresado el codigo del Movimiento.");
                            ms.Show();
                        }
                        if (Dgv_movimientoDetalle.RowCount < 1)
                        {
                            ms = new Mensajes.Mensaje("Se debe ingresarr al menos un producto al detalle.");
                            ms.Show();
                        }
                        else
                        {
                            string[] encabezado = {
                                Txt_codigo.Text,
                                Txt_codigo.Text,
                                Cbo_tipoMovimiento.SelectedValue.ToString(),
                                Txt_nombre.Text,
                                Txt_descripcion.Text,
                                Dtp_fecha.Value.Date.ToString("yyyy-MM-dd"),
                                estado
                            };
                            movimientoInventario.actualizarMovimientoEncabezado(encabezado);
                        }
                    }
                    if (cambioDet != 0)
                    {

                        int fila = 0;

                        while (fila < Dgv_movimientoDetalle.RowCount)
                        {

                            movimientoInventario.eliminarMovimientoDetalle(
                                int.Parse(Txt_codigo.Text),
                                int.Parse(Dgv_movimientoDetalle.CurrentRow.Cells[0].Value.ToString()));

                            fila++;
                        }

                        fila = 0;

                        while (fila < Dgv_movimientoDetalle.RowCount)
                        {
                            string[] detalle = {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value.ToString(),
                                Txt_codigo.Text,
                                Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[4].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[5].Value.ToString()
                                };

                            movimientoInventario.insertarMovimientoDetalle(detalle);

                            fila++;
                        }

                    }
                    break;
            }
            ms = new Mensajes.Mensaje("Movimiento Gardado con exito");
            ms.Show();
            this.Close();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            cambioDet = 1;

            movimientoInventario.eliminarMovimientoDetalle(
                int.Parse(Txt_codigo.Text), 
                int.Parse(Dgv_movimientoDetalle.CurrentRow.Cells[0].ToString()));

            Dgv_movimientoDetalle.Rows.RemoveAt(Dgv_movimientoDetalle.CurrentRow.Index);

        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
=======
            {
                case 1:
                    if (Txt_producto.Text == "")
                    {
                        ms = new Mensajes.Mensaje("No se ha elegido ningun producto");
                        ms.Show();
                    }
                    else if (Nud_cantidad.Value == 0)
                    {
                        ms = new Mensajes.Mensaje("No se ha indicado una cantidad valida de producto");
                        ms.Show();
                    }
                    else
                    {

                        string[] prod = movimientoInventario.obtenerProducto(int.Parse(idProd));

                        alterarDetalle(prod, 1);

                    }
                    break;

                case 3:
                    if (Txt_producto.Text == "")
                    {
                        ms = new Mensajes.Mensaje("No se ha elegido ningun producto");
                        ms.Show();
                    }
                    else if (Nud_cantidad.Value == 0)
                    {
                        ms = new Mensajes.Mensaje("No se ha indicado una cantidad valida de producto");
                        ms.Show();
                    }
                    else
                    {
                        cambioDet = 1;
                        Txt_producto.Text = combo1.ObtenerIndif();

                        string prod = combo1.ObtenerIndif();
                        idProd = "";
                        int i = 0;
                        while (prod[i] != '-')
                        {
                            idProd = idProd + prod[i];
                            i++;
                        }

                        string[] produ = movimientoInventario.obtenerProducto(int.Parse(idProd));

                        alterarDetalle(produ, 1);

                    }
                    break;
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            Mensajes.Mensaje ms = null;
            switch (modo)
            {
                case 1:
                    try
                    {
                        string estado;
                        if (Chk_estado.Checked) { estado = "1"; } else { estado = "0"; }
                        if (Txt_codigo.Text == "")
                        {
                            ms = new Mensajes.Mensaje("No ha ingresado el codigo del Movimiento.");
                            ms.Show();
                        }
                        if (Dgv_movimientoDetalle.RowCount < 1)
                        {
                            ms = new Mensajes.Mensaje("Se debe ingresarr al menos un producto al detalle.");
                            ms.Show();
                        }
                        else
                        {
                            string[] encabezado = {
                                Txt_codigo.Text,
                                Txt_codigo.Text,
                                Cbo_tipoMovimiento.SelectedValue.ToString(),
                                Txt_nombre.Text,
                                Txt_descripcion.Text,
                                Dtp_fecha.Value.Date.ToString("yyyy-MM-dd"),
                                estado
                            };
                            movimientoInventario.insertarMovimientoEncabezado(encabezado);

                            int fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {

                                insertarDetalle(fila);
                                fila++;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        ms = new Mensajes.Mensaje("Error al guardar el movimiento: \n " + ex.ToString());
                        ms.Show();
                    }
                    break;

                case 3:
                    if (cambioEnc != 0)
                    {
                        string estado;
                        if (Chk_estado.Checked) { estado = "1"; } else { estado = "0"; }
                        if (Txt_codigo.Text == "")
                        {
                            ms = new Mensajes.Mensaje("No ha ingresado el codigo del Movimiento.");
                            ms.Show();
                        }
                        if (Dgv_movimientoDetalle.RowCount < 1)
                        {
                            ms = new Mensajes.Mensaje("Se debe ingresarr al menos un producto al detalle.");
                            ms.Show();
                        }
                        else
                        {
                            string[] encabezado = {
                                Txt_codigo.Text,
                                Txt_codigo.Text,
                                Cbo_tipoMovimiento.SelectedValue.ToString(),
                                Txt_nombre.Text,
                                Txt_descripcion.Text,
                                Dtp_fecha.Value.Date.ToString("yyyy-MM-dd"),
                                estado
                            };
                            movimientoInventario.actualizarMovimientoEncabezado(encabezado);
                        }
                    }
                    if (cambioDet != 0)
                    {
                        alterarDetalle(null, 2);

                    }
                    break;
            }
            ms = new Mensajes.Mensaje("Movimiento Guardado con exito");
            ms.Show();
            this.Close();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            cambioDet = 1;

            movimientoInventario.eliminarMovimientoDetalle(
                int.Parse(Txt_codigo.Text),
                int.Parse(Dgv_movimientoDetalle.CurrentRow.Cells[0].Value.ToString()));

            Dgv_movimientoDetalle.Rows.RemoveAt(Dgv_movimientoDetalle.CurrentRow.Index);

        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

        private void Txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

        private void Dtp_fecha_ValueChanged(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

<<<<<<< HEAD
        private void Txt_nombre_TextChanged(object sender, EventArgs e)
=======
        private void Cbo_tipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

<<<<<<< HEAD
        private void Txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }
=======
        private void alterarDetalle(string[] prod, int tipo)
        {

            int fila;
            switch (modo)
            {
                case 1:
                    switch (tipo)
                    {
                        case 1:
                            fila = Dgv_movimientoDetalle.RowCount;

                            Dgv_movimientoDetalle.Rows.Add();
                            if (fila == 0)
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila;
                            }
                            else
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = int.Parse(Dgv_movimientoDetalle.Rows[fila - 1].Cells[0].Value.ToString()) + 1;
                            }
                            Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = prod[0];
                            Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod[1];
                            Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
                            Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
                            Dgv_movimientoDetalle.Rows[fila].Cells[5].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]));

                            break;

                        case 2:
                            fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {

                                insertarDetalle(fila);
                                fila++;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (tipo)
                    {
                        case 1:
                            fila = Dgv_movimientoDetalle.RowCount;

                            Dgv_movimientoDetalle.Rows.Add();
                            if (fila == 0)
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila;
                            }
                            else
                            {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = int.Parse(Dgv_movimientoDetalle.Rows[fila - 1].Cells[0].Value.ToString()) + 1;
                            }
                            Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = prod[0];
                            Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod[1];
                            Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Nud_cantidad.Value.ToString();
                            Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[2]));
                            Dgv_movimientoDetalle.Rows[fila].Cells[5].Value = (double.Parse(Nud_cantidad.Value.ToString()) * double.Parse(prod[3]));

                            movimientoInventario.eliminarMovimientoDetalle(int.Parse(Txt_codigo.Text));

                            fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {
                                insertarDetalle(fila);
                                fila++;
                            }
                            break;

                        case 2:
                            movimientoInventario.eliminarMovimientoDetalle(int.Parse(Txt_codigo.Text));

                            fila = 0;

                            while (fila < Dgv_movimientoDetalle.RowCount)
                            {
                                insertarDetalle(fila);
                                fila++;
                            }
                            break;
                    }
                    break;
>>>>>>> ab521d974243ea3175fc300f88df0bb26c49e6c9

        private void Dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }
        }

        private void Cbo_tipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 3)
            {
                cambioEnc = 1;
            }

        }

        private void insertarDetalle(int fila)
        {
            string[] detalle = {
                                Dgv_movimientoDetalle.Rows[fila].Cells[0].Value.ToString(),
                                Txt_codigo.Text,
                                Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[4].Value.ToString(),
                                Dgv_movimientoDetalle.Rows[fila].Cells[5].Value.ToString()
                                };
            int producto = int.Parse(Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString());
            int cant = int.Parse(Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString());
            string signo = movimientoInventario.signoTipoMovimiento(int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString()));


            string cantidad = signo + " " + cant;
            if (movimientoInventario.operacionMovimiento(producto, cant, int.Parse(Cbo_tipoMovimiento.SelectedValue.ToString())))
            {
                movimientoInventario.insertarMovimientoDetalle(detalle, producto, cantidad);
            }
            else
            {
                mensaje = new Mensaje("Error al operar el moviiento del producto: [ " + producto + " ]\n Prfavor verificar las existencias");
            }

        }
    }
}
