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

    }
}
