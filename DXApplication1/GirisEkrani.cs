using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class GirisEkrani : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        public GirisEkrani()
        {
            InitializeComponent();
        }
        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            AdminGirisEkrani age = new AdminGirisEkrani();
            age.Show();
            this.Hide();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            SatinAlmaSorumluGirisEkrani sas = new SatinAlmaSorumluGirisEkrani();
            sas.Show();
            this.Hide();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            BirimYoneticisiGirisEkrani byge = new BirimYoneticisiGirisEkrani();
            byge.Show();
            this.Hide();
        }

        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
