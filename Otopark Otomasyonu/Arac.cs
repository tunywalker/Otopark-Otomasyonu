using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Otopark_Otomasyonu.DAO;

namespace Otopark_Otomasyonu
{
    class Arac
    {
        String arac_plaka,  arac_giris, arac_cikis, arac_icerde, arac_parkyeri, arac_sahip, arac_aciklama;
        FiyatTarifesi arac_Tur;
        String arac_plakaresim;

        public Arac(string arac_plaka, FiyatTarifesi arac_tur, string arac_giris, string arac_icerde, Bitmap arac_plakaresim, string arac_parkyeri, string arac_sahip, string arac_aciklama)
        {
            this.Arac_plaka = arac_plaka;
            this.Arac_tur = arac_tur;
            this.Arac_giris = arac_giris;
            this.Arac_icerde = arac_icerde;
            this.Arac_plakaresim = bitmapToBase64(arac_plakaresim);
            this.Arac_parkyeri = arac_parkyeri;
            this.Arac_sahip = arac_sahip;
            this.Arac_aciklama = arac_aciklama;
        }
        databaseConnection baglanti1 = new databaseConnection();

        public string Arac_plaka { get => arac_plaka; set => arac_plaka = value; }
        public FiyatTarifesi Arac_tur { get => arac_Tur; set => arac_Tur = value; }
        public string Arac_giris { get => arac_giris; set => arac_giris = value; }
        public string Arac_cikis { get => arac_cikis; set => arac_cikis = value; }
        public string Arac_icerde { get => arac_icerde; set => arac_icerde = value; }
        public string Arac_parkyeri { get => arac_parkyeri; set => arac_parkyeri = value; }
        public string Arac_sahip { get => arac_sahip; set => arac_sahip = value; }
        public string Arac_aciklama { get => arac_aciklama; set => arac_aciklama = value; }
        public string Arac_plakaresim { get => arac_plakaresim; set => arac_plakaresim = value; }

        public string bitmapToBase64(Bitmap resim)
        {
            if (resim != null)
            {

                System.IO.MemoryStream ms = new MemoryStream();
                resim.Save(ms, ImageFormat.Jpeg);
                byte[] byteImage = ms.ToArray();
                return Convert.ToBase64String(byteImage);
            }
                return "null";
           
            

        }

        public Arac()
        {
        }
        public bool iceriDisari(String plaka,string giriscikis)
        {

            databaseConnection baglanti2 = new databaseConnection();

                 plaka = plaka.ToUpper();
                String islem = giriscikis;
                int gircik=0;
                if (islem == "Giriş")
                    gircik = 1;
                if(islem=="Çıkış")
                    gircik = 0;



            databaseConnection baglanti1 = new databaseConnection();

            baglanti1.mysqlbaglan.Open();
            // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
            MySqlCommand guncelle = new MySqlCommand("UPDATE araclar SET " +
            "arac_icerde='" + gircik +

            "' where arac_plaka='" + plaka + "'", baglanti1.mysqlbaglan);

            object sonuc = null;
            sonuc = guncelle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
            baglanti1.mysqlbaglan.Close();
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
        public bool logKaydet(String plaka, String islem)
        {
            Console.WriteLine("deneme");
            iceriDisari(plaka.Trim().ToUpper(), islem);
           

            try
            {
                

                String log_plaka = plaka.ToUpper();
                String log_islem = islem;
                String log_tarih = DateTime.Now.ToString();
              

                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into arac_log (islem_plaka,islem_turu,islem_tarih) values " +
                    "('"
                    + log_plaka + "','"

                    + log_islem + "','"

                    + log_tarih
                    + "')", baglanti1.mysqlbaglan); ;


                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                baglanti1.mysqlbaglan.Close();
               


  
                
                if (sonuc != null)
                {
                    
                    return true;
                   
                }
                else
                    return false;
            // bağlantıyı kapatalım

           
            }
            catch (Exception HataYakala)
            {
                return false;

            }

        }
        public bool aracKaydet(Arac kayitEdilecek)
        {
           
                bool sonuc=false;
                if (aracGetir(kayitEdilecek.arac_plaka).arac_plaka=="" && kayitEdilecek.arac_plaka.Length >4)
                {
                   
                    String plaka = kayitEdilecek.Arac_plaka.ToUpper();
                    String tur = kayitEdilecek.Arac_tur.FiyatTarifesi_id.ToString();
                    String giris = kayitEdilecek.Arac_giris;
                    String icerde = kayitEdilecek.Arac_icerde;
                    String plakaResim = kayitEdilecek.Arac_plakaresim;
                    String parkYeri = kayitEdilecek.Arac_parkyeri;
                    String sahip = kayitEdilecek.Arac_sahip;
                    String aciklama = kayitEdilecek.Arac_aciklama;
                    baglanti1.mysqlbaglan.Open();
                    // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                    MySqlCommand ekle = new MySqlCommand("insert into araclar (arac_plaka,arac_tur,arac_giris,arac_icerde,arac_plakaresim,arac_sahip,arac_aciklama) values " +
                        "('"
                        + plaka + "','"
                        + tur + "','"
                        + giris + "','"
                        + "0" + "','"
                        + plakaResim + "','"
                        
                          + sahip + "','"
                        + aciklama
                        + "')", baglanti1.mysqlbaglan);


                // sorguyu çalıştırıyorum.
                if (ekle.ExecuteNonQuery().ToString()!= null)
                {
                    sonuc = true;
                }
                     // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                    
                    baglanti1.mysqlbaglan.Close();
                
                logKaydet(plaka, "Giriş");
                aracİceriKaydet(kayitEdilecek);
                }
                else
                {
                    if (kayitEdilecek.arac_plaka.Length>4)
                    {
                        sonuc = aracİceriKaydet(kayitEdilecek);
                    baglanti1.mysqlbaglan.Close();
                    logKaydet(kayitEdilecek.arac_plaka, "Giriş");
                        
                  
                    }

                }
            return sonuc;
            // bağlantıyı kapatalım


