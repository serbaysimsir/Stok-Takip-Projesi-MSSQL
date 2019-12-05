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
    public partial class ucZimmetle : DevExpress.XtraEditors.XtraUserControl
    {
        public int butonNo;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        private static ucZimmetle _instance;

        public static ucZimmetle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucZimmetle();
                return _instance;
            }
        }
        public ucZimmetle()
        {
            InitializeComponent();
        }

        private void btnPersonelAd_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from vPersonelList where personelAdi='" + txtAd.Text.ToUpper() + "'", baglanti);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "vPersonelList");
                dataGridView1.DataSource = ds.Tables["vPersonelList"];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Personel Adı Boş Geçilemez");
            }
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from vPersonelList where bolumAdi='" + cmbBolum.Text + "'", baglanti);
            SqlDataAdapter adpr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "vPersonelList");
            dataGridView1.DataSource = ds.Tables["vPersonelList"];
            baglanti.Close();
        }

        private void btnUrunAd_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from tblStok where urunAdi='" + txtUrunAd.Text + "' and adet > 0", baglanti);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd); 
                DataSet ds = new DataSet();
                adpr.Fill(ds, "tblStok");
                dataGridView2.DataSource = ds.Tables["tblStok"];
                dataGridView2.Columns[6].Visible = false;
                baglanti.Close();
                butonNo = 2;
            }
        }

        private void btnUrunID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUrunID.Text != "")
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblStok where urunID='" + int.Parse(txtUrunID.Text) + "' and adet > 0", baglanti);
                    SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpr.Fill(ds, "tblStok");
                    dataGridView2.DataSource = ds.Tables["tblStok"];
                    dataGridView2.Columns[6].Visible = false;
                    baglanti.Close();
                    butonNo = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz Karakter Kullandınız veya Boş Bıraktınız");
            }
        }
        private void btnZimmetEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personel p = new Personel();
            Urun u = new Urun();
            try
            {
                p.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                u.urunID = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                u.urunAd = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                u.fiyat = float.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                u.adet = int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                u.zimmetAdeti = int.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString());
                k.Zimmetleme(u, p);
                if (butonNo == 1)
                {
                    btnUrunID_Click(btnUrunID, new EventArgs());
                }
                else
                {
                    btnUrunAd_Click(btnUrunAd, new EventArgs());
                }
            }catch(Exception ex) 
            {
                MessageBox.Show("Lütfen Ürün ve Personel Seçiniz");
            }
            
        }

        private void ucZimmetle_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            cmbBolum.SelectedIndex = 0;
        }

        private void txtUrunID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
