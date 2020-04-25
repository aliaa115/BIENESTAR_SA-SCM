using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloSCM.Mensajes;

namespace CapaModeloSCM.Mantenimientos
{
    public class Cls_matenimiento
    {

        /*
         ID DE TABLAS:
            1 = contactos
            2 = proveedores
            3 = tipos_productos
            4 = impuestos
            5 = categorias
            6 = acreedores
            7 = servicios
            8 = marcas
            9 = lineas
            10= presentaciones
            11= bodegas
            12= documentos
            13= tipos_movimientos
            14= productos
            15= inventarios

        ORDEN DE LOS DATOS EN RETURN PARA datos:
            1 = alias
            2 = ayuda
            3 = tabla
            4 = form
            5 = nombre
            6 = noForaneas
            
        ORDEN DE LOS DATOS EN RETURN PARA foraneas:
            1 = tabla
            2 = campo
            3 = modo
             */

        Mensaje mensaje;
        
        public (string[], string, string, string, string, int) datos(int tabla)
        {
            switch (tabla)
            {
                case 1:
                    string[] alias1 =  { "Codigo", "Nombre", "Descripcion", "Telefono", "Direccion", "Email", "Estado" };
                    return (alias1, "1", "contactos", "de Contactos", "CONTACTO", 0);

                case 2:
                    string[] alias2 = { "Codigo", "Contacto", "Nombre", "Descripcion", "Direccion", "Pagina", "Estado" };
                    return (alias2, "1","proveedores","de Proveedores","PROVEEDOR",1);

                case 3:
                    string[] alias3 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias3, "1", "tipos_productos", "de Tipos de Productos", "TIPO DE PRODUCTO", 0);

                case 4:
                    string[] alias4 = { "Codigo", "Nombre", "Descripcion", "Tasa", "Estado" };
                    return (alias4, "1", "impuestos", "de Impuestos", "IMPUESTO", 0);

                case 5:
                    string[] alias5 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias5, "1", "categorias", "de Categorias", "CATEGORIA", 0);

                case 6:
                    string[] alias6 = { "Codigo", "Contacto", "Nombre", "Descripcion", "Direccion", "Pagina", "Estado" };
                    return (alias6, "1", "acreedores", "de Acreedores", "ACREEDOR", 1);

                case 7:
                    string[] alias7 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias7, "1", "servicios", "de Servicios", "SERVICIO", 0);

                case 8:
                    string[] alias8 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias8, "1", "marcas", "de Marcas", "MARCA", 0);

                case 9:
                    string[] alias9 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias9, "1", "lineas", "de Lineas", "LINEA", 0);

                case 10:
                    string[] alias10 = { "Codigo", "Nombre", "Descripcion", "Estado" };
                    return (alias10, "1", "presentaciones", "de Presentaciones", "PRESENTACION", 0);

                case 11:
                    string[] alias11 = { "Codigo", "Nombre", "Descripcion", "Ubicacion", "Stock Maximo", "Estado" };
                    return (alias11, "1", "bodegas", "de Bodegas", "BODEGA", 0);

                case 12:
                    string[] alias12 = { "Id", "Codigo", "Nombre", "Tipo documento", "Estado" };
                    return (alias12, "1", "documentos", "de Documentos", "DOCUMENTO", 0);

                case 13:
                    string[] alias13 = { "Id", "Cuenta", "Nombre", "Descripcion", "Signo", "Estado" };
                    return (alias13, "1", "tipos_movimientos", "de Tipos de Movimientos", "TIPO MOVIMIENTO", 1);

                case 14:
                    string[] alias14 = { "Id", "Tipo", "Impuesto", "Categoria", "Nombre", "Descripcion", "Costo", "Precio", "Cant Max", "Cant Min", "Stock", "Estado" };
                    return (alias14, "1", "productos", "de Productos", "PRODUCTO", 3);

                case 15:
                    string[] alias15 = { "Nombre", "Producto", "Bodega", "Descripcion", "Maximo", "Minimo", "Estanteria", "Existencias", "Estado" };
                    return (alias15, "1", "inventarios", "de Inventarios", "INVENTARIO", 2);

                default:
                    mensaje = new Mensaje("Error al identificar el mantenimiento a trabajar.");
                    mensaje.Show();
                    break;
            }
            return (null,null,null, null, null, 0);
        }

        public (string, string, int) foraneas(int tabla, int no)
        {
            switch (tabla)
            {
                //proveedores
                case 2:
                    switch (no)
                    {
                        case 1:
                            return ("contactos", "nombre_contacto", 1);
                        default:
                            mensaje = new Mensaje("Error al identificar el mantenimiento a trabajar.");
                            mensaje.Show();
                            break;
                    }
                    break;

                //proveedores
                case 6:
                    switch (no)
                    {
                        case 1:
                            return ("contactos", "nombre_contacto", 1);
                        default:
                            mensaje = new Mensaje("Error al identificar el mantenimiento a trabajar.");
                            mensaje.Show();
                            break;
                    }
                    break;

                //cuentas
                case 13:
                    switch (no)
                    {
                        case 1:
                            return ("cuentas", "nombre", 1);
                        default:
                            mensaje = new Mensaje("Error al identificar el mantenimiento a trabajar.");
                            mensaje.Show();
                            break;
                    }
                    break;

                //productos
                case 14:
                    switch (no)
                    {
                        case 1:
                            return ("tipos_productos", "nombre_tipo_producto", 1);

                        case 2:
                            return ("impuestos", "nombre_impuesto", 1);

                        case 3:
                            return ("categorias", "nombre_categoria", 1);
                        default:
                            mensaje = new Mensaje("Error al identificar el mantenimiento a trabajar.");
                            mensaje.Show();
                            break;
                    }
                    break;

                //inventarios
                case 15:
                    switch (no)
                    {
                        case 1:
                            return ("productos", "nombre_producto", 1);

                        case 2:
                            return ("bodegas", "nombre_bodega", 1);

                        default:
                            mensaje = new Mensaje("Error al identificar el mantenimiento a trabajar.");
                            mensaje.Show();
                            break;
                    }
                    break;

                default:
                    mensaje = new Mensaje("Error al tomar los datos relacionados al mantenimiento a trabajar.");
                    mensaje.Show();
                    break;
            }
            return ("", "", 0);
        }
        
    }
}
