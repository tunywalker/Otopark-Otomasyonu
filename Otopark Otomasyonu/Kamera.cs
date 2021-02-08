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
        public Kamera()
        {



        }
        string k_id;
        string k_adi;
        string k_hareketeduyarli;
        string k_filigran;
        string k_aktif;
        string k_sadeceuye;
        string k_lokasyon;
        
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
        public void formdoldur(TextBox tx1, ComboBox cb1, TextBox tx2, ComboBox cb2, CheckBox cBox1, CheckBox cBox2 , int kameraId)
        {

            Kamera k1 = new Kamera();
            MessageBox.Show(kameraId.ToString());
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
