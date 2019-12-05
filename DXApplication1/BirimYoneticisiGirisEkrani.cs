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
    public partial class BirimYoneticisiGirisEkrani : DevExpress.XtraEditors.XtraForm
    {
        public BirimYoneticisiGirisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        
        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from tblKullanici k inner join tblBolum b on k.kullaniciID =b.sefID where gorevID=3 and kullaniciID='" + int.Parse(txtID.Text) + "' and sifre='" + txtSifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    AnaMenu anamenu = new AnaMenu();
                    anamenu.KullaniciTipi = 3;
                    anamenu.BolumBilgisi = dr["bolumAdi"].ToString();
                    anamenu.BolumID = int.Parse(dr["bolumID"].ToString());
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
        private void BirimYoneticisiGirisEkrani_FormClosing(object sender, FormClosingEventArgs e)
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