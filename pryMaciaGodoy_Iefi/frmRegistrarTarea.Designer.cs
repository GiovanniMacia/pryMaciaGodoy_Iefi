namespace pryMaciaGodoy_Iefi
{
    partial class frmRegistrarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTarea));
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.chkVacacion = new System.Windows.Forms.CheckBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.chkInsumos = new System.Windows.Forms.CheckBox();
            this.lblUniforme = new System.Windows.Forms.Label();
            this.cmbTipoTarea = new System.Windows.Forms.ComboBox();
            this.cmbLugaress = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificarLugares = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarLugares = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarLugares = new MaterialSkin.Controls.MaterialButton();
            this.txtLugares = new System.Windows.Forms.TextBox();
            this.txtTareas = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarTareas = new MaterialSkin.Controls.MaterialButton();
            this.txtMensajeria = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.grpMensajes = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.grpDetalles.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(1080, 88);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(247, 22);
            this.dateTime.TabIndex = 0;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(412, 88);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(662, 330);
            this.dgvTareas.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(426, 427);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(964, 427);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpDetalles
            // 
            this.grpDetalles.BackColor = System.Drawing.Color.Maroon;
            this.grpDetalles.Controls.Add(this.chkRecibo);
            this.grpDetalles.Controls.Add(this.chkSalario);
            this.grpDetalles.Controls.Add(this.lblReclamo);
            this.grpDetalles.Controls.Add(this.chkEstudio);
            this.grpDetalles.Controls.Add(this.chkVacacion);
            this.grpDetalles.Controls.Add(this.lblLicencia);
            this.grpDetalles.Controls.Add(this.chkInsumos);
            this.grpDetalles.Controls.Add(this.lblUniforme);
            this.grpDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalles.Location = new System.Drawing.Point(6, 522);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(387, 162);
            this.grpDetalles.TabIndex = 20;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles";
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecibo.Location = new System.Drawing.Point(250, 87);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(89, 24);
            this.chkRecibo.TabIndex = 24;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            // 
            // chkSalario
            // 
            this.chkSalario.AutoSize = true;
            this.chkSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalario.Location = new System.Drawing.Point(250, 61);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(90, 24);
            this.chkSalario.TabIndex = 23;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            // 
            // lblReclamo
            // 
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclamo.Location = new System.Drawing.Point(246, 18);
            this.lblReclamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(89, 24);
            this.lblReclamo.TabIndex = 22;
            this.lblReclamo.Text = "Reclamo:";
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstudio.Location = new System.Drawing.Point(131, 108);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(94, 24);
            this.chkEstudio.TabIndex = 21;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // chkVacacion
            // 
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVacacion.Location = new System.Drawing.Point(131, 61);
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.Size = new System.Drawing.Size(108, 24);
            this.chkVacacion.TabIndex = 20;
            this.chkVacacion.Text = "Vacación";
            this.chkVacacion.UseVisualStyleBackColor = true;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencia.Location = new System.Drawing.Point(127, 18);
            this.lblLicencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(83, 24);
            this.lblLicencia.TabIndex = 19;
            this.lblLicencia.Text = "Licencia:";
            // 
            // chkInsumos
            // 
            this.chkInsumos.AutoSize = true;
            this.chkInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsumos.Location = new System.Drawing.Point(6, 57);
            this.chkInsumos.Name = "chkInsumos";
            this.chkInsumos.Size = new System.Drawing.Size(101, 24);
            this.chkInsumos.TabIndex = 18;
            this.chkInsumos.Text = "Insumos";
            this.chkInsumos.UseVisualStyleBackColor = true;
            // 
            // lblUniforme
            // 
            this.lblUniforme.AutoSize = true;
            this.lblUniforme.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniforme.Location = new System.Drawing.Point(7, 18);
            this.lblUniforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniforme.Name = "lblUniforme";
            this.lblUniforme.Size = new System.Drawing.Size(96, 24);
            this.lblUniforme.TabIndex = 10;
            this.lblUniforme.Text = "Uniforme:";
            // 
            // cmbTipoTarea
            // 
            this.cmbTipoTarea.FormattingEnabled = true;
            this.cmbTipoTarea.Location = new System.Drawing.Point(6, 35);
            this.cmbTipoTarea.Name = "cmbTipoTarea";
            this.cmbTipoTarea.Size = new System.Drawing.Size(204, 28);
            this.cmbTipoTarea.TabIndex = 21;
            this.cmbTipoTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTarea_SelectedIndexChanged);
            // 
            // cmbLugaress
            // 
            this.cmbLugaress.FormattingEnabled = true;
            this.cmbLugaress.Location = new System.Drawing.Point(6, 35);
            this.cmbLugaress.Name = "cmbLugaress";
            this.cmbLugaress.Size = new System.Drawing.Size(204, 28);
            this.cmbLugaress.TabIndex = 22;
            this.cmbLugaress.SelectedIndexChanged += new System.EventHandler(this.cmbLugaress_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificarLugares);
            this.groupBox2.Controls.Add(this.btnEliminarLugares);
            this.groupBox2.Controls.Add(this.btnAgregarLugares);
            this.groupBox2.Controls.Add(this.txtLugares);
            this.groupBox2.Controls.Add(this.cmbLugaress);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 188);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lugares";
            // 
            // btnModificarLugares
            // 
            this.btnModificarLugares.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarLugares.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarLugares.Depth = 0;
            this.btnModificarLugares.HighEmphasis = true;
            this.btnModificarLugares.Icon = null;
            this.btnModificarLugares.Location = new System.Drawing.Point(250, 27);
            this.btnModificarLugares.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarLugares.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarLugares.Name = "btnModificarLugares";
            this.btnModificarLugares.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarLugares.Size = new System.Drawing.Size(99, 36);
            this.btnModificarLugares.TabIndex = 29;
            this.btnModificarLugares.Text = "Modificar";
            this.btnModificarLugares.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarLugares.UseAccentColor = false;
            this.btnModificarLugares.UseVisualStyleBackColor = true;
            this.btnModificarLugares.Click += new System.EventHandler(this.btnModificarLugares_Click);
            // 
            // btnEliminarLugares
            // 
            this.btnEliminarLugares.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarLugares.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarLugares.Depth = 0;
            this.btnEliminarLugares.HighEmphasis = true;
            this.btnEliminarLugares.Icon = null;
            this.btnEliminarLugares.Location = new System.Drawing.Point(252, 143);
            this.btnEliminarLugares.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarLugares.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarLugares.Name = "btnEliminarLugares";
            this.btnEliminarLugares.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarLugares.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarLugares.TabIndex = 30;
            this.btnEliminarLugares.Text = "Eliminar";
            this.btnEliminarLugares.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarLugares.UseAccentColor = false;
            this.btnEliminarLugares.UseVisualStyleBackColor = true;
            this.btnEliminarLugares.Click += new System.EventHandler(this.btnEliminarLugares_Click);
            // 
            // btnAgregarLugares
            // 
            this.btnAgregarLugares.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarLugares.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarLugares.Depth = 0;
            this.btnAgregarLugares.HighEmphasis = true;
            this.btnAgregarLugares.Icon = null;
            this.btnAgregarLugares.Location = new System.Drawing.Point(43, 152);
            this.btnAgregarLugares.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarLugares.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarLugares.Name = "btnAgregarLugares";
            this.btnAgregarLugares.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarLugares.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarLugares.TabIndex = 24;
            this.btnAgregarLugares.Text = "Agregar";
            this.btnAgregarLugares.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarLugares.UseAccentColor = false;
            this.btnAgregarLugares.UseVisualStyleBackColor = true;
            this.btnAgregarLugares.Click += new System.EventHandler(this.btnAgregarLugares_Click);
            // 
            // txtLugares
            // 
            this.txtLugares.Location = new System.Drawing.Point(6, 83);
            this.txtLugares.Name = "txtLugares";
            this.txtLugares.Size = new System.Drawing.Size(204, 27);
            this.txtLugares.TabIndex = 24;
            // 
            // txtTareas
            // 
            this.txtTareas.Location = new System.Drawing.Point(6, 83);
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(204, 27);
            this.txtTareas.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnAgregarTareas);
            this.groupBox3.Controls.Add(this.txtTareas);
            this.groupBox3.Controls.Add(this.cmbTipoTarea);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 194);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tareas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(250, 149);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(250, 35);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(99, 36);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarTareas
            // 
            this.btnAgregarTareas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTareas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarTareas.Depth = 0;
            this.btnAgregarTareas.HighEmphasis = true;
            this.btnAgregarTareas.Icon = null;
            this.btnAgregarTareas.Location = new System.Drawing.Point(58, 149);
            this.btnAgregarTareas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarTareas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTareas.Name = "btnAgregarTareas";
            this.btnAgregarTareas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarTareas.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarTareas.TabIndex = 26;
            this.btnAgregarTareas.Text = "Agregar";
            this.btnAgregarTareas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarTareas.UseAccentColor = false;
            this.btnAgregarTareas.UseVisualStyleBackColor = true;
            this.btnAgregarTareas.Click += new System.EventHandler(this.btnAgregarTareas_Click);
            // 
            // txtMensajeria
            // 
            this.txtMensajeria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMensajeria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeria.Depth = 0;
            this.txtMensajeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMensajeria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMensajeria.Location = new System.Drawing.Point(6, 21);
            this.txtMensajeria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMensajeria.Name = "txtMensajeria";
            this.txtMensajeria.Size = new System.Drawing.Size(586, 144);
            this.txtMensajeria.TabIndex = 26;
            this.txtMensajeria.Text = "";
            // 
            // grpMensajes
            // 
            this.grpMensajes.Controls.Add(this.txtMensajeria);
            this.grpMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMensajes.Location = new System.Drawing.Point(448, 501);
            this.grpMensajes.Name = "grpMensajes";
            this.grpMensajes.Size = new System.Drawing.Size(606, 171);
            this.grpMensajes.TabIndex = 27;
            this.grpMensajes.TabStop = false;
            this.grpMensajes.Text = "Mensajeria";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1333, 693);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.grpMensajes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.dateTime);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "frmRegistrarTarea";
            this.Text = "     Registrar tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpMensajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.DataGridView dgvTareas;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.CheckBox chkVacacion;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.CheckBox chkInsumos;
        private System.Windows.Forms.Label lblUniforme;
        private System.Windows.Forms.ComboBox cmbTipoTarea;
        private System.Windows.Forms.ComboBox cmbLugaress;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnAgregarLugares;
        private System.Windows.Forms.TextBox txtLugares;
        private System.Windows.Forms.TextBox txtTareas;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnAgregarTareas;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMensajeria;
        private System.Windows.Forms.GroupBox grpMensajes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton btnModificarLugares;
        private MaterialSkin.Controls.MaterialButton btnEliminarLugares;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
    }
}