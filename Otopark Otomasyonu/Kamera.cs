﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net;

namespace Otopark_Otomasyonu
{
    class Kamera
    {
     public   int k_id;
       public string k_adi;
        string k_hareketeduyarli;
      public  string k_filigran;
      public  string k_aktif;
        string k_sadeceuye;
     public   string k_lokasyon;
      public  string k_url;
        databaseConnection baglanti1 = new databaseConnection();
        databaseConnection baglanti2 = new databaseConnection();

        public Kamera()
        {



        }
        public string urlKontrol(String url)
        {
            WebRequest request = WebRequest.Create(url);
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return Convert.ToString((int)response.StatusCode);
                }

            }
            catch (WebException ex)
            {
                using (HttpWebResponse res = (HttpWebResponse)ex.Response)
                {
                    return "-";
                }
            }
        }
        Form kameraEkle = new Form();
       public Kamera(string k_adi,  string k_hareketeduyarli,string k_filigran,string k_lokasyon,string k_sadeceuye,string k_aktif, string k_url)
        {
            this.k_adi = k_adi;
            this.k_hareketeduyarli = k_hareketeduyarli;
            this.k_filigran = k_filigran;
            this.k_lokasyon = k_lokasyon;
            this.k_aktif = k_aktif;
            this.k_sadeceuye = k_sadeceuye;
            this.k_url = k_url;
            
        }
        
   
       
        public Kamera kameraGetir(int id)
        {
            try { 
            baglanti1.mysqlbaglan.Close();
            }
            catch { }
            baglanti1.mysqlbaglan.Open();
            Kamera kGetirilen = new Kamera();
            MySqlCommand komut = new MySqlCommand("select * from kameralar where k_id='" + id + "'", baglanti1.mysqlbaglan);

            MySqlDataReader okuyucu = komut.ExecuteReader();
                
                while (okuyucu.Read())

                {   // Çoklu veri okumak için
                    kGetirilen.k_id= Convert.ToInt16((okuyucu["k_id"]));
                kGetirilen.k_adi= (okuyucu["k_adi"].ToString());
                    kGetirilen.k_hareketeduyarli = okuyucu["k_hareketeduyarli"].ToString();
                      kGetirilen.k_url = okuyucu["k_url"].ToString();
                    kGetirilen.k_filigran = okuyucu["k_filigran"].ToString();
                    kGetirilen.k_lokasyon = okuyucu["k_lokasyon"].ToString();
                    kGetirilen.k_sadeceuye = okuyucu["k_sadeceuye"].ToString();
                    kGetirilen.k_aktif = okuyucu["k_aktif"].ToString();
                   
                    
                   
                }
            baglanti1.mysqlbaglan.Close();
            return kGetirilen;
            try
            {
            }
            catch (Exception e)
            {
                baglanti1.mysqlbaglan.Close();
                MessageBox.Show("");
                return kGetirilen;
            }
        }
        public Kamera[] kameraGetirAktif()
        {
            try
            {
                baglanti2.mysqlbaglan.Open();
            
            Kamera[] aktifKameralar = new Kamera[2];
            MySqlCommand komut = new MySqlCommand("select * from kameralar where k_aktif='" + '1' + "'", baglanti2.mysqlbaglan);
           
            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())

            {   // Çoklu veri okumak için
                 
                    if (aktifKameralar[0] == null)
                    {
                        aktifKameralar[0] = new Kamera(okuyucu["k_adi"].ToString(), okuyucu["k_hareketeduyarli"].ToString(), okuyucu["k_filigran"].ToString(), okuyucu["k_lokasyon"].ToString(), okuyucu["k_sadeceuye"].ToString(), "1", okuyucu["k_url"].ToString());
                   // MessageBox.Show(aktifKameralar[0].k_url.ToString());
                }
                    else aktifKameralar[1] = kameraGetir(Convert.ToInt16((okuyucu["k_id"])));




                }
            baglanti2.mysqlbaglan.Close();
            return aktifKameralar;
           
            }
            catch (Exception e)
            {
                                return null;
            }
        }
        public bool kameraKaydet(Kamera kayitEdilecek)
        {

            try
            {

                String k_adi = kayitEdilecek.k_adi;
                String k_url = kayitEdilecek.k_url;
                String k_hareketeduyarli = kayitEdilecek.k_hareketeduyarli;
                String k_filigran = kayitEdilecek.k_filigran;
                String k_aktif = kayitEdilecek.k_aktif;
                String k_lokasyon = kayitEdilecek.k_lokasyon;
                String k_sadeceuye = kayitEdilecek.k_sadeceuye;
                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into kameralar (k_adi,k_hareketeduyarli,k_filigran,k_aktif,k_sadeceuye,k_lokasyon,k_url) values " +
                    "('"
                    + k_adi + "','"
                    + k_hareketeduyarli + "','"
                    + k_filigran + "','"
                    + k_aktif + "','"
                    + k_sadeceuye + "','"
                    + k_url + "','"
                    + k_lokasyon
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
        public int aktifKameraSayisi()
        {
            int aktifKameraSayisi=0;
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select count(*) from kameralar where k_aktif='" + "1" + "'", baglanti1.mysqlbaglan);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            
            while (okuyucu.Read())
                aktifKameraSayisi= Convert.ToInt16(okuyucu["count(*)"]);





            baglanti1.mysqlbaglan.Close();
            return aktifKameraSayisi;

        }
       public bool kameraSil(int kameraId)
        {
            try
            {
                baglanti1.mysqlbaglan.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM kameralar WHERE k_id='"+kameraId+"'", baglanti1.mysqlbaglan);
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
        public bool kameraGuncelle(Kamera guncellenecek, int id)
        {

            String k_adi = guncellenecek.k_adi;
            String k_hareketeduyarli = guncellenecek.k_hareketeduyarli;
            String k_filigran = guncellenecek.k_filigran;
            String k_aktif = guncellenecek.k_aktif;
            String k_lokasyon = guncellenecek.k_lokasyon;
            String k_sadeceuye = guncellenecek.k_sadeceuye;
            String k_url = guncellenecek.k_url;
            baglanti1.mysqlbaglan.Open();
            // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
          /*  MySqlCommand guncelle = new MySqlCommand("insert into kameralar (k_adi,k_hareketeduyarli,k_filigran,k_aktif,k_sadeceuye,k_lokasyon) values " +
                "('"
                + k_adi + "','"
                + k_hareketeduyarli + "','"
                + k_filigran + "','"
                + k_aktif + "','"
                + k_sadeceuye + "','"
                + k_lokasyon
                + "')");*/
            MySqlCommand guncelle  =new MySqlCommand( "UPDATE kameralar SET " +
                "k_adi='" + guncellenecek.k_adi + "' , " +
                "k_hareketeduyarli='" + guncellenecek.k_hareketeduyarli+ 
                "',k_filigran='" + guncellenecek.k_filigran + 
                "',k_sadeceuye='" + guncellenecek.k_sadeceuye + 
                "',k_aktif='" + guncellenecek.k_aktif +
                "',k_lokasyon='" + guncellenecek.k_lokasyon +
                "',k_url='" + guncellenecek.k_url +
                "' where k_id='" + id + "'", baglanti1.mysqlbaglan);

            // sorguyu çalıştırıyorum.
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
        public void formdoldur(TextBox tx1, ComboBox cb1, TextBox tx2, ComboBox cb2, CheckBox cBox1, CheckBox cBox2 , TextBox textUrl,int kameraId)
        {

            Kamera k1 = new Kamera();
           // MessageBox.Show(kameraId.ToString());
            k1 = kameraGetir(kameraId);
            try
            {
               
;                
               
                    tx1.Text = k1.k_adi;
                    cb1.SelectedIndex = (k1.k_hareketeduyarli== "1") ? 1 : 0;
                textUrl.Text = k1.k_url;
                    tx2.Text = k1.k_filigran;
                    cb2.SelectedIndex = (k1.k_lokasyon == "0") ? 0 : 1;
                    cBox1.Checked = (k1.k_sadeceuye == "1") ? true : false;
                    cBox2.Checked = (k1.k_aktif == "1") ? true : false;
                    baglanti1.mysqlbaglan.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("hata");
            }

        }
       
        public void kameraAdGetir(ListBox listbox, ListBox listbox2,ListBox aktifKamera)
        {
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select * from kameralar", baglanti1.mysqlbaglan);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            listbox.Items.Clear();
            listbox2.Items.Clear();
            aktifKamera.Items.Clear();
           
            try
            {
                while (okuyucu.Read())
                {   // Çoklu veri okumak için
                    if (okuyucu["k_aktif"].ToString() == "1")
                        listbox.Items.Add(okuyucu["k_adi"].ToString() + " - Aktif");
                    else
                        listbox.Items.Add(okuyucu["k_adi"].ToString());

                    



                    listbox2.Items.Add(okuyucu["k_id"].ToString());
                    if (okuyucu["k_aktif"].ToString()=="1")
                    {
                        aktifKamera.Items.Add(okuyucu["k_id"]);
                    }
                
                }
                baglanti1.mysqlbaglan.Close();
            }
            catch (Exception e)
            {

            }
            
        }

    }
}
