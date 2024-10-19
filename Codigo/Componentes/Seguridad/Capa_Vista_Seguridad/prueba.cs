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
    public partial class prueba : Form
    {
        public prueba(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "codigo", "nombre", "marca", "tipo", "existencia", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("vehiculos");
            navegador1.AsignarComboConTabla("marcas_vehiculos", "codigo_marca", "nombre_marca", 1); ; // ComboBox para marcas de vehículos
            navegador1.AsignarComboConTabla("tipos_vehiculos", "codigo_tipo", "nombre_tipo", 1); // ComboBox para tipos de vehículos

            navegador1.AsignarForaneas("marcas_vehiculos", "nombre_marca", "codigo_marca", "codigo_marca");
            navegador1.AsignarForaneas("tipos_vehiculos", "nombre_tipo", "codigo_tipo", "codigo_tipo");

            navegador1.AsignarNombreForm("VEHICULOS");
            // Configuración de los alias para las tablas adicionales

            List<string> tablas = new List<string> { "detalle_servicio", "detalle_pago", "detalle_envio" };
            navegador1.AsignarTablas(tablas);
            string[] aliasDetalleServicio = { "servicio_realizado", "costo", "estado" };
            navegador1.AsignarAliasExtras("detalle_servicio", aliasDetalleServicio);

            string[] aliasDetallePago = { "metodo_pago", "monto_pagado", "fecha_pago", "estado" };
            navegador1.AsignarAliasExtras("detalle_pago", aliasDetallePago);

            string[] aliasDetalleEnvio = { "direccion_envio", "fecha_envio", "estado" };
            navegador1.AsignarAliasExtras("detalle_envio", aliasDetalleEnvio);


        }
    }
}
