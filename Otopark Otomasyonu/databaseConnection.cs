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
    class databaseConnection
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8");// charset ekleyerek Türkçe karakter sorununuda gidermiş olduk.

      public  void kameraAdGetir(ListBox listbox)
        {
            mysqlbaglan.Open();

            MySqlCommand komut = new MySqlCommand("select * from kameralar", mysqlbaglan);
            MySqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())   // Çoklu veri okumak için
                listbox.Items.Add(okuyucu["k_adi"].ToString());
            mysqlbaglan.Close();
            try
            {

            }
            catch (Exception e)
            {

            }

        }
        public void formdoldur(TextBox tx1, ComboBox cb1 ,TextBox tx2,ComboBox cb2,CheckBox cBox1,CheckBox cBox2)
        {
           
            try
            {
                mysqlbaglan.Open();

                MySqlCommand komut = new MySqlCommand("select * from kameralar", mysqlbaglan);
                MySqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {   // Çoklu veri okumak için
                    tx1.Text = (okuyucu["k_adi"].ToString());
                    cb1.SelectedIndex = (okuyucu["k_hareketeduyarli"].ToString() == "1") ? 0 : 1;
                    tx2.Text= (okuyucu["k_filigran"].ToString());
                    cb2.SelectedIndex = (okuyucu["k_hareketeduyarli"].ToString() == "0") ? 0 : 1;
                    cBox1.Checked = (okuyucu["k_sadeceuye"].ToString() == "1") ? true : false;
                    cBox2.Checked = (okuyucu["k_aktif"].ToString() == "1") ? true : false;
                    mysqlbaglan.Close();
                }
            }
            catch (Exception e)
            {

            }

        }
    }
}
