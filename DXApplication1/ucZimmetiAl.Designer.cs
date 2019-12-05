namespace DXApplication1
{
    partial class ucZimmetiAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucZimmetiAl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBolum = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelAd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZimmetKaldir = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnBolum);
            this.groupBox1.Controls.Add(this.btnPersonelAd);
            this.groupBox1.Controls.Add(this.cmbBolum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 481);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Arama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 308);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnBolum
            // 
            this.btnBolum.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolum.Appearance.Options.UseFont = true;
            this.btnBolum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBolum.ImageOptions.Image")));
            this.btnBolum.Location = new System.Drawing.Point(345, 90);
            this.btnBolum.Name = "btnBolum";
            this.btnBolum.Size = new System.Drawing.Size(199, 54);
            this.btnBolum.TabIndex = 10;
            this.btnBolum.Text = "BÖLÜME GÖRE ARA";
            this.btnBolum.Click += new System.EventHandler(this.btnBolum_Click);
            // 
            // btnPersonelAd
            // 
            this.btnPersonelAd.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelAd.Appearance.Options.UseFont = true;
            this.btnPersonelAd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelAd.ImageOptions.Image")));
            this.btnPersonelAd.Location = new System.Drawing.Point(63, 90);
            this.btnPersonelAd.Name = "btnPersonelAd";
            this.btnPersonelAd.Size = new System.Drawing.Size(175, 54);
            this.btnPersonelAd.TabIndex = 9;
            this.btnPersonelAd.Text = "ADA GÖRE ARA";
            this.btnPersonelAd.Click += new System.EventHandler(this.btnPersonelAd_Click);
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
            this.cmbBolum.Location = new System.Drawing.Point(345, 25);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(199, 30);
            this.cmbBolum.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(259, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm :";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(63, 22);
            this.txtAd.MaxLength = 20;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(175, 31);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı : ";
            // 
            // btnZimmetKaldir
            // 
            this.btnZimmetKaldir.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetKaldir.Appearance.Options.UseFont = true;
            this.btnZimmetKaldir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetKaldir.ImageOptions.Image")));
            this.btnZimmetKaldir.Location = new System.Drawing.Point(640, 322);
            this.btnZimmetKaldir.Name = "btnZimmetKaldir";
            this.btnZimmetKaldir.Size = new System.Drawing.Size(175, 77);
            this.btnZimmetKaldir.TabIndex = 18;
            this.btnZimmetKaldir.Text = "Zimmeti Kaldır";
            this.btnZimmetKaldir.Click += new System.EventHandler(this.btnZimmetKaldir_Click);
            // 
            // ucZimmetiAl
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZimmetKaldir);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucZimmetiAl";
            this.Size = new System.Drawing.Size(1044, 562);
            this.Load += new System.EventHandler(this.ucZimmetiAl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnBolum;
        private DevExpress.XtraEditors.SimpleButton btnPersonelAd;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnZimmetKaldir;
        public System.Windows.Forms.TextBox txtAd;
    }
}
