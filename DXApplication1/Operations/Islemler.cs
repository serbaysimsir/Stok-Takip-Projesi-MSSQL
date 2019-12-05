using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    public interface Islemler
    {
        bool PersonelEkle(Personel p);
        bool SatinAlma(Urun u);
        bool Zimmetleme(Urun u, Personel p);
        bool ZimmetiKaldir(int UrunID, int PersonelID, int UrunAdet);
        bool AtıgaGonderme(Urun u, int SilinecekAdet);

    }
}
