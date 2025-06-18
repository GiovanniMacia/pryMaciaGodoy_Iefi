namespace pryMaciaGodoy_Iefi
{
    partial class frmListarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarTareas));
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnVerTodos = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarTarea = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(6, 138);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(665, 405);
            this.dgvTareas.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerTodos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerTodos.Depth = 0;
            this.btnVerTodos.HighEmphasis = true;
            this.btnVerTodos.Icon = null;
            this.btnVerTodos.Location = new System.Drawing.Point(559, 87);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerTodos.Size = new System.Drawing.Size(100, 36);
            this.btnVerTodos.TabIndex = 36;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerTodos.UseAccentColor = false;
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // txtBuscarTarea
            // 
            this.txtBuscarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscarTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarTarea.Depth = 0;
            this.txtBuscarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarTarea.Location = new System.Drawing.Point(251, 87);
            this.txtBuscarTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarTarea.Name = "txtBuscarTarea";
            this.txtBuscarTarea.Size = new System.Drawing.Size(292, 39);
            this.txtBuscarTarea.TabIndex = 38;
            this.txtBuscarTarea.Text = "";
            this.txtBuscarTarea.TextChanged += new System.EventHandler(this.txtBuscarTarea_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Depth = 0;
            this.lblBuscar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBuscar.Location = new System.Drawing.Point(6, 94);
            this.lblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(171, 19);
            this.lblBuscar.TabIndex = 39;
            this.lblBuscar.Text = "Ingrese nombre de tarea";
            // 
            // frmListarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 560);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscarTarea);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgvTareas);
            this.Name = "frmListarTareas";
            this.Text = "     Listas de tareas";
            this.Load += new System.EventHandler(this.frmListarTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton btnVerTodos;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtBuscarTarea;
        private MaterialSkin.Controls.MaterialLabel lblBuscar;
    }
}