            try
            {
            }

            catch (Exception HataYakala)
            {
                return false;

            }



        }
        public bool aracİceriKaydet(Arac kayitEdilecek)
        {

            try
            {
                String plaka = kayitEdilecek.Arac_plaka.ToUpper();
                String tur = kayitEdilecek.Arac_tur.FiyatTarifesi_id.ToString();
                String giris = kayitEdilecek.Arac_giris;
                String parkYeri = kayitEdilecek.Arac_parkyeri;
               
                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into icerdeki_araclar (arac_plaka,arac_giris,arac_parkyeri) values " +
                    "('"
                    + plaka + "','"
                   
                    + giris + "','"
                    
                    + parkYeri
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
        public bool cikisYap(string Plaka)
        {
            if (aracIcerdenGetir(Plaka).arac_plaka == Plaka.ToUpper().Trim())
            {
                try
                {
                    baglanti1.mysqlbaglan.Open();
                    MySqlCommand komut = new MySqlCommand("DELETE FROM icerdeki_araclar WHERE arac_plaka='" + Plaka + "'", baglanti1.mysqlbaglan);
                    object sonuc = null;
                    sonuc = komut.ExecuteNonQuery();

                    baglanti1.mysqlbaglan.Close();
                    if (sonuc != null)
                    {
                        logKaydet(Plaka, "Çıkış");
                        return true;

                    }

                    else
                        return false;
                    // bağlantıyı kapatalım

                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            return false;
            }


        FiyatTarifesiDAO ftDao= new FiyatTarifesiDAO();

        public Arac aracGetir(string  plaka)
        {
            try
            {
                plaka = plaka.ToUpper();
           
                baglanti1.mysqlbaglan.Close();
            }
            catch { }
            baglanti1.mysqlbaglan.Open();
            Arac aGetirilen = new Arac();
            aGetirilen.arac_plaka = "";
            MySqlCommand komut = new MySqlCommand("select * from araclar where arac_plaka='" + plaka + "'", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için
                aGetirilen.Arac_giris = (okuyucu["arac_giris"].ToString());
                aGetirilen.Arac_sahip = (okuyucu["arac_sahip"].ToString());
                aGetirilen.Arac_tur = ftDao.GetFiyatTarifesiById(1);
               
                aGetirilen.arac_plaka = okuyucu["arac_plaka"].ToString();








            }
            baglanti1.mysqlbaglan.Close();
            return aGetirilen;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();
              
                return aGetirilen;
            }
        }
       
        public Arac aracIcerdenGetir(string plaka)
        {
            try
            {
                plaka = plaka.ToUpper();

                baglanti1.mysqlbaglan.Close();
            }
            catch { }
            Arac gercekArac = new Arac(); gercekArac=gercekArac.aracGetir(plaka);
            
            baglanti1.mysqlbaglan.Open();
            Arac aGetirilen = new Arac();
            aGetirilen.arac_plaka = "";
            MySqlCommand komut = new MySqlCommand("select * from araclar where arac_plaka='" + plaka + "'", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için
                aGetirilen.Arac_giris = okuyucu["arac_giris"].ToString();
                aGetirilen.Arac_sahip = gercekArac.arac_sahip;
                aGetirilen.Arac_tur = gercekArac.ftDao.GetFiyatTarifesiById(Convert.ToInt32(okuyucu["arac_tur"]));
                aGetirilen.arac_plaka = okuyucu["arac_plaka"].ToString();
                aGetirilen.arac_icerde = okuyucu["arac_icerde"].ToString();








            }

            baglanti1.mysqlbaglan.Close();
            return aGetirilen;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();

                return aGetirilen;
            }
        }

    }
}
