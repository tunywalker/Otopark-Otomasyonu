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

namespace Otopark_Otomasyonu
{
    class Arac
    {
        String arac_plaka, arac_tur, arac_giris, arac_cikis, arac_icerde, arac_parkyeri, arac_sahip, arac_aciklama;
       String arac_plakaresim;
        public Arac(string arac_plaka, string arac_tur, string arac_giris, string arac_icerde, Bitmap arac_plakaresim, string arac_parkyeri, string arac_sahip, string arac_aciklama)
        {
            this.arac_plaka = arac_plaka;
            this.arac_tur = arac_tur;
            this.arac_giris = arac_giris;
            this.arac_icerde = arac_icerde;
            this.arac_plakaresim = bitmapToBase64(arac_plakaresim);
            this.arac_parkyeri = arac_parkyeri;
            this.arac_sahip = arac_sahip;
            this.arac_aciklama = arac_aciklama;
        }
        databaseConnection baglanti1 = new databaseConnection();
        public string bitmapToBase64(Bitmap resim)
        {
            System.IO.MemoryStream ms = new MemoryStream();
            resim.Save(ms, ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            return  Convert.ToBase64String(byteImage);

        }
        public bool aracKaydet(Arac kayitEdilecek)
        {


                String plaka = kayitEdilecek.arac_plaka;
                String tur = kayitEdilecek.arac_tur;
                String giris = kayitEdilecek.arac_giris;
                String icerde = kayitEdilecek.arac_icerde;
                String plakaResim = kayitEdilecek.arac_plakaresim;
                String parkYeri = kayitEdilecek.arac_parkyeri;
                String sahip = kayitEdilecek.arac_sahip;
                String aciklama = kayitEdilecek.arac_aciklama;
                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into araclar (arac_plaka,arac_tur,arac_giris,arac_icerde,arac_plakaresim,arac_parkyeri,arac_sahip,arac_aciklama) values " +
                    "('"
                    + plaka + "','"
                    + tur + "','"
                    + giris + "','"
                    + icerde + "','"
                    + plakaResim + "','"
                    + parkYeri + "','"
                      + sahip + "','"
                    + aciklama 
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
