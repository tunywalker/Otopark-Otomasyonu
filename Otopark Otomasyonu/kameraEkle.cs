using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Otopark_Otomasyonu
{
    public partial class kameraEkle : Form
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8");// charset ekleyerek Türkçe karakter sorununuda gidermiş olduk.

        public kameraEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kameraEkle_Load(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
