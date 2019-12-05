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
    public partial class ucZimmetiAl : DevExpress.XtraEditors.XtraUserControl
    {
        public int butonNo;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        private static ucZimmetiAl _instance;

        public static ucZimmetiAl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucZimmetiAl();
                return _instance;
            }
        }
        public ucZimmetiAl()
        {
            InitializeComponent();
        }

        private void btnPersonelAd_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from vListZimmet where personelAdi='" + txtAd.Text.ToUpper() + "'", baglanti);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "vListZimmet");
                dataGridView1.DataSource = ds.Tables["vListZimmet"];
                baglanti.Close();
                butonNo = 1;
            }
            else
            {
                MessageBox.Show("Personel Adı Boş Geçilemez");
            }
        }

        private void ucZimmetiAl_Load(object sender, EventArgs e)
        {
            cmbBolum.SelectedIndex = 0;
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from vListZimmet where bolumAdi='" + cmbBolum.Text + "'", baglanti);
            SqlDataAdapter adpr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "vListZimmet");
            dataGridView1.DataSource = ds.Tables["vListZimmet"];
            baglanti.Close();
            butonNo = 2;
        }

        private void btnZimmetKaldir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Zimmeti Kaldırmak İstediğinize Emin Misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                int personelID, urunID, urunAdet;
                try
                {
                    personelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    urunID = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    urunAdet = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    k.ZimmetiKaldir(urunID, personelID, urunAdet);
                    if (butonNo == 1)
                    {
                        btnPersonelAd_Click(btnPersonelAd, new EventArgs());
                    }
                    else
                    {
                        btnBolum_Click(btnBolum, new EventArgs());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmedik Bir Hata Oluştu..!");
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }
    }
}
