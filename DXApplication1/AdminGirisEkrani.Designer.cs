namespace DXApplication1
{
    partial class AdminGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisEkrani));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ŞİFRE :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 28);
            this.txtID.Name = "txtID";
            this.txtID.Properties.MaxLength = 4;
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 2;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(92, 70);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.MaxLength = 16;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.ShowToolTips = false;
            this.txtSifre.Size = new System.Drawing.Size(161, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.ImageOptions.Image")));
            this.btnGirisYap.Location = new System.Drawing.Point(132, 110);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(121, 38);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AdminGirisEkrani
            // 
            this.AcceptButton = this.btnGirisYap;
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(295, 214);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 214);
            this.Name = "AdminGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGirisEkrani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminGirisEkrani_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
    }
}