using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DXApplication1
{
    public partial class BolumRaporu : DevExpress.XtraReports.UI.XtraReport
    {
        public BolumRaporu()
        {
            InitializeComponent();
        }
        public void InitData(string tarih, string bolumadi, int bolumID)
        {
            pTarih.Value = tarih;
            PBolumID.Value = bolumID;
            pBolum.Value = bolumadi;
        }

    }
}
