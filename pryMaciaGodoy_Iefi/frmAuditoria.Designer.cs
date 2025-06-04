namespace pryMaciaGodoy_Iefi
{
    partial class frmAuditoria
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
            this.dgvAudi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAudi
            // 
            this.dgvAudi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudi.Location = new System.Drawing.Point(31, 129);
            this.dgvAudi.Name = "dgvAudi";
            this.dgvAudi.RowHeadersWidth = 51;
            this.dgvAudi.RowTemplate.Height = 24;
            this.dgvAudi.Size = new System.Drawing.Size(821, 451);
            this.dgvAudi.TabIndex = 0;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 637);
            this.Controls.Add(this.dgvAudi);
            this.Name = "frmAuditoria";
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAudi;
    }
}