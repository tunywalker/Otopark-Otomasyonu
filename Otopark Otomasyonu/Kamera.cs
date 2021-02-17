using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Otopark_Otomasyonu
{
    class Kamera
    {
        string k_id;
        string k_adi;
        string k_hareketeduyarli;
        string k_filigran;
        string k_aktif;
        string k_sadeceuye;
        string k_lokasyon;
        public Kamera()
        {



        }
       public Kamera(string k_adi,  string k_hareketeduyarli,string k_filigran,string k_lokasyon,string k_sadeceuye,string k_aktif)
        {
            this.k_adi = k_adi;
            this.k_hareketeduyarli = k_hareketeduyarli;
            this.k_filigran = k_filigran;
            this.k_lokasyon = k_lokasyon;
            this.k_aktif = k_aktif;
            this.k_sadeceuye = k_sadeceuye;
            
        }
        
         databaseConnection baglanti1 = new databaseConnection();

        public Kamera kameraGetir(int id)
        {
            Kamera kGetirilen = new Kamera();
            try
            {
                baglanti1.mysqlbaglan.Open();

                MySqlCommand komut = new MySqlCommand("select * from kameralar where k_id='"+id+"'", baglanti1.mysqlbaglan);
                MySqlDataReader okuyucu = komut.ExecuteReader();
                
                while (okuyucu.Read())
                {   // Çoklu veri okumak için
                    kGetirilen.k_adi= (okuyucu["k_adi"].ToString());
                    kGetirilen.k_hareketeduyarli = okuyucu["k_hareketeduyarli"].ToString();
                    
                    kGetirilen.k_filigran = okuyucu["k_filigran"].ToString();
                    kGetirilen.k_lokasyon = okuyucu["k_lokasyon"].ToString();
                    kGetirilen.k_sadeceuye = okuyucu["k_sadeceuye"].ToString();
                    kGetirilen.k_aktif = okuyucu["k_aktif"].ToString();
                    baglanti1.mysqlbaglan.Close();
                    
                   
                }
                return kGetirilen;
            }
            catch (Exception e)
            {
                return kGetirilen;
            }
        }
        public bool kameraKaydet(Kamera kayitEdilecek)
        {
           
                String k_adi = kayitEdilecek.k_adi;
                String k_hareketeduyarli = kayitEdilecek.k_hareketeduyarli;
                String k_filigran = kayitEdilecek.k_filigran;
                String k_aktif = kayitEdilecek.k_aktif;
                String k_lokasyon = kayitEdilecek.k_lokasyon;
            String k_sadeceuye = kayitEdilecek.k_sadeceuye;
                baglanti1.mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into kameralar (k_adi,k_hareketeduyarli,k_filigran,k_sadeceuye,k_aktif,k_lokasyon) values " +
                    "('" 
                    + k_adi + "','" 
                    + k_hareketeduyarli + "','"
                    + k_filigran + "','" 
                    + k_aktif + "','"
                    + k_sadeceuye + "','"
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
                
            try
            {
            }
            catch (Exception HataYakala)
            {
                return false;

            }



        }
        public void formdoldur(TextBox tx1, ComboBox cb1, TextBox tx2, ComboBox cb2, CheckBox cBox1, CheckBox cBox2 , int kameraId)
        {

            Kamera k1 = new Kamera();
           // MessageBox.Show(kameraId.ToString());
            k1 = kameraGetir(kameraId);
            try
            {
                
;                
               
                    tx1.Text = k1.k_adi;
                    cb1.SelectedIndex = (k1.k_hareketeduyarli== "1") ? 0 : 1;
               
                    tx2.Text = k1.k_filigran;
                    cb2.SelectedIndex = (k1.k_hareketeduyarli == "0") ? 0 : 1;
                    cBox1.Checked = (k1.k_sadeceuye == "1") ? true : false;
                    cBox2.Checked = (k1.k_aktif == "1") ? true : false;
                    baglanti1.mysqlbaglan.Close();
                
            }
            catch (Exception e)
            {
            
            }

        }
        public void kameraAdGetir(ListBox listbox)
        {
            baglanti1.mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select * from kameralar", baglanti1.mysqlbaglan);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            listbox.Items.Clear();
           
            try
            {
                while (okuyucu.Read())   // Çoklu veri okumak için
                    listbox.Items.Add(okuyucu["k_adi"].ToString());
                baglanti1.mysqlbaglan.Close();
            }
            catch (Exception e)
            {

            }
            
        }

    }
}
