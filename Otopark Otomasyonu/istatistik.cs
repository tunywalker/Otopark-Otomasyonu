using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu
{
    class istatistik
    {
        databaseConnection baglanti1 = new databaseConnection();
        public string aboneSayisi()
        {
            string aboneSayi = "";
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select count(*) from aboneler ", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için

                aboneSayi = okuyucu["count(*)"].ToString();







            }
            baglanti1.mysqlbaglan.Close();
            return aboneSayi;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();

                return aboneSayi;
            }
        }
        public string aracSayisi()
        {
            string aracSayi = "";
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select count(*) from araclar ", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için

                aracSayi = okuyucu["count(*)"].ToString();







            }
            baglanti1.mysqlbaglan.Close();
            return aracSayi;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();

                return aracSayi;
            }
        }
        public string icerdekiAracSayisi()
        {
            string aracSayi = "";
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select count(*) from araclar where arac_icerde=1 ", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için

                aracSayi = okuyucu["count(*)"].ToString();







            }
            baglanti1.mysqlbaglan.Close();
            return aracSayi;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();

                return aracSayi;
            }
        }
        public Dictionary<String ,int>  giseIslemleri()
        {
            string aracSayi = "";
            baglanti1.mysqlbaglan.Open();
            int bugun=0;
            int haftalik = 0;
            int aylik = 0;
            int yillik = 0;
            Dictionary<String, int> GiseIslemler = new Dictionary<String, int>();

            MySqlCommand komut = new MySqlCommand("select * from arac_log", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için
                DateTime giris = Convert.ToDateTime(okuyucu["islem_tarih"].ToString());
                DateTime simdi = Convert.ToDateTime(DateTime.Now);

                if (giris.Day == simdi.Day)
                {
                    bugun++;
                }
                if (giris.Month== simdi.Month)
                {
                    aylik++;
                }

                if (giris.Year == simdi.Year)
                {
                   yillik++;
                }
                if (giris >  simdi.AddDays(-7))
                {
                    haftalik++;
                }
            }
            GiseIslemler.Add("Bugün", bugun);
            GiseIslemler.Add("Aylık", aylik);
            GiseIslemler.Add("Haftalık", haftalik);
            GiseIslemler.Add("Yıllık", yillik);







            baglanti1.mysqlbaglan.Close();
            return GiseIslemler;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();
                return GiseIslemler;

            }
        }

    }
}
