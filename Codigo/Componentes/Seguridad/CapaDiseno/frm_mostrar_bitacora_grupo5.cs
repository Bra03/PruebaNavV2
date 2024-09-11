﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;

namespace CapaDiseno
{
    public partial class frm_mostrar_bitacora_grupo5 : Form
    {
        public frm_mostrar_bitacora_grupo5(string idUsuario)
        {
            InitializeComponent();
            logica_grupo5 logic = new logica_grupo5(idUsuario);
            dataGridView1.DataSource = logic.consultaLogicaBitacora().Tables[0];

            sentencia_grupo5 sn = new sentencia_grupo5(idUsuario);
            sn.insertarBitacora(idUsuario, "Consulto bitacora", "tbl_bitacora");
        }

        private void Frm_mostrar_bitacora_Load(object sender, EventArgs e)
        {

        }
    }
}
