namespace pryMaciaGodoy_Iefi
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRol = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtContraseña = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.dgvGestion = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(831, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 506);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // cmbRol
            // 
            this.cmbRol.AutoResize = false;
            this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRol.Depth = 0;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRol.DropDownHeight = 174;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.DropDownWidth = 121;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.IntegralHeight = false;
            this.cmbRol.ItemHeight = 43;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbRol.Location = new System.Drawing.Point(168, 268);
            this.cmbRol.MaxDropDownItems = 4;
            this.cmbRol.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(198, 49);
            this.cmbRol.StartIndex = 0;
            this.cmbRol.TabIndex = 29;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AllowPromptAsInput = true;
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.AsciiOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.BeepOnError = false;
            this.txtCorreo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HidePromptOnLeave = false;
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(168, 167);
            this.txtCorreo.Mask = "";
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PrefixSuffixText = null;
            this.txtCorreo.PromptChar = '_';
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.RejectInputOnFirstFailure = false;
            this.txtCorreo.ResetOnPrompt = true;
            this.txtCorreo.ResetOnSpace = true;
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(198, 48);
            this.txtCorreo.SkipLiterals = true;
            this.txtCorreo.TabIndex = 27;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.ValidatingType = null;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AllowPromptAsInput = true;
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.AsciiOnly = false;
            this.txtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContraseña.BeepOnError = false;
            this.txtContraseña.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.HidePromptOnLeave = false;
            this.txtContraseña.HideSelection = true;
            this.txtContraseña.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(168, 94);
            this.txtContraseña.Mask = "";
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.PrefixSuffixText = null;
            this.txtContraseña.PromptChar = '_';
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.RejectInputOnFirstFailure = false;
            this.txtContraseña.ResetOnPrompt = true;
            this.txtContraseña.ResetOnSpace = true;
            this.txtContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(198, 48);
            this.txtContraseña.SkipLiterals = true;
            this.txtContraseña.TabIndex = 25;
            this.txtContraseña.TabStop = false;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContraseña.TrailingIcon = null;
            this.txtContraseña.UseSystemPasswordChar = false;
            this.txtContraseña.ValidatingType = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AllowPromptAsInput = true;
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.AsciiOnly = false;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.BeepOnError = false;
            this.txtUsuario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.HidePromptOnLeave = false;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(168, 21);
            this.txtUsuario.Mask = "";
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PrefixSuffixText = null;
            this.txtUsuario.PromptChar = '_';
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.RejectInputOnFirstFailure = false;
            this.txtUsuario.ResetOnPrompt = true;
            this.txtUsuario.ResetOnSpace = true;
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(198, 48);
            this.txtUsuario.SkipLiterals = true;
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 287);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(28, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Rol:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 187);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Correo:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Contraseña:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Usuario:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(264, 402);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 50);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Khaki;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(142, 402);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 50);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(9, 402);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 50);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecer.Image")));
            this.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecer.Location = new System.Drawing.Point(486, 117);
            this.btnRestablecer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(141, 51);
            this.btnRestablecer.TabIndex = 37;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // dgvGestion
            // 
            this.dgvGestion.AllowUserToAddRows = false;
            this.dgvGestion.AllowUserToDeleteRows = false;
            this.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestion.Location = new System.Drawing.Point(6, 180);
            this.dgvGestion.MultiSelect = false;
            this.dgvGestion.Name = "dgvGestion";
            this.dgvGestion.ReadOnly = true;
            this.dgvGestion.RowHeadersWidth = 51;
            this.dgvGestion.RowTemplate.Height = 24;
            this.dgvGestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestion.Size = new System.Drawing.Size(756, 407);
            this.dgvGestion.TabIndex = 36;
            this.dgvGestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestion_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(330, 122);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 51);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(23, 131);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(276, 30);
            this.txtBuscar.TabIndex = 34;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.dgvGestion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmUsuarios";
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox cmbRol;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.DataGridView dgvGestion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ErrorProvider Error;
    }
}