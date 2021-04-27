using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu.DAO
{


    class FiyatTarifesiDAO
    {
        databaseConnection dbConnection = new databaseConnection();
        public List<FiyatTarifesi> getFiyatTarifesi()
        {
            List<FiyatTarifesi> ftList = new List<FiyatTarifesi>();

            dbConnection.mysqlbaglan.Close();
            dbConnection.mysqlbaglan.Open();
                

                MySqlCommand komut = new MySqlCommand("select * from fiyat_tarifesi ", dbConnection.mysqlbaglan);

                MySqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())

                {
                    FiyatTarifesi temp = new FiyatTarifesi(
                        Convert.ToInt16(okuyucu["fiyatTarifesi_id"]),
                        Convert.ToInt16(okuyucu["fiyatTarifesi_fiyat"]),
                        okuyucu["fiyatTarifesi_kisaltma"].ToString(),
                        okuyucu["fiyatTarifesi_uzunAd"].ToString());
                    ftList.Add(temp);

                }
                dbConnection.mysqlbaglan.Close();
            try
            {
            }
            catch
            {

            }
            return ftList;
        }
        public FiyatTarifesi GetFiyatTarifesiById(int id)
        {
            FiyatTarifesi temp= new FiyatTarifesi();

            dbConnection.mysqlbaglan.Open();


            MySqlCommand komut = new MySqlCommand("select * from fiyat_tarifesi where fiyatTarifesi_id= "+id, dbConnection.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {
                temp = new FiyatTarifesi(
                    Convert.ToInt16(okuyucu["fiyatTarifesi_id"]),
                    Convert.ToInt16(okuyucu["fiyatTarifesi_fiyat"]),
                    okuyucu["fiyatTarifesi_kisaltma"].ToString(),
                    okuyucu["fiyatTarifesi_uzunAd"].ToString());
               

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

        public void Insert(FiyatTarifesi fiyatTarife) {

            try
            {


                dbConnection.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into fiyat_tarifesi (fiyatTarifesi_kisaltma,fiyatTarifesi_uzunAd,fiyatTarifesi_fiyat) values " +
                    "('"
                    + fiyatTarife.FiyatTarifesi_kisaltma + "','"

                    + fiyatTarife.FiyatTarifesi_uzunAd + "','"

                    + fiyatTarife.FiyatTarifesi_fiyat
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
                    MySqlCommand komut = new MySqlCommand("DELETE FROM fiyat_tarifesi WHERE fiyatTarifesi_id=" + fiyatTarife.FiyatTarifesi_id , dbConnection.mysqlbaglan);
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
        public bool Update(FiyatTarifesi fiyatTarife)
        {
            Debug.WriteLine(fiyatTarife.FiyatTarifesi_kisaltma);
            Debug.WriteLine(fiyatTarife.FiyatTarifesi_uzunAd);
            Debug.WriteLine(fiyatTarife.FiyatTarifesi_uzunAd);

            dbConnection.mysqlbaglan.Open();
            MySqlCommand guncelle = new MySqlCommand("UPDATE fiyat_tarifesi SET " +
                "fiyatTarifesi_kisaltma='" +fiyatTarife.FiyatTarifesi_kisaltma + "' , " +
                "fiyatTarifesi_uzunAd='" + fiyatTarife.FiyatTarifesi_uzunAd +
                "',fiyatTarifesi_fiyat='" + fiyatTarife.FiyatTarifesi_fiyat +

                "' where fiyatTarifesi_id='" + fiyatTarife.FiyatTarifesi_id + "'", dbConnection.mysqlbaglan);

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
