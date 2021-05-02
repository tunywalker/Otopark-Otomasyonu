using MySql.Data.MySqlClient;
using Otopark_Otomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu.DAO
{
    class AboneTurleriDAO
    {
        databaseConnection dbConnection = new databaseConnection();
        public List<AboneTurleri> getAboneTurleri()
        {
            List<AboneTurleri> atList = new List<AboneTurleri>();

            dbConnection.mysqlbaglan.Close();
            dbConnection.mysqlbaglan.Open();


            MySqlCommand komut = new MySqlCommand("select * from abone_turleri ", dbConnection.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {
                AboneTurleri temp = new AboneTurleri(
                    Convert.ToInt16(okuyucu["aboneTurleri_id"]),
                    
                    okuyucu["aboneTurleri_ad"].ToString(),
                    okuyucu["abontTurleri_fiyat"].ToString());
                atList.Add(temp);

            }
            dbConnection.mysqlbaglan.Close();
            try
            {
            }
            catch
            {

            }
            return atList;
        }
        public AboneTurleri GetAboneTurleriById(int id)
        {
            AboneTurleri temp = new AboneTurleri();

            dbConnection.mysqlbaglan.Open();


            MySqlCommand komut = new MySqlCommand("select * from abone_turleri where aboneTurleri_id= " + id, dbConnection.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {
                 temp = new AboneTurleri(
                    Convert.ToInt16(okuyucu["aboneTurleri_id"]),

                    okuyucu["aboneTurleri_ad"].ToString(),
                    okuyucu["abontTurleri_fiyat"].ToString());
                


            }
            dbConnection.mysqlbaglan.Close();
            return temp;

            try
            {
            }
            catch
            {

            }


        }
        public void Insert(AboneTurleri aboneTur)
        {

            try
            {


                dbConnection.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into abone_turleri (aboneTurleri_ad,abontTurleri_fiyat) values " +
                    "('"
                    + aboneTur.AboneTurleri_ad + "','"

                    + aboneTur.AboneTurleri_fiyat + "','"

                    
                    + "')", dbConnection.mysqlbaglan);


                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                dbConnection.mysqlbaglan.Close();




            }
            catch (Exception HataYakala)
            {


            }



        }
        public bool Delete(FiyatTarifesi fiyatTarife)
        {


            dbConnection.mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("DELETE FROM abone_turleri WHERE aboneTurleri_id=" + fiyatTarife.FiyatTarifesi_id, dbConnection.mysqlbaglan);
            object sonuc = null;
            sonuc = komut.ExecuteNonQuery();

            dbConnection.mysqlbaglan.Close();
            if (sonuc != null)
            {

                return true;

            }

            else
                return false;
            // bağlantıyı kapatalım
            try
            {
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Update(AboneTurleri aboneTur)
        {
         

            dbConnection.mysqlbaglan.Open();
            MySqlCommand guncelle = new MySqlCommand("UPDATE abone_turleri SET " +
                "aboneTurleri_ad='" + aboneTur.AboneTurleri_ad + "' , " +
                "aboneTurleri_fiyat='" + aboneTur.AboneTurleri_fiyat +
                

                "' where aboneTurleri_id='" + aboneTur.AboneTurleri_id + "'", dbConnection.mysqlbaglan);

            // sorguyu çalıştırıyorum.
            object sonuc = null;
            sonuc = guncelle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
            dbConnection.mysqlbaglan.Close();
            if (sonuc != null)
                return true;
            else
                return false;
            // bağlantıyı kapatalım

            try
            {
            }
            catch (Exception HataYakala)
            {
                return false;

            }



        }


    }
}
