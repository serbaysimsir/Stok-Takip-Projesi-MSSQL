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

namespace DXApplication1
{
    public partial class KisiRapor : DevExpress.XtraEditors.XtraForm
    {
        public KisiRapor()
        {
            InitializeComponent();
        }
        public int perID;
        public string perAd, perSoyad, perBolum;
        public void PrintInvoice()
        {
            KisiRaporu kr = new KisiRaporu();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in kr.Parameters)
                p.Visible = false;
            kr.InitData(DateTime.Now.ToShortDateString(), perID, perAd, perSoyad, perBolum);
            documentViewer1.DocumentSource = kr;
            kr.CreateDocument();
            
        }
    }
}