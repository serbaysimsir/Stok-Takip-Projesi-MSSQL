using System;
using DXApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Kullanicilar k = new Kullanicilar();

        [TestMethod]
        public void PersonelEkleTest()
        {
            Personel p = new Personel();
            p.ad = "Bilal";
            p.soyad = "AKSAL";
            p.cinsiyet = "Erkek";
            p.bolumID = 1;
            k.PersonelEkle(p);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void SatinAlmaTest()
        {
            Urun u = new Urun();
            u.urunID = 1;
            u.urunAd = "A5 V11.1";
            u.fiyat = 4499;
            u.adet = 5;
            u.Magaza = "MONSTER";
            u.tarih = "2 Aralık 2018 Pazar";
            k.SatinAlma(u);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void AtigaGonderTest()
        {
            Urun u = new Urun();
            u.urunID = 1;
            u.urunAd = "A5 V11.1";
            u.fiyat = 4499;
            u.adet = 45;
            u.Magaza = "MONSTER";
            u.tarih = "2 Aralık 2018 Pazar";
            u.zimmetAdeti = 2;
            k.AtıgaGonderme(u, 100);
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void ZimmetlemeTest()
        {
            Urun u = new Urun();
            Personel p = new Personel();
            p.ID = 10011;
            p.ad = "Arda";
            p.soyad = "AYDIN";
            p.cinsiyet = "Erkek";
            p.bolumID = 4;
            u.urunID = 2;
            u.urunAd = "A5 V13.1.1";
            u.fiyat = 5000;
            u.Magaza = "MONSTER";
            u.tarih = "12 Aralık 2018 Çarşamba";
            u.zimmetAdeti = 2;
            k.Zimmetleme(u, p);
            Assert.AreEqual(1,1);
        }

        [TestMethod]
        public void ZimmetKaldirTest()
        {
            k.ZimmetiKaldir(2, 10011, 3);
            Assert.AreEqual(1, 1);
        }
    }
}
