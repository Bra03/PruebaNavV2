namespace Capa_Vista_Seguridad
{
    partial class MDI_Seguridad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Seguridad));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionModuloAAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prototiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimiento1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimiento2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.fACTURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.asignacionesToolStripMenuItem,
            this.cambioContraseñaToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.fACTURASToolStripMenuItem,
            this.mANTENIMIENTOToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1053, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.aplicacionesToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.perfilesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            this.aplicacionesToolStripMenuItem.Click += new System.EventHandler(this.AplicacionesToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.modulosToolStripMenuItem.Text = "Modulos";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.ModulosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.PerfilesToolStripMenuItem_Click);
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem,
            this.asignacionDePerfilesAUsuariosToolStripMenuItem,
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem,
            this.asignacionModuloAAplicacionesToolStripMenuItem});
            this.asignacionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.asignacionesToolStripMenuItem.Text = "Asignaciones";
            // 
            // asignacionDeAplicacionesAUsuariosToolStripMenuItem
            // 
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Name = "asignacionDeAplicacionesAUsuariosToolStripMenuItem";
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Text = "Asignacion de Aplicaciones a Usuarios";
            this.asignacionDeAplicacionesAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDeAplicacionesAUsuariosToolStripMenuItem_Click);
            // 
            // asignacionDePerfilesAUsuariosToolStripMenuItem
            // 
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Name = "asignacionDePerfilesAUsuariosToolStripMenuItem";
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Text = "Asignacion de Perfiles a Usuarios";
            this.asignacionDePerfilesAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDePerfilesAUsuariosToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionesAPerfilesToolStripMenuItem
            // 
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Name = "asignacionDeAplicacionesAPerfilesToolStripMenuItem";
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Text = "Asignacion de Aplicaciones a Perfiles";
            this.asignacionDeAplicacionesAPerfilesToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDeAplicacionesAPerfilesToolStripMenuItem_Click);
            // 
            // asignacionModuloAAplicacionesToolStripMenuItem
            // 
            this.asignacionModuloAAplicacionesToolStripMenuItem.Name = "asignacionModuloAAplicacionesToolStripMenuItem";
            this.asignacionModuloAAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.asignacionModuloAAplicacionesToolStripMenuItem.Text = "Asignacion Modulo a Aplicaciones";
            this.asignacionModuloAAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionModuloAAplicacionesToolStripMenuItem_Click);
            // 
            // cambioContraseñaToolStripMenuItem
            // 
            this.cambioContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioContraseñaToolStripMenuItem.Name = "cambioContraseñaToolStripMenuItem";
            this.cambioContraseñaToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.cambioContraseñaToolStripMenuItem.Text = "Cambio Contraseña";
            this.cambioContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambioContraseñaToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.BitacoraToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prototiposToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // prototiposToolStripMenuItem
            // 
            this.prototiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimiento1ToolStripMenuItem,
            this.mantenimiento2ToolStripMenuItem});
            this.prototiposToolStripMenuItem.Name = "prototiposToolStripMenuItem";
            this.prototiposToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prototiposToolStripMenuItem.Text = "Prototipos";
            // 
            // mantenimiento1ToolStripMenuItem
            // 
            this.mantenimiento1ToolStripMenuItem.Name = "mantenimiento1ToolStripMenuItem";
            this.mantenimiento1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mantenimiento1ToolStripMenuItem.Text = "Mantenimiento_1";
            // 
            // mantenimiento2ToolStripMenuItem
            // 
            this.mantenimiento2ToolStripMenuItem.Name = "mantenimiento2ToolStripMenuItem";
            this.mantenimiento2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mantenimiento2ToolStripMenuItem.Text = "Mantenimiento_2";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 989);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip.Size = new System.Drawing.Size(1053, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 938);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 52);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_nombreUsuario);
            this.panel2.Controls.Add(this.lbl_usuario);
            this.panel2.Location = new System.Drawing.Point(789, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 46);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(79, 11);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(26, 25);
            this.lbl_nombreUsuario.TabIndex = 1;
            this.lbl_nombreUsuario.Text = "--";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(3, 11);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(85, 25);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // fACTURASToolStripMenuItem
            // 
            this.fACTURASToolStripMenuItem.Name = "fACTURASToolStripMenuItem";
            this.fACTURASToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.fACTURASToolStripMenuItem.Text = "FACTURAS";
            this.fACTURASToolStripMenuItem.Click += new System.EventHandler(this.fACTURASToolStripMenuItem_Click);
            // 
            // mANTENIMIENTOToolStripMenuItem
            // 
            this.mANTENIMIENTOToolStripMenuItem.Name = "mANTENIMIENTOToolStripMenuItem";
            this.mANTENIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.mANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO";
            this.mANTENIMIENTOToolStripMenuItem.Click += new System.EventHandler(this.mANTENIMIENTOToolStripMenuItem_Click);
            // 
            // MDI_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 1015);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDI_Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Seguridad_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionesAPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionModuloAAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prototiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimiento1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimiento2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOToolStripMenuItem;
    }
}



