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
              AboneTurleri  temp = new AboneTurleri(
                          Convert.ToInt16(okuyucu["aboneTurleri_id"]),
                           okuyucu["aboneTurleri_ad"].ToString(),
                          okuyucu["aboneTurleri_fiyat"].ToString(),
                         okuyucu["aboneTurleri_sure"].ToString());
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
                    okuyucu["aboneTurleri_fiyat"].ToString(),
                   okuyucu["aboneTurleri_sure"].ToString());
                


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

          


                dbConnection.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into abone_turleri (aboneTurleri_ad,aboneTurleri_fiyat,aboneTurleri_sure) values " +
                    "('"
                    + aboneTur.AboneTurleri_ad + "','"
                    + aboneTur.AboneTurleri_fiyat + "','"
                     + aboneTur.AboneTurleri_sure 
                     + "''"

                    
                    + "')", dbConnection.mysqlbaglan);


                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                dbConnection.mysqlbaglan.Close();


            try
            {

            }
            catch (Exception HataYakala)
            {


            }



        }
        public bool Delete(AboneTurleri AboneTurlerii)
        {


            dbConnection.mysqlbaglan.Open();
            MySqlCommand komut = new MySqlCommand("DELETE FROM abone_turleri WHERE aboneTurleri_id=" + AboneTurlerii.AboneTurleri_id, dbConnection.mysqlbaglan);
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
