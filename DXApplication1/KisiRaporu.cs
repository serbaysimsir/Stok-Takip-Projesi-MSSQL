using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DXApplication1
{
    public partial class KisiRaporu : DevExpress.XtraReports.UI.XtraReport
    {
        public KisiRaporu()
        {
            InitializeComponent();
        }
        public void InitData(string partarih, int perID, string perad, string persoyad, string perbolum)
        {
            ID.Value = perID;
            tarih.Value = partarih;
            ad.Value = perad;
            soyad.Value = persoyad;
            bolum.Value = perbolum;
        }

    }
}
