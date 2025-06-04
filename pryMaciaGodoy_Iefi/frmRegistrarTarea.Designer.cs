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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbTiposTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbLugares = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkUniforme = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkEstudio = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkLicencia = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkInsumo = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.chkVacacion = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbTiposTarea
            // 
            this.cmbTiposTarea.AutoResize = false;
            this.cmbTiposTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTiposTarea.Depth = 0;
            this.cmbTiposTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTiposTarea.DropDownHeight = 174;
            this.cmbTiposTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposTarea.DropDownWidth = 121;
            this.cmbTiposTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTiposTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTiposTarea.FormattingEnabled = true;
            this.cmbTiposTarea.IntegralHeight = false;
            this.cmbTiposTarea.ItemHeight = 43;
            this.cmbTiposTarea.Location = new System.Drawing.Point(239, 305);
            this.cmbTiposTarea.MaxDropDownItems = 4;
            this.cmbTiposTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTiposTarea.Name = "cmbTiposTarea";
            this.cmbTiposTarea.Size = new System.Drawing.Size(173, 49);
            this.cmbTiposTarea.StartIndex = 0;
            this.cmbTiposTarea.TabIndex = 1;
            // 
            // cmbLugares
            // 
            this.cmbLugares.AutoResize = false;
            this.cmbLugares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLugares.Depth = 0;
            this.cmbLugares.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLugares.DropDownHeight = 174;
            this.cmbLugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugares.DropDownWidth = 121;
            this.cmbLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLugares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLugares.FormattingEnabled = true;
            this.cmbLugares.IntegralHeight = false;
            this.cmbLugares.ItemHeight = 43;
            this.cmbLugares.Location = new System.Drawing.Point(239, 161);
            this.cmbLugares.MaxDropDownItems = 4;
            this.cmbLugares.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLugares.Name = "cmbLugares";
            this.cmbLugares.Size = new System.Drawing.Size(173, 49);
            this.cmbLugares.StartIndex = 0;
            this.cmbLugares.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 330);
            this.dataGridView1.TabIndex = 3;
            // 
            // chkUniforme
            // 
            this.chkUniforme.AutoSize = true;
            this.chkUniforme.Depth = 0;
            this.chkUniforme.Location = new System.Drawing.Point(18, 270);
            this.chkUniforme.Margin = new System.Windows.Forms.Padding(0);
            this.chkUniforme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUniforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUniforme.Name = "chkUniforme";
            this.chkUniforme.ReadOnly = false;
            this.chkUniforme.Ripple = true;
            this.chkUniforme.Size = new System.Drawing.Size(100, 37);
            this.chkUniforme.TabIndex = 4;
            this.chkUniforme.Text = "Uniforme";
            this.chkUniforme.UseVisualStyleBackColor = true;
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Depth = 0;
            this.chkEstudio.Location = new System.Drawing.Point(18, 369);
            this.chkEstudio.Margin = new System.Windows.Forms.Padding(0);
            this.chkEstudio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEstudio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.ReadOnly = false;
            this.chkEstudio.Ripple = true;
            this.chkEstudio.Size = new System.Drawing.Size(88, 37);
            this.chkEstudio.TabIndex = 5;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // chkLicencia
            // 
            this.chkLicencia.AutoSize = true;
            this.chkLicencia.Depth = 0;
            this.chkLicencia.Location = new System.Drawing.Point(18, 223);
            this.chkLicencia.Margin = new System.Windows.Forms.Padding(0);
            this.chkLicencia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkLicencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkLicencia.Name = "chkLicencia";
            this.chkLicencia.ReadOnly = false;
            this.chkLicencia.Ripple = true;
            this.chkLicencia.Size = new System.Drawing.Size(94, 37);
            this.chkLicencia.TabIndex = 6;
            this.chkLicencia.Text = "Licencia";
            this.chkLicencia.UseVisualStyleBackColor = true;
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Depth = 0;
            this.chkInsumo.Location = new System.Drawing.Point(18, 317);
            this.chkInsumo.Margin = new System.Windows.Forms.Padding(0);
            this.chkInsumo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.ReadOnly = false;
            this.chkInsumo.Ripple = true;
            this.chkInsumo.Size = new System.Drawing.Size(88, 37);
            this.chkInsumo.TabIndex = 7;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(602, 427);
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(790, 427);
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
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(437, 427);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkVacacion
            // 
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Depth = 0;
            this.chkVacacion.Location = new System.Drawing.Point(18, 186);
            this.chkVacacion.Margin = new System.Windows.Forms.Padding(0);
            this.chkVacacion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkVacacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.ReadOnly = false;
            this.chkVacacion.Ripple = true;
            this.chkVacacion.Size = new System.Drawing.Size(117, 37);
            this.chkVacacion.TabIndex = 11;
            this.chkVacacion.Text = "Vacaciones";
            this.chkVacacion.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 493);
            this.Controls.Add(this.chkVacacion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkInsumo);
            this.Controls.Add(this.chkLicencia);
            this.Controls.Add(this.chkEstudio);
            this.Controls.Add(this.chkUniforme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbLugares);
            this.Controls.Add(this.cmbTiposTarea);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmRegistrarTarea";
            this.Text = "Registrar tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox cmbTiposTarea;
        private MaterialSkin.Controls.MaterialComboBox cmbLugares;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCheckbox chkUniforme;
        private MaterialSkin.Controls.MaterialCheckbox chkEstudio;
        private MaterialSkin.Controls.MaterialCheckbox chkLicencia;
        private MaterialSkin.Controls.MaterialCheckbox chkInsumo;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialCheckbox chkVacacion;
    }
}