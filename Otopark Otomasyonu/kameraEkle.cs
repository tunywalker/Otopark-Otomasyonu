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
using System.Net;



namespace Otopark_Otomasyonu
{
    public partial class kameraEkle : Form
    {

        public kameraEkle()
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        databaseConnection c1;
        Kamera k = new Kamera();
        
        private void kameraEkle_Load(object sender, EventArgs e)
        {
            labelHata.Text = "";
            comboLokasyon.SelectedIndex = 0;
            comboYontem.SelectedIndex = 0;
             k.kameraAdGetir(listBox1,listBox2,listAktifKamera);
            buttonGuncelle.Visible = false;
            buttonEkle.Visible = true;
            timer1.Interval = 1000;
        }
        public void hataYazdir(String hataMetni)
        {
            labelHata.Text = "";
            labelHata.ForeColor = Color.Red;
            labelHata.Text = hataMetni;
            timer1.Start();
        }
        public void bildiriYazdir(String bildiri)
        {
            labelHata.Text = "";
            labelHata.Text = bildiri;
            labelHata.ForeColor = Color.Green;
            timer1.Start();
        }
        string testUrl;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
           
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                this.k = k.kameraGetir(Convert.ToInt16( listBox2.Items[listBox1.SelectedIndex]));
                k.formdoldur(textKadi, comboYontem, textFiligran, comboLokasyon, checkYabanci, checkAktif,textUrl, this.k.k_id);
                    if (textUrl.Text.Contains(".jpg") && textUrl.Text != "")
                    {
                      /*  while (urlWorker.IsBusy)
                        {
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(1000);
                        }
                        urlWorker.RunWorkerAsync(argument: textUrl.Text);
                        
                    */
                    
                    }
                   
                buttonEkle.Visible = false;
                buttonGuncelle.Visible = true;
                //  MessageBox.Show("Guncelle");
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textKadi.Text.Trim() == "")
                hataYazdir("Kamera Adı boş bırakılamaz!");


          
            else
            {
                if (k.aktifKameraSayisi()+1 > 2 )
                {
                    hataYazdir("Aktif kamera sayısı 2 den fazla olamaz. Aktif olmayarak kayıt edildi.");
                    checkAktif.Checked = false;
                }
                this.k = new Kamera(textKadi.Text, comboYontem.SelectedIndex.ToString(),
                    textFiligran.Text,
                    ((comboLokasyon.SelectedIndex == 0) ? "0" : "1").ToString(),
                    ((checkYabanci.Checked == true) ? 1 : 0).ToString(),
                    ((checkAktif.Checked) ? 1 : 0).ToString(),textUrl.Text
                   );
                if (k.kameraKaydet(this.k))
                    k.kameraAdGetir(listBox1, listBox2,listAktifKamera);


            }
        }

        private void comboYontem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void formTemizle()
        {
            textUrl.Text = "";
            textKadi.Text = "";
            textFiligran.Text = "";
            checkAktif.Checked = false;
            checkYabanci.Checked = false;
            comboLokasyon.SelectedIndex = 0;
            comboYontem.SelectedIndex = 0;
            buttonGuncelle.Visible = false;
            buttonEkle.Visible = true;

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            
            if (textKadi.Text.Trim() == "")
                hataYazdir("Kamera Adı boş bırakılamaz!");

           
            else
            {
              
                    if (k.aktifKameraSayisi() + 1 > 2 && k.kameraGetir(Convert.ToInt32(listBox2.Items[listBox1.SelectedIndex])).k_aktif != "1" && checkAktif.Checked)
                    {
                        hataYazdir("Aktif kamera sayısı 2 den fazla olamaz. Aktif olmayarak güncellendi.");
                        checkAktif.Checked = false;
                    }
                   
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                this.k = new Kamera(textKadi.Text, comboYontem.SelectedIndex.ToString(),
                   textFiligran.Text,
                   ((comboLokasyon.SelectedIndex == 0) ? "0" : "1").ToString(),
                   ((checkYabanci.Checked == true) ? 1 : 0).ToString(),
                   ((checkAktif.Checked) ? 1 : 0).ToString(),
                   textUrl.Text
                  );
                if (k.kameraGuncelle(this.k, Convert.ToInt16(listBox2.Items[listBox1.SelectedIndex])))
                {
                    k.kameraAdGetir(listBox1, listBox2,listAktifKamera);
                    formTemizle();



                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formTemizle();
        }

    

        private void kameraEkle_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
        int timerSayac=0;
       
      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timerSayac++;
            if (timerSayac==5)
            {
                timerSayac = 0;
                labelHata.Text = null;
                timer1.Stop();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                if (k.kameraSil(Convert.ToInt16(listBox2.Items[listBox2.SelectedIndex]))) ;
                k.kameraAdGetir(listBox1, listBox2,listAktifKamera);
                formTemizle();
            }
            catch
            {


            }
          
        }

        private void labelHata_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String url = e.Argument.ToString();
            MessageBox.Show(k.urlKontrol(url));
                bildiriYazdir("Kamera  Çalışıyor");
            
                hataYazdir("Kamera  Çalışmıyor");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
