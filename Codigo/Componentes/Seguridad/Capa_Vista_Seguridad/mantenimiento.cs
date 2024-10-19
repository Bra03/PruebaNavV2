using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class mantenimiento : Form
    {
        public mantenimiento(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "codigo", "Nombre", "descripcion", "estado", "Linea", "Marca" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("productos");
            navegador1.AsignarNombreForm("PRODUCTOS");

            navegador1.AsignarComboConTabla("lineas", "codigo_linea", "nombre_linea", 1);
            navegador1.AsignarComboConTabla("marcas", "codigo_marca", "nombre_marca", 1);

            navegador1.AsignarForaneas("lineas",  "nombre_linea", "codigo_linea", "codigo_linea");
            navegador1.AsignarForaneas("marcas", "nombre_marca", "codigo_marca", "codigo_marca");

            List<string> tablas = new List<string> { "inventario" };
            navegador1.AsignarTablas(tablas);
            List<string> componetes = new List<string> { "inventario", "existencias" };
            navegador1.AsignarTablaComponentes(componetes);

            string[] aliasinventario = { "INVCODIGO", "INVCANTIDAD", "estado" };
            navegador1.AsignarAliasExtras("inventario", aliasinventario);


            string[] aliasexistencias = { "Fk_BODCODIGO" };
            navegador1.AsignarAliasExtras("existencias", aliasexistencias);

            navegador1.AsignarComboConTabla("bodega", "Pk_BODCODIGO", "BODNOMBRE", 1);

            navegador1.AsignarOperacion("inventario", "INVCANTIDAD", "existencias", "EXISALDO", "sumar", "INVCODIGO");
            List<Tuple<string, List<string>>> tablasAsociativas = new List<Tuple<string, List<string>>>()
            {
                // Ejemplo para la tabla asociativa 'existencias'
                Tuple.Create("existencias", new List<string>
                {
                    "Fk_BODCODIGO","Fk_BODCODIGO",    // Primera clave foránea
                    
                    "EXISALDO","INVCANTIDAD",

                    "INVCODIGO", "INVCODIGO",      // Segunda clave foránea
                    
                    "estado","estado"

                })
            };

            // Llamada al método
            navegador1.AsignarAsociativas(tablasAsociativas);
        }
    }
}
