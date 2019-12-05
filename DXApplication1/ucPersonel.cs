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
    public partial class ucPersonel : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        private static ucPersonel _instance;

        public static ucPersonel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPersonel();
                return _instance;
            }
        }
        public ucPersonel()
        {
            InitializeComponent();
        }
        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from vPersonelList", baglanti);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "vPersonelList");
                dataGridView1.DataSource = ds.Tables["vPersonelList"];
                baglanti.Close();
            }
        }

        private void ucPersonel_Load(object sender, EventArgs e)
        {
            cmbBolum.SelectedIndex = 0;
            cmbCinsiyet.SelectedIndex = 0;
            listeleme();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personel p = new Personel();
            if (txtAd.Text != "" && txtSoyad.Text != "")
            {
                p.ad = txtAd.Text.ToUpper();
                p.soyad = txtSoyad.Text.ToUpper();
                p.cinsiyet = cmbCinsiyet.Text;
                p.bolumID = (cmbBolum.SelectedIndex) + 1;
                k.PersonelEkle(p);
                listeleme();
                txtAd.Clear();
                txtSoyad.Clear();
            }
            else
                MessageBox.Show("Ad ve Soyad Bölümü Boş Geçilemez");
        }
    }
}
