using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class AnaMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public int KullaniciTipi, BolumID;
        public string BolumBilgisi;
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void aceSatinAl_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucSatinAlma.Instance))
            {
                container.Controls.Add(ucSatinAlma.Instance);
                ucSatinAlma.Instance.Dock = DockStyle.Fill;
                ucSatinAlma.Instance.BringToFront();
            }
            ucSatinAlma.Instance.BringToFront();
        }

        private void aceAtıgaGonderme_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucAtigaGonder.Instance))
            {
                container.Controls.Add(ucAtigaGonder.Instance);
                ucAtigaGonder.Instance.Dock = DockStyle.Fill;
                ucAtigaGonder.Instance.BringToFront();
            }
            ucAtigaGonder.Instance.BringToFront();
        }

        private void acePersonelEkle_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucPersonel.Instance))
            {
                container.Controls.Add(ucPersonel.Instance);
                ucPersonel.Instance.Dock = DockStyle.Fill;
                ucPersonel.Instance.BringToFront();
            }
            ucPersonel.Instance.BringToFront();
        }

        private void aceZimmetEkle_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucZimmetle.Instance))
            {
                container.Controls.Add(ucZimmetle.Instance);
                ucZimmetle.Instance.Dock = DockStyle.Fill;
                ucZimmetle.Instance.BringToFront();
            }
            ucZimmetle.Instance.BringToFront();
        }

        private void aceZimmetKaldir_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucZimmetiAl.Instance))
            {
                container.Controls.Add(ucZimmetiAl.Instance);
                ucZimmetiAl.Instance.Dock = DockStyle.Fill;
                ucZimmetiAl.Instance.BringToFront();
            }
            ucZimmetiAl.Instance.BringToFront();
        }

        private void aceBolumRapor_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucBolumRapor.Instance))
            {
                container.Controls.Add(ucBolumRapor.Instance);
                ucBolumRapor.Instance.Dock = DockStyle.Fill;
                ucBolumRapor.Instance.BringToFront();
            }
            ucBolumRapor.Instance.BringToFront();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
            if (KullaniciTipi == 1)
            {
                aceSefRapor.Visible = false;
            }
            if (KullaniciTipi == 2)
            {
                acePersonelEkle.Visible = false;
                aceSefRapor.Visible = false;
            }
            else if (KullaniciTipi == 3)
            {
                acePersonelEkle.Visible = false;
                aceAtıgaGonderme.Visible = false;
                aceKisiRapor.Visible = false;
                aceSatinAl.Visible = false;
                aceZimmet.Visible = false;
                aceBolumRapor.Visible = false;
            }
        }

        private void aceKisiRapor_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucKisiRapor.Instance))
            {
                container.Controls.Add(ucKisiRapor.Instance);
                ucKisiRapor.Instance.Dock = DockStyle.Fill;
                ucKisiRapor.Instance.BringToFront();
            }
            ucKisiRapor.Instance.BringToFront();
        }

        private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
            this.Hide();
        }

        private void aceSefRapor_Click(object sender, EventArgs e)
        {
            BolumRaporcs bp = new BolumRaporcs();
            bp.bolumAdi = BolumBilgisi;
            bp.bolumID = BolumID;
            bp.PrintInvoice();
            bp.ShowDialog();
        }
    }
}
