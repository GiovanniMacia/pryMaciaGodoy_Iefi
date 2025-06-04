namespace pryMaciaGodoy_Iefi
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.menuTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.statusBarInicio = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioActivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaa = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaInicio = new System.Windows.Forms.ToolStripStatusLabel();
            this.registrarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInicio.SuspendLayout();
            this.statusBarInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTareas,
            this.menuAdministracion,
            this.salirToolStripMenuItem});
            this.menuInicio.Location = new System.Drawing.Point(3, 64);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(934, 28);
            this.menuInicio.TabIndex = 1;
            this.menuInicio.Text = "menuStrip1";
            // 
            // menuTareas
            // 
            this.menuTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTareasToolStripMenuItem,
            this.reclamarTareasToolStripMenuItem,
            this.listarTareasToolStripMenuItem});
            this.menuTareas.Name = "menuTareas";
            this.menuTareas.Size = new System.Drawing.Size(64, 24);
            this.menuTareas.Text = "Tareas";
            // 
            // menuAdministracion
            // 
            this.menuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.menuAdministracion.Name = "menuAdministracion";
            this.menuAdministracion.Size = new System.Drawing.Size(123, 24);
            this.menuAdministracion.Text = "Administracion";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.timerTiempo_Tick);
            // 
            // statusBarInicio
            // 
            this.statusBarInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBarInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioActivo,
            this.LblTiempo,
            this.lblFechaa,
            this.lblFechaInicio});
            this.statusBarInicio.Location = new System.Drawing.Point(3, 507);
            this.statusBarInicio.Name = "statusBarInicio";
            this.statusBarInicio.Size = new System.Drawing.Size(934, 26);
            this.statusBarInicio.TabIndex = 2;
            this.statusBarInicio.Text = "statusStrip1";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(115, 20);
            this.lblUsuarioActivo.Text = "Usuario Activo";
            // 
            // LblTiempo
            // 
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(721, 20);
            this.LblTiempo.Spring = true;
            this.LblTiempo.Text = "Tiempo";
            // 
            // lblFechaa
            // 
            this.lblFechaa.Name = "lblFechaa";
            this.lblFechaa.Size = new System.Drawing.Size(36, 20);
            this.lblFechaa.Text = "tool";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(47, 20);
            this.lblFechaInicio.Text = "Fecha";
            // 
            // registrarTareasToolStripMenuItem
            // 
            this.registrarTareasToolStripMenuItem.Name = "registrarTareasToolStripMenuItem";
            this.registrarTareasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarTareasToolStripMenuItem.Text = "Registrar Tareas";
            this.registrarTareasToolStripMenuItem.Click += new System.EventHandler(this.registrarTareasToolStripMenuItem_Click);
            // 
            // reclamarTareasToolStripMenuItem
            // 
            this.reclamarTareasToolStripMenuItem.Name = "reclamarTareasToolStripMenuItem";
            this.reclamarTareasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reclamarTareasToolStripMenuItem.Text = "Reclamar Tareas";
            // 
            // listarTareasToolStripMenuItem
            // 
            this.listarTareasToolStripMenuItem.Name = "listarTareasToolStripMenuItem";
            this.listarTareasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarTareasToolStripMenuItem.Text = "Listar Tareas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 536);
            this.Controls.Add(this.statusBarInicio);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.statusBarInicio.ResumeLayout(false);
            this.statusBarInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem menuTareas;
        private System.Windows.Forms.ToolStripMenuItem menuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.StatusStrip statusBarInicio;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActivo;
        private System.Windows.Forms.ToolStripStatusLabel LblTiempo;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaa;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaInicio;
        private System.Windows.Forms.ToolStripMenuItem registrarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTareasToolStripMenuItem;
    }
}