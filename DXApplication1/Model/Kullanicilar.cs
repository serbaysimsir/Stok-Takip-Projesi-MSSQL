using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DXApplication1
{
    public class Kullanicilar : Kisi ,  Islemler
    {
        public string sifre;
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TM57CN0;Initial Catalog=stok_takip;Integrated Security=True");
        public bool AtıgaGonderme(Urun u, int SilinecekAdet)
        {
            int kalan = u.adet - SilinecekAdet;
            if (u.adet > SilinecekAdet)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tblAtik(urunID,urunAdi,fiyat,adet,alinanMagaza)values('" + u.urunID + "','" + u.urunAd + "','" + u.fiyat + "','" + SilinecekAdet + "','" + u.Magaza + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblStok set adet='" + kalan + "' where urunID='" + u.urunID + "' ", baglanti);
                komut2.ExecuteNonQuery();
                komut2.Dispose();
                baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Atığa Gönderme İşlemi Başarıyla Gerçekleşti");
                return true;
            }
            else if (u.adet == SilinecekAdet)
            {
                if (u.zimmetAdeti == 0)
                {
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("insert into tblAtik(urunID,urunAdi,fiyat,adet,alinanMagaza)values('" + u.urunID + "','" + u.urunAd + "','" + u.fiyat + "','" + SilinecekAdet + "','" + u.Magaza + "')", baglanti);
                    komut3.ExecuteNonQuery();
                    komut3.Dispose();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut4 = new SqlCommand("delete from tblStok where urunID='" + u.urunID + "'", baglanti);
                    komut4.ExecuteNonQuery();
                    komut4.Dispose();
                    baglanti.Close();
                    System.Windows.Forms.MessageBox.Show("Atığa Gönderme İşlemi Başarıyla Gerçekleşti");
                    return true;
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut5 = new SqlCommand("insert into tblAtik(urunID,urunAdi,fiyat,adet,alinanMagaza)values('" + u.urunID + "','" + u.urunAd + "','" + u.fiyat + "','" + SilinecekAdet + "','" + u.Magaza + "')", baglanti);
                    komut5.ExecuteNonQuery();
                    komut5.Dispose();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut6 = new SqlCommand("update tblStok set adet='" + 0 + "' where urunID='" + u.urunID + "' ", baglanti);
                    komut6.ExecuteNonQuery();
                    komut6.Dispose();
                    baglanti.Close();
                    System.Windows.Forms.MessageBox.Show("Atığa Gönderme İşlemi Başarıyla Gerçekleşti");
                    return true;
                }
            }
            else
            { 
                System.Windows.Forms.MessageBox.Show("Stoktaki Adet Yetersiz");
                return false;
            }
        }

        public bool PersonelEkle(Personel p)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into tblPersonel(personelAdi,personelSoyadi,cinsiyet,bolumID) values('" + p.ad + "','" + p.soyad + "','" + p.cinsiyet + "','" + p.bolumID + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Personel Ekleme İşlemi Başarılı");
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SatinAlma(Urun u)
        {
            Urun u2 = new Urun();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tblStok where urunID='" + u.urunID + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                u2.urunAd = dr["urunAdi"].ToString();
                u2.Magaza = dr["alinanMagaza"].ToString();
                u2.urunID = int.Parse(dr["urunID"].ToString());
                u2.adet = int.Parse(dr["adet"].ToString());
            }
            baglanti.Close();
            if (u.urunID==u2.urunID && u.urunAd.ToUpper()==u2.urunAd.ToUpper() && u.Magaza.ToUpper()==u2.Magaza.ToUpper())
            {
                int toplam = u.adet + u2.adet;
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblStok set adet = '" + toplam + "' where urunID = '" + u.urunID + "' ", baglanti );
                komut2.ExecuteNonQuery();
                komut2.Dispose();
                baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Satın Alma İşlemi Başarılı");
                return true;

            }
            else if(u.urunID==u2.urunID)
            {
                System.Windows.Forms.MessageBox.Show("Bu Ürün ID Daha Önceden Eklenmiş ve Eklenen ID ile Ürün Bilgileri Uyuşmuyor.");
                return false;
            }
            else
            {
                baglanti.Open();
                SqlCommand komut7 = new SqlCommand();
                komut7.Connection = baglanti;
                komut7.CommandText = "insert into tblStok(urunID,urunAdi,fiyat,adet,alinanMagaza,tarih,zimmettekiAdet) values('" + u.urunID + "','" + u.urunAd + "','" + u.fiyat + "','" + u.adet + "','" + u.Magaza + "','" + u.tarih + "','" + u.zimmetAdeti + "')";
                komut7.ExecuteNonQuery();
                komut7.Dispose();
                baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Satın Alma İşlemi Başarılı");
                return true;
            }

        }

        public bool ZimmetiKaldir(int UrunID, int PersonelID, int UrunAdet)
        {
            int stokadet, zimmetadet, guncelAdet;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tblStok where urunID='" + UrunID + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                stokadet = int.Parse(dr["adet"].ToString()) + 1;
                zimmetadet = int.Parse(dr["zimmettekiAdet"].ToString()) - 1;
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblStok set adet='" + stokadet + "',zimmettekiAdet='" + zimmetadet + "' where urunID='" + UrunID + "'", baglanti);
                komut2.ExecuteNonQuery();
                komut2.Dispose();
                baglanti.Close();
            }
            if (UrunAdet == 1)
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete tblZimmet where urunID='" + UrunID + "'and personelID='" + PersonelID + "'", baglanti);
                komut3.ExecuteNonQuery();
                komut3.Dispose();
                baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Zimmeti Kaldırma İşlemi Başarıyla Gerçekleşti");
                return true;
            }
            else if (UrunAdet > 1)
            {
                guncelAdet = UrunAdet - 1;
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("update tblZimmet set adet='" + guncelAdet + "' where urunID='" + UrunID + "' and personelID='" + PersonelID + "'", baglanti);
                komut4.ExecuteNonQuery();
                komut4.Dispose();
                baglanti.Close();
                System.Windows.Forms.MessageBox.Show("Zimmeti Kaldırma İşlemi Başarıyla Gerçekleşti");
                return true;
            }
            else
                return false;

        }

        public bool Zimmetleme(Urun u,Personel p)
        {
            try
            {
                int temp, temp2, temp3;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from tblZimmet where urunID='" + u.urunID + "' and personelID='" + p.ID + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    temp = int.Parse(dr["adet"].ToString()) + 1; ;
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update tblZimmet set adet='" + temp + "' where personelID='" + p.ID + "' and urunID='" + u.urunID + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    komut2.Dispose();
                    baglanti.Close();
                    baglanti.Open();
                    temp2 = u.adet - 1;
                    temp3 = u.zimmetAdeti + 1;
                    SqlCommand komut3 = new SqlCommand("update tblStok set adet='" + temp2 + "' , zimmettekiAdet='" + temp3 + "' where urunID='" + u.urunID + "'  ", baglanti);
                    komut3.ExecuteNonQuery();
                    komut3.Dispose();
                    baglanti.Close();
                    System.Windows.Forms.MessageBox.Show("Zimmet Verme İşlemi Başarılı");
                    return true;
                }
                else
                {
                    baglanti.Close();
                    temp = 1;
                    temp2 = u.adet - 1;
                    temp3 = u.zimmetAdeti + 1;
                    baglanti.Open();
                    SqlCommand komut4 = new SqlCommand("insert into tblZimmet(personelID,urunID,urunAdi,adet)values('" + p.ID + "','" + u.urunID + "','" + u.urunAd + "','" + temp + "')", baglanti);
                    komut4.ExecuteNonQuery();
                    komut4.Dispose();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut5 = new SqlCommand("update tblStok set adet='" + temp2 + "' , zimmettekiAdet='" + temp3 + "' where urunID='" + u.urunID + "' ", baglanti);
                    komut5.ExecuteNonQuery();
                    komut5.Dispose();
                    baglanti.Close();
                    System.Windows.Forms.MessageBox.Show("Zimmet Verme İşlemi Başarılı");
                    return true;
                }
            }catch(Exception e)
            {
                return false;
            }
        }
    }
}
