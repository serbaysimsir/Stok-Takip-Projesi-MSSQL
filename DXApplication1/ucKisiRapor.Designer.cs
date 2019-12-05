namespace DXApplication1
{
    partial class ucKisiRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKisiRapor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnKisiRapor = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(176, 45);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 31);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // btnKisiRapor
            // 
            this.btnKisiRapor.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiRapor.Appearance.Options.UseFont = true;
            this.btnKisiRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKisiRapor.ImageOptions.Image")));
            this.btnKisiRapor.Location = new System.Drawing.Point(176, 113);
            this.btnKisiRapor.Name = "btnKisiRapor";
            this.btnKisiRapor.Size = new System.Drawing.Size(199, 54);
            this.btnKisiRapor.TabIndex = 14;
            this.btnKisiRapor.Text = "RAPORLA";
            this.btnKisiRapor.Click += new System.EventHandler(this.btnKisiRapor_Click);
            // 
            // ucKisiRapor
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKisiRapor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "ucKisiRapor";
            this.Size = new System.Drawing.Size(614, 409);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnKisiRapor;
        public System.Windows.Forms.TextBox txtID;
    }
}
