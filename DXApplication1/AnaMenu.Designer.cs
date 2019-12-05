namespace DXApplication1
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceSatinAl = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceAtıgaGonderme = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePersonelEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceZimmet = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceZimmetEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceZimmetKaldir = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKisiRapor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceBolumRapor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceSefRapor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.aceSatinAlma = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.container.Appearance.Options.UseBackColor = true;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(50, 30);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(641, 443);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceSatinAl,
            this.aceAtıgaGonderme,
            this.acePersonelEkle,
            this.aceZimmet,
            this.accordionControlSeparator2,
            this.accordionControlElement5,
            this.accordionControlSeparator1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(50, 443);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceSatinAl
            // 
            this.aceSatinAl.Name = "aceSatinAl";
            this.aceSatinAl.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceSatinAl.Text = "Satın Alma İşlemi";
            this.aceSatinAl.Click += new System.EventHandler(this.aceSatinAl_Click);
            // 
            // aceAtıgaGonderme
            // 
            this.aceAtıgaGonderme.Name = "aceAtıgaGonderme";
            this.aceAtıgaGonderme.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceAtıgaGonderme.Text = "Atığa Gönderme";
            this.aceAtıgaGonderme.Click += new System.EventHandler(this.aceAtıgaGonderme_Click);
            // 
            // acePersonelEkle
            // 
            this.acePersonelEkle.Name = "acePersonelEkle";
            this.acePersonelEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePersonelEkle.Text = "Personel Ekleme";
            this.acePersonelEkle.Click += new System.EventHandler(this.acePersonelEkle_Click);
            // 
            // aceZimmet
            // 
            this.aceZimmet.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceZimmetEkle,
            this.aceZimmetKaldir});
            this.aceZimmet.Name = "aceZimmet";
            this.aceZimmet.Text = "Zimmet İşlemleri";
            // 
            // aceZimmetEkle
            // 
            this.aceZimmetEkle.Name = "aceZimmetEkle";
            this.aceZimmetEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceZimmetEkle.Text = "Zimmet Ekle";
            this.aceZimmetEkle.Click += new System.EventHandler(this.aceZimmetEkle_Click);
            // 
            // aceZimmetKaldir
            // 
            this.aceZimmetKaldir.Name = "aceZimmetKaldir";
            this.aceZimmetKaldir.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceZimmetKaldir.Text = "Zimmet Kaldır";
            this.aceZimmetKaldir.Click += new System.EventHandler(this.aceZimmetKaldir_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceKisiRapor,
            this.aceBolumRapor,
            this.aceSefRapor});
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Rapor İşlemleri";
            // 
            // aceKisiRapor
            // 
            this.aceKisiRapor.Name = "aceKisiRapor";
            this.aceKisiRapor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKisiRapor.Text = "Kişi Bazlı Raporlama";
            this.aceKisiRapor.Click += new System.EventHandler(this.aceKisiRapor_Click);
            // 
            // aceBolumRapor
            // 
            this.aceBolumRapor.Name = "aceBolumRapor";
            this.aceBolumRapor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceBolumRapor.Text = "Bölüm Bazlı Raporlama";
            this.aceBolumRapor.Click += new System.EventHandler(this.aceBolumRapor_Click);
            // 
            // aceSefRapor
            // 
            this.aceSefRapor.Name = "aceSefRapor";
            this.aceSefRapor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceSefRapor.Text = "Bölümümdeki Personellerin Raporlama";
            this.aceSefRapor.Click += new System.EventHandler(this.aceSefRapor_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // aceSatinAlma
            // 
            this.aceSatinAlma.Name = "aceSatinAlma";
            this.aceSatinAlma.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceSatinAlma.Text = "Satın Alma İşlemi";
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaMenu";
            this.NavigationControl = this.accordionControl1;
            this.Text = "AnaMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaMenu_FormClosing);
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSatinAlma;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSatinAl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAtıgaGonderme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePersonelEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceZimmet;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceZimmetEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceZimmetKaldir;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKisiRapor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceBolumRapor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSefRapor;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
    }
}