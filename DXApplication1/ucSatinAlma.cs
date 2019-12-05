using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class ucSatinAlma : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucSatinAlma _instance;

        public static ucSatinAlma Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSatinAlma();
                return _instance;
            }
        }
        public ucSatinAlma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool onay = false;
            if (dateTimePicker1.Value.Year < DateTime.Now.Year)
            {
                onay = true;
            }
            else if (dateTimePicker1.Value.Year == DateTime.Now.Year)
            {
                if (dateTimePicker1.Value.Month < DateTime.Now.Month)
                {
                    onay = true;
                }
                else if (dateTimePicker1.Value.Month == DateTime.Now.Month)
                {
                    if (dateTimePicker1.Value.Day <= DateTime.Now.Day)
                    {
                        onay = true;
                    }
                    else
                        onay = false;
                }
                else
                    onay = false;
            }
            else
                onay = false;

            if (onay == true)
            {
                Urun u = new Urun();
                Kullanicilar k = new Kullanicilar();
                try
                {
                    if (txtAd.Text != "" && txtMagaza.Text != "")
                    {
                        u.urunID = Convert.ToInt32(txtID.Text);
                        u.urunAd = txtAd.Text.ToUpper();
                        u.fiyat = float.Parse(txtFiyat.Text);
                        u.adet = Convert.ToInt32(txtAdet.Text);
                        u.Magaza = txtMagaza.Text.ToUpper();
                        u.tarih = dateTimePicker1.Value.ToLongDateString();
                        u.zimmetAdeti = 0;
                        if (u.adet > 0 && u.fiyat > 0)
                        {
                            k.SatinAlma(u);
                            txtAd.Clear();
                            txtAdet.Clear();
                            txtFiyat.Clear();
                            txtID.Clear();
                            txtMagaza.Clear();
                            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
                        }
                        else
                            MessageBox.Show("Adet ve Fiyat Bölümleri  1'den Küçük Olamaz");
                    }
                    else
                        MessageBox.Show("Ürün Adı ve Alınan Mağaza Bölümleri Boş Geçilemez");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Urun ID Fiyat veya Adet Bölümlerinde Geçersiz Karakter Kullandınız");
                }
            }
            else
                MessageBox.Show("Geçerli Tarih Değeri Giriniz");
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }
    }
}
