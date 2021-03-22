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
       

        public String dolulukOrani(int Kapasite)
        {
            try
            {
                baglanti1.mysqlbaglan.Close();
            }
            catch { }
            baglanti1.mysqlbaglan.Open();
            Kamera kGetirilen = new Kamera();
            MySqlCommand komut = new MySqlCommand("select count(*) AS aracSayisi from araclar where  arac_icerde='" +"1"+ "'", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
                return okuyucu["aracSayisi"].ToString()+"/"+Kapasite.ToString();
            else return "0/"+Kapasite.ToString();

             
       
            baglanti1.mysqlbaglan.Close();
            
        }
    }
}
