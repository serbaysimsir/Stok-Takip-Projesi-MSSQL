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
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class ucAtigaGonder : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        private static ucAtigaGonder _instance;

        public static ucAtigaGonder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAtigaGonder();
                return _instance;
            }
        }
        public ucAtigaGonder()
        {
            InitializeComponent();
        }

        private void txtUrunID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Urun u = new Urun();
            try
            {
                if (txtUrunID.Text != "")
                {
                    u.urunID = Convert.ToInt32(txtUrunID.Text);
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from tblStok where urunID='" + int.Parse(txtUrunID.Text) + "'", baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        lblAdet.Text = dr["adet"].ToString();
                        lblUrunAdi.Text = dr["urunAdi"].ToString().ToUpper();
                        lblUrunID.Text = dr["urunID"].ToString().ToUpper();
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı");
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ürün ID bölümü boş geçilemez");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün ID kısmında geçersiz karakter kullandınız");
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Atığa Göndermek İstediğinize Emin Misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                Urun u = new Urun();
                try
                {
                    if (txtAdet.Text != "" && lblUrunID.Text != "0")
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("select * from tblStok where urunID='" + int.Parse(lblUrunID.Text) + "'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        if (dr.Read())
                        {
                            u.urunID = Convert.ToInt32(dr["urunID"].ToString());
                            u.adet = Convert.ToInt32(dr["adet"].ToString());
                            u.urunAd = dr["urunAdi"].ToString();
                            u.tarih = dr["tarih"].ToString();
                            u.Magaza = dr["alinanMagaza"].ToString();
                            u.fiyat = float.Parse(dr["fiyat"].ToString());
                            u.zimmetAdeti = Convert.ToInt32(dr["zimmettekiAdet"].ToString());
                            baglanti.Close();
                            k.AtıgaGonderme(u, int.Parse(txtAdet.Text));
                            txtAdet.Text = "0";
                            txtUrunID.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adet kısmı boş geçilemez");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmedik Bir Hata Oluştu..!");
                }
            }
            else
                MessageBox.Show("İşlem İptal Edildi");

        }
    }
}
