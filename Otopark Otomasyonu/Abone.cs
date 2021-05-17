using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu
{
    class Abone
    {
        private string abone_adsoyad, abone_kimlikno, abone_ozeldurum,abone_telefon;
        private int abone_borc;

        public string Abone_adsoyad { get => abone_adsoyad; set => abone_adsoyad = value; }
       
        public string Abone_ozeldurum { get => abone_ozeldurum; set => abone_ozeldurum = value; }
        public int Abone_borc { get => abone_borc; set => abone_borc = value; }
        public string Abone_telefon { get => abone_telefon; set => abone_telefon = value; }
        public string Abone_kimlikno { get => abone_kimlikno; set => abone_kimlikno = value; }
        public Abone(string abone_kimlikno)
        {
            this.abone_kimlikno = abone_kimlikno;

        }

        public Abone()
        {
        }

        public Abone(string abone_adsoyad, string abone_kimlikno, string abone_ozeldurum, string abone_telefon)
        {
            this.abone_adsoyad = abone_adsoyad;
            this.abone_kimlikno = abone_kimlikno;
            this.abone_ozeldurum = abone_ozeldurum;
            this.abone_telefon = abone_telefon;
            this.abone_borc = 0;
        }

        databaseConnection baglanti1 = new databaseConnection();

        public bool aboneKaydet(Abone kayitEdilecek)
        {

            try
            {

                String abone_adsoyad = kayitEdilecek.abone_adsoyad;
                String abone_kimlikno = kayitEdilecek.abone_kimlikno;
                String abone_telefon = kayitEdilecek.abone_telefon;
                String abone_ozeldurum = kayitEdilecek.abone_ozeldurum;
                int abone_borc =0;
                
                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into aboneler (abone_adsoyad,abone_kimlikno,abone_telefon,abone_ozeldurum,abone_borc) values " +
                    "('"
                    + abone_adsoyad + "','"
                    + abone_kimlikno + "','"
                    + abone_telefon + "','"
                    + abone_ozeldurum + "','"
                    + abone_borc
                    + "')", baglanti1.mysqlbaglan);


                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                baglanti1.mysqlbaglan.Close();
                if (sonuc != null)
                    return true;
                else
                    return false;
                // bağlantıyı kapatalım
            }
            catch (Exception HataYakala)
            {
                return false;

            }




        }
        public Abone aboneIcerdenGetir(string Kimlik)
        {
            Abone girisYapan=new Abone();
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select * from aboneler where abone_kimlikno='" + Kimlik + "'", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için
              
                girisYapan = new Abone(okuyucu["abone_adsoyad"].ToString(),okuyucu["abone_kimlikno"].ToString(), 
                    okuyucu["abone_ozeldurum"].ToString(), okuyucu["abone_telefon"].ToString());







            }
            baglanti1.mysqlbaglan.Close();
            return girisYapan;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();

                return girisYapan;
            }
        }
        
        public bool aboneGuncelle(Abone kayitEdilecek)
        {

            try
            {

                String abone_adsoyad = kayitEdilecek.abone_adsoyad;
                String abone_kimlikno = kayitEdilecek.abone_kimlikno;
                String abone_telefon = kayitEdilecek.abone_telefon;
                String abone_ozeldurum = kayitEdilecek.abone_ozeldurum;
                int abone_borc = 0;
                //
                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("UPDATE aboneler SET " +
                "abone_adsoyad='" + abone_adsoyad + "' , " +
                "abone_telefon='" + abone_telefon +
                "',abone_ozeldurum='" + abone_ozeldurum +

                "' where abone_kimlikno='" + abone_kimlikno + "'", baglanti1.mysqlbaglan);


                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                baglanti1.mysqlbaglan.Close();
                if (sonuc != null)
                    return true;
                else
                    return false;
                // bağlantıyı kapatalım
            }
            catch (Exception HataYakala)
            {
                return false;

            }
        }
            public  bool aboneSil()
        {
            try
            {
                baglanti1.mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM aboneler WHERE abone_kimlikno='" + this.abone_kimlikno + "'", baglanti1.mysqlbaglan);
                object sonuc = null;
                sonuc = komut.ExecuteNonQuery();

                baglanti1.mysqlbaglan.Close();
                if (sonuc != null)
                    return true;
                else
                    return false;
                // bağlantıyı kapatalım

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
