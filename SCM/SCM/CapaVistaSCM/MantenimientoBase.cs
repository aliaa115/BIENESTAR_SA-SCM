using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSCM
{
    public partial class MantenimientoBase : Form
    {
        string usuario = "";
        public MantenimientoBase(string user)
        {
            InitializeComponent();

            Lbl_titulo.Text = "Tipo Producto";

            usuario = user;
            string[] alias = { "Codigo", "Nombre", "Descripcion", "Estado" }; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            //Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#DA7D7D"); // Deficion de 
            //navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 
                                          // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
            //navegador1.asignarComboConTabla("tabla", "campo", 0); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id
            navegador1.asignarTabla("tipos_productos"); // tabla principal
            navegador1.asignarNombreForm("TIPOS PRODUCTOS"); // Titulo y nombre del form
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }
    }
}
