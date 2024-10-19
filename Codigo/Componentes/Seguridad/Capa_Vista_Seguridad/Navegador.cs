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
    public partial class Navegador : Form
    {
        public Navegador(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "codigo", "nombre", "linea", "marca", "existencia", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.AsignarTabla("productos");
            //List<string> tablas = new List<string> { "lineas", "marcas" };
           // navegador1.AsignarTablas(tablas);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarComboConTabla("lineas", "codigo_linea", "nombre_linea", 1);
            navegador1.AsignarComboConTabla("marcas", "codigo_marca", "nombre_marca", 1);
            navegador1.AsignarForaneas("lineas", "nombre_linea", "codigo_linea", "codigo_linea");
            navegador1.AsignarForaneas("marcas", "nombre_marca", "codigo_marca", "codigo_marca");
            navegador1.AsignarNombreForm("PERROS");

        }
    }
}
