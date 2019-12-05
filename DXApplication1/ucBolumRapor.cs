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
    public partial class ucBolumRapor : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        private static ucBolumRapor _instance;

        public static ucBolumRapor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBolumRapor();
                return _instance;
            }
        }
        public ucBolumRapor()
        {
            InitializeComponent();
        }

        private void ucBolumRapor_Load(object sender, EventArgs e)
        {
            cmbBolum.SelectedIndex = 0;
        }

        private void btnBolumRapor_Click(object sender, EventArgs e)
        {
            BolumRaporcs bp = new BolumRaporcs();
            bp.bolumAdi = cmbBolum.Text.ToUpper();
            bp.bolumID = cmbBolum.SelectedIndex + 1;
            bp.PrintInvoice();
            bp.ShowDialog();
        }
    }
}
