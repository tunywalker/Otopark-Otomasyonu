using Otopark_Otomasyonu.Controller;
using Otopark_Otomasyonu.DAO;
using Otopark_Otomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Otopark_Otomasyonu
{
    public partial class formAracGiris : Form
    {
       public String plaka = "";
        public List<string> bosParkyerleri;
        public Bitmap plakaResim;
        public formAracGiris()
        {
            InitializeComponent();
        }
        public Boolean kayitDurumu { get { return kayit; } }
        public String plakaNo { get { return aracPlaka; } }

        public void bildirimYazdir(String Tur, String Metin)
        {
            PopupNotifier popup = new PopupNotifier();
            Bitmap Icon = null;
            String Baslik = "";
            switch (Tur)
            {
                case "Basarili":
                    Baslik = "Yeni Abonelik Başarıyla Oluşturuldu";
                    Icon = Properties.Resources.uyari2; //icon from resources

                    break;
                case "Basarisiz":
                    Baslik = "Abonelik Oluşturulamadı";
                    Icon = Properties.Resources.basari; //icon from resources
                    break;
               
                default:
                    Baslik = "Bildirim";
                    break;
            }

            popup.TitleText = Baslik;
            popup.Image = Icon;
            popup.TitleFont = new System.Drawing.Font("Tahoma", 20F);
            popup.ContentFont = new System.Drawing.Font("Tahoma", 15F);
            popup.ContentText = Metin;
            popup.Popup();// show  

        }
        FiyatTarifesiController ftController = new FiyatTarifesiController();
        private void Form2_Load(object sender, EventArgs e)
        {
            List<FiyatTarifesi> ftList = ftController.FiyatTarifesiList;
            
            comboBox1.DataSource= new BindingSource(ftController.comboDataSource(), null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            //   comboBox1.SelectedIndex = null;


            //      MessageBox.Show((comboBox1.Items[0].ToString);
            Arac Girecek = new Arac();
            Girecek = Girecek.aracIcerdenGetir(plaka);
            if (Girecek.Arac_plaka!=null)
            {
                aboneBilgiDoldur(Girecek.Arac_sahip);
            }
            try
            {
                //comboBox1.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                textPlaka.Text = plaka;
                labelGirisTarihi.Text = DateTime.Now.ToString();
                if (plakaResim!=null)
                {
                    pictureBox1.Image = plakaResim;
                }
               

                comboBox3.Items.Clear();
                foreach (string parkYeri in bosParkyerleri)
                 comboBox3.Items.Add(parkYeri);
                
                comboBox3.SelectedIndex = 0;
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String aracPlaka;
        Boolean kayit;
        private void button1_Click(object sender, EventArgs e)
        {
          
            Arac A1 = new Arac(textPlaka.Text, 
                ftController.fiyatTarifesiById(Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key))
                , DateTime.Now.ToString(),
                "1", (Bitmap)pictureBox1.Image,
                comboBox3.Text.Replace("geerg",""), 
                textAboneKimlik.Text, 
                richTextBox1.Text);
             kayit=   A1.aracKaydet(A1);
            aracPlaka = textPlaka.Text; 
            Close();
            DialogResult = DialogResult.OK;
        }

        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
     public void aboneBilgiDoldur(string Kimlik)
        {
            Abone GirecekAbone = new Abone();
            GirecekAbone = GirecekAbone.aboneIcerdenGetir(Kimlik);
            if (GirecekAbone.Abone_kimlikno != null)
            {
                label3.Text = GirecekAbone.Abone_adsoyad + " - " + GirecekAbone.Abone_telefon.ToUpper();
                button1.Enabled = true;
            }
            else
            {
                label3.Text = "";
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            aboneBilgiDoldur(textAboneKimlik.Text);
           
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox3.Enabled = true;
            formYeniAbone yeniAbone = new formYeniAbone()
            {
               

            };
            if (yeniAbone.ShowDialog() == DialogResult.OK)
            {
                textAboneKimlik.Text = yeniAbone.AboneKimlik;
                if (yeniAbone.UyelikBasarili)
                {
                    aboneBilgiDoldur(yeniAbone.AboneKimlik);
                    bildirimYazdir("Basarili", "Yeni Abonelik Başarıyla Oluşturuldu.");
                }
                else
                {
                    bildirimYazdir("Basarisiz", "Böyle bir abonelik olduğu için yeni abone oluşturulamadı. Varolan abone ile devam edilecek.");
                    aboneBilgiDoldur(yeniAbone.AboneKimlik);
                }
               

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textAboneKimlik.Text = "-1";
                textAboneKimlik.Enabled = false;
            }
        }
    }
}
