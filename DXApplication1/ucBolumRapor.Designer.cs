namespace DXApplication1
{
    partial class ucBolumRapor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBolumRapor));
            this.btnBolumRapor = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBolumRapor
            // 
            this.btnBolumRapor.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumRapor.Appearance.Options.UseFont = true;
            this.btnBolumRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBolumRapor.ImageOptions.Image")));
            this.btnBolumRapor.Location = new System.Drawing.Point(103, 101);
            this.btnBolumRapor.Name = "btnBolumRapor";
            this.btnBolumRapor.Size = new System.Drawing.Size(199, 54);
            this.btnBolumRapor.TabIndex = 13;
            this.btnBolumRapor.Text = "RAPORLA";
            this.btnBolumRapor.Click += new System.EventHandler(this.btnBolumRapor_Click);
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Ortopedi",
            "Dahiliye",
            "KBB",
            "FTR",
            "Ağız ve Diş Sağlığı"});
            this.cmbBolum.Location = new System.Drawing.Point(103, 36);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(199, 30);
            this.cmbBolum.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bölüm :";
            // 
            // ucBolumRapor
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBolumRapor);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label2);
            this.Name = "ucBolumRapor";
            this.Size = new System.Drawing.Size(629, 469);
            this.Load += new System.EventHandler(this.ucBolumRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBolumRapor;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label2;
    }
}
