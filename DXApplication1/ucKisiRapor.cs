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
    public partial class ucKisiRapor : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        private static ucKisiRapor _instance;

        public static ucKisiRapor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucKisiRapor();
                return _instance;
            }
        }
        public ucKisiRapor()
        {
            InitializeComponent();
        }

        private void btnKisiRapor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select *from tblPersonel p inner join tblBolum b on p.bolumID=b.bolumID where p.personelID='" + int.Parse(txtID.Text) + "' ",baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        KisiRapor kp = new KisiRapor();
                        kp.perID = int.Parse(txtID.Text);
                        kp.perAd = dr["personelAdi"].ToString();
                        kp.perSoyad = dr["personelSoyadi"].ToString();
                        kp.perBolum = dr["bolumAdi"].ToString();
                        kp.PrintInvoice();
                        kp.ShowDialog();
                        txtID.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bu ID'ye ait personel bulunamadı");
                    }
                    baglanti.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Geçersiz karakter kullandınız veya boş bıraktınız");
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
