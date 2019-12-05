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
    public partial class BolumRaporcs : DevExpress.XtraEditors.XtraForm
    {
        public BolumRaporcs()
        {
            InitializeComponent();
        }
        public string bolumAdi;
        public int bolumID;
        public void PrintInvoice()
        {
            BolumRaporu br = new BolumRaporu();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in br.Parameters)
                p.Visible = false;
            br.InitData(DateTime.Now.ToShortDateString(),bolumAdi,bolumID);
            documentViewer1.DocumentSource = br;
            br.CreateDocument();
        }
    }
}