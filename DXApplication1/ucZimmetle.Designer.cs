namespace DXApplication1
{
    partial class ucZimmetle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucZimmetle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBolum = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelAd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUrunID = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunAd = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZimmetEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 481);
            this.groupBox1.TabIndex = 0;
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
            this.dataGridView1.Size = new System.Drawing.Size(629, 308);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnUrunID);
            this.groupBox2.Controls.Add(this.btnUrunAd);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUrunID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(655, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 481);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Arama";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(743, 308);
            this.dataGridView2.TabIndex = 12;
            // 
            // btnUrunID
            // 
            this.btnUrunID.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunID.Appearance.Options.UseFont = true;
            this.btnUrunID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunID.ImageOptions.Image")));
            this.btnUrunID.Location = new System.Drawing.Point(119, 90);
            this.btnUrunID.Name = "btnUrunID";
            this.btnUrunID.Size = new System.Drawing.Size(175, 54);
            this.btnUrunID.TabIndex = 16;
            this.btnUrunID.Text = "ID İLE ARA";
            this.btnUrunID.Click += new System.EventHandler(this.btnUrunID_Click);
            // 
            // btnUrunAd
            // 
            this.btnUrunAd.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAd.Appearance.Options.UseFont = true;
            this.btnUrunAd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunAd.ImageOptions.Image")));
            this.btnUrunAd.Location = new System.Drawing.Point(410, 90);
            this.btnUrunAd.Name = "btnUrunAd";
            this.btnUrunAd.Size = new System.Drawing.Size(183, 54);
            this.btnUrunAd.TabIndex = 15;
            this.btnUrunAd.Text = "ÜRÜN ADI İLE ARA";
            this.btnUrunAd.Click += new System.EventHandler(this.btnUrunAd_Click);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(418, 22);
            this.txtUrunAd.MaxLength = 50;
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(175, 31);
            this.txtUrunAd.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(309, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ürün Adı :";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(119, 22);
            this.txtUrunID.MaxLength = 7;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(175, 31);
            this.txtUrunID.TabIndex = 12;
            this.txtUrunID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ürün ID :";
            // 
            // btnZimmetEkle
            // 
            this.btnZimmetEkle.Appearance.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetEkle.Appearance.Options.UseFont = true;
            this.btnZimmetEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetEkle.ImageOptions.Image")));
            this.btnZimmetEkle.Location = new System.Drawing.Point(1437, 284);
            this.btnZimmetEkle.Name = "btnZimmetEkle";
            this.btnZimmetEkle.Size = new System.Drawing.Size(175, 77);
            this.btnZimmetEkle.TabIndex = 17;
            this.btnZimmetEkle.Text = "Zimmet Ekle";
            this.btnZimmetEkle.Click += new System.EventHandler(this.btnZimmetEkle_Click);
            // 
            // ucZimmetle
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZimmetEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucZimmetle";
            this.Size = new System.Drawing.Size(1699, 504);
            this.Load += new System.EventHandler(this.ucZimmetle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnBolum;
        private DevExpress.XtraEditors.SimpleButton btnPersonelAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraEditors.SimpleButton btnUrunID;
        private DevExpress.XtraEditors.SimpleButton btnUrunAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnZimmetEkle;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtUrunAd;
        public System.Windows.Forms.TextBox txtUrunID;
    }
}
