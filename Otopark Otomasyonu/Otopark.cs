using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu
{
    class Otopark
    {
        databaseConnection baglanti1 = new databaseConnection();

        public int kapasite = 100;
        public String dolulukOrani(int Kapasite)
        {
            try
            {
                baglanti1.mysqlbaglan.Close();
            }
            catch { }
            baglanti1.mysqlbaglan.Open();
            Kamera kGetirilen = new Kamera();
            MySqlCommand komut = new MySqlCommand("select count(*) AS aracSayisi from icerdeki_araclar", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
                return okuyucu["aracSayisi"].ToString()+"/"+Kapasite.ToString();
            else return "0/"+Kapasite.ToString();

             
       
            baglanti1.mysqlbaglan.Close();

            
        }
        public string randomParkYeriOlustur()
        {
            Random Rnd = new Random();

            List < string > parkyerleri= bosParkyerleri();

            return parkyerleri.ElementAt(Rnd.Next(1,kapasite));

        }
        public List<string> parkAlaniOlustur()
        {
            char[] blokAdlari = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I','J' };
            List<string> parkAlanlari = new List<string>();
            for (int i = 0; i < 10; i++)
            
                for (int j = 0; j < 10; j++)
                {
                    parkAlanlari.Add(blokAdlari[i].ToString() + "-"+(j + 1).ToString());
                }

            return parkAlanlari;
        }
        public List<string> bosParkyerleri()
        {
            try
            {
                baglanti1.mysqlbaglan.Close();
            }
            catch { }
            baglanti1.mysqlbaglan.Open();
            Kamera kGetirilen = new Kamera();
            MySqlCommand komut = new MySqlCommand("select arac_parkyeri from icerdeki_araclar", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();


            List<string> parkYerleri = parkAlaniOlustur();//KAPASİTE EKLENEBİLİR
            List<string> doluParkyerleri = new List<string>();
            while (okuyucu.Read())
                doluParkyerleri.Add(okuyucu["arac_parkyeri"].ToString());



            var bosParkyerleri = parkYerleri.Except(doluParkyerleri).ToList();

            baglanti1.mysqlbaglan.Close();
            return bosParkyerleri;


        }

    }
}
