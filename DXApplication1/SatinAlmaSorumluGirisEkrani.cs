using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class SatinAlmaSorumluGirisEkrani : DevExpress.XtraEditors.XtraForm
    {
        public SatinAlmaSorumluGirisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        
        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from tblKullanici where gorevID=2 and kullaniciID='" + int.Parse(txtID.Text) + "' and sifre='" + txtSifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    AnaMenu anamenu = new AnaMenu();
                    anamenu.KullaniciTipi = 2;
                    anamenu.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID veya Şifre boş geçilemez.");
                baglanti.Close();
            }
        }
        private void SatinAlmaSorumluGirisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
            this.Hide();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}