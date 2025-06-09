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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.chkVacacion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkInsumos = new System.Windows.Forms.CheckBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.cmbTipoTarea = new System.Windows.Forms.ComboBox();
            this.cmbLugaress = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarLugares = new MaterialSkin.Controls.MaterialButton();
            this.txtLugares = new System.Windows.Forms.TextBox();
            this.txtTareas = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarTareas = new MaterialSkin.Controls.MaterialButton();
            this.txtMensajeria = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(525, 88);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(676, 330);
            this.dgvTareas.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(525, 427);
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
            this.btnCancelar.Location = new System.Drawing.Point(1105, 427);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.chkRecibo);
            this.groupBox1.Controls.Add(this.chkSalario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkEstudio);
            this.groupBox1.Controls.Add(this.chkVacacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkInsumos);
            this.groupBox1.Controls.Add(this.lbltelefono);
            this.groupBox1.Location = new System.Drawing.Point(17, 507);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 162);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Location = new System.Drawing.Point(250, 87);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(73, 20);
            this.chkRecibo.TabIndex = 24;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            // 
            // chkSalario
            // 
            this.chkSalario.AutoSize = true;
            this.chkSalario.Location = new System.Drawing.Point(250, 61);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(72, 20);
            this.chkSalario.TabIndex = 23;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reclamo:";
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(131, 108);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(74, 20);
            this.chkEstudio.TabIndex = 21;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // chkVacacion
            // 
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Location = new System.Drawing.Point(131, 61);
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.Size = new System.Drawing.Size(86, 20);
            this.chkVacacion.TabIndex = 20;
            this.chkVacacion.Text = "Vacación";
            this.chkVacacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Licencia:";
            // 
            // chkInsumos
            // 
            this.chkInsumos.AutoSize = true;
            this.chkInsumos.Location = new System.Drawing.Point(15, 57);
            this.chkInsumos.Name = "chkInsumos";
            this.chkInsumos.Size = new System.Drawing.Size(79, 20);
            this.chkInsumos.TabIndex = 18;
            this.chkInsumos.Text = "Insumos";
            this.chkInsumos.UseVisualStyleBackColor = true;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(12, 38);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(75, 20);
            this.lbltelefono.TabIndex = 10;
            this.lbltelefono.Text = "Uniforme:";
            // 
            // cmbTipoTarea
            // 
            this.cmbTipoTarea.FormattingEnabled = true;
            this.cmbTipoTarea.Location = new System.Drawing.Point(6, 35);
            this.cmbTipoTarea.Name = "cmbTipoTarea";
            this.cmbTipoTarea.Size = new System.Drawing.Size(156, 24);
            this.cmbTipoTarea.TabIndex = 21;
            // 
            // cmbLugaress
            // 
            this.cmbLugaress.FormattingEnabled = true;
            this.cmbLugaress.Location = new System.Drawing.Point(6, 35);
            this.cmbLugaress.Name = "cmbLugaress";
            this.cmbLugaress.Size = new System.Drawing.Size(156, 24);
            this.cmbLugaress.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarLugares);
            this.groupBox2.Controls.Add(this.txtLugares);
            this.groupBox2.Controls.Add(this.cmbLugaress);
            this.groupBox2.Location = new System.Drawing.Point(17, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 173);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lugares";
            // 
            // btnAgregarLugares
            // 
            this.btnAgregarLugares.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarLugares.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarLugares.Depth = 0;
            this.btnAgregarLugares.HighEmphasis = true;
            this.btnAgregarLugares.Icon = null;
            this.btnAgregarLugares.Location = new System.Drawing.Point(49, 128);
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
            this.txtLugares.Size = new System.Drawing.Size(156, 22);
            this.txtLugares.TabIndex = 24;
            // 
            // txtTareas
            // 
            this.txtTareas.Location = new System.Drawing.Point(6, 83);
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(156, 22);
            this.txtTareas.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarTareas);
            this.groupBox3.Controls.Add(this.txtTareas);
            this.groupBox3.Controls.Add(this.cmbTipoTarea);
            this.groupBox3.Location = new System.Drawing.Point(267, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 168);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tareas";
            // 
            // btnAgregarTareas
            // 
            this.btnAgregarTareas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTareas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarTareas.Depth = 0;
            this.btnAgregarTareas.HighEmphasis = true;
            this.btnAgregarTareas.Icon = null;
            this.btnAgregarTareas.Location = new System.Drawing.Point(6, 123);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMensajeria);
            this.groupBox4.Location = new System.Drawing.Point(483, 498);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 171);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mensajeria";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(812, 427);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_2);
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
            this.ClientSize = new System.Drawing.Size(1235, 695);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.dateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "frmRegistrarTarea";
            this.Text = "     Registrar tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvTareas;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.CheckBox chkVacacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInsumos;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.ComboBox cmbTipoTarea;
        private System.Windows.Forms.ComboBox cmbLugaress;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnAgregarLugares;
        private System.Windows.Forms.TextBox txtLugares;
        private System.Windows.Forms.TextBox txtTareas;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnAgregarTareas;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMensajeria;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}