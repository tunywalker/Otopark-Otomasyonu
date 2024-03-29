﻿using Otopark_Otomasyonu.Controller;
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
        // public s
        public string parkGelen="";
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
        AboneTurleriController atController = new AboneTurleriController();
     
         public void   ComboSec(ComboBox comboSecilecek,int id)
        {
            int sayac = 0;
            foreach (KeyValuePair<string, string> kvp in comboSecilecek.Items)
            {
                
                if (id.ToString() == kvp.Key)
                {
                    comboSecilecek.SelectedIndex= sayac;
                   
                }
                sayac++;
            }
          
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            List<FiyatTarifesi> ftList = ftController.FiyatTarifesiList;
            
            comboAracTur.DataSource= new BindingSource(ftController.comboDataSource(), null);
            comboAracTur.DisplayMember = "Value";
            comboAracTur.ValueMember = "Key";
            // comboAracTur.SelectedIndex = 
            //   MessageBox.Show(atController.comboDataSource().ToString());
            //    (KeyValuePair<string, string>)comboAracTur.SelectedItem).Key)
            


            List<AboneTurleri> atList = atController.AboneTurleriList;

            comboAboneTur.DataSource = new BindingSource(atController.comboDataSource(), null);
            comboAboneTur.DisplayMember = "Value";
            comboAboneTur.ValueMember = "Key";
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
                comboParkYer.SelectedIndex = 0;
                textPlaka.Text = plaka;
                labelGirisTarihi.Text = DateTime.Now.ToString();
                if (plakaResim!=null)
                {
                    pictureBox1.Image = plakaResim;
                }
               

                comboParkYer.Items.Clear();
                foreach (string parkYeri in bosParkyerleri)
                 comboParkYer.Items.Add(parkYeri);
              //  MessageBox.Show(parkGelen+ comboParkYer.Items.IndexOf(parkGelen).ToString());
                if (parkGelen!="")
                {
                //    MessageBox.Show(parkGelen + comboParkYer.Items.IndexOf(parkGelen).ToString());
                    comboParkYer.SelectedIndex=comboParkYer.Items.IndexOf(parkGelen);
                }
                else
                 comboParkYer.SelectedIndex = 0;
                
            }
            catch (Exception)
            {

                throw;
            }
            textPlaka.Text = plaka;
            textPlaka.Text = "";
            textPlaka.Text = plaka;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String aracPlaka;
        String parkYer;
        Boolean kayit;
        private void button1_Click(object sender, EventArgs e)
        {
            Arac KaydolacakArac = new Arac(textPlaka.Text,
           ftController.fiyatTarifesiById(Convert.ToInt32(((KeyValuePair<string, string>)comboAracTur.SelectedItem).Key)),
            DateTime.Now.ToString(),
            "1",
            atController.aboneTurleriById(Convert.ToInt32(((KeyValuePair<string, string>)comboAboneTur.SelectedItem).Key)),
            comboParkYer.Text,
            textAboneKimlik.Text,
            richTextBox1.Text,
            (Bitmap)pictureBox1.Image
            );
            if (guncelle==0)
            {
              
               kayit= KaydolacakArac.aracKaydet(KaydolacakArac);
            }
            else
            {
                if(KaydolacakArac.Abone_Tur.AboneTurleri_id==-1)
               kayit= KaydolacakArac.aracGuncelle(KaydolacakArac);
                else
                {
                    kayit = KaydolacakArac.aracGuncelleTarihsiz(KaydolacakArac);
                }
            }
         
          
            aracPlaka = textPlaka.Text; 
            Close();
            DialogResult = DialogResult.OK;
        }
        Arac aboneArac = new Arac();
        int guncelle = 0;
        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
            yeniAboneOlustur.Enabled = true;
            comboParkYer.Items.Clear();
            foreach (string parkYeri in bosParkyerleri)
                comboParkYer.Items.Add(parkYeri);
            if (parkGelen != "")
            {
                //    MessageBox.Show(parkGelen + comboParkYer.Items.IndexOf(parkGelen).ToString());
                comboParkYer.SelectedIndex = comboParkYer.Items.IndexOf(parkGelen);
            }
            else
                comboParkYer.SelectedIndex = 0;
           
            try
            {
                aboneArac = aboneArac.aracIcerdenGetir(textPlaka.Text);

                if (aboneArac.Arac_plaka.Trim() != "")
                {
                    textAboneKimlik.Text = aboneArac.Arac_sahip;

                    ComboSec(comboAboneTur, aboneArac.Abone_Tur.AboneTurleri_id);
                    ComboSec(comboAracTur, aboneArac.Arac_tur.FiyatTarifesi_id);
                    if (aboneArac.Arac_parkyeri.Trim() != "")
                    {
                        comboParkYer.Items.Add(aboneArac.Arac_parkyeri);
                        comboParkYer.SelectedIndex = (comboParkYer.Items.Count - 1);
                    }

                    //  MessageBox.Show(aboneArac.Arac_icerde.ToString());
                    //MessageBox.Show(aboneArac.Abone_Tur.AboneTurleri_id.ToString());
                    if (aboneArac.Arac_icerde.Trim() == "1")
                    {

                        comboAboneTur.Enabled = false;

                        comboAracTur.Enabled = false;

                        comboParkYer.Enabled = false;
                        richTextBox1.Enabled = false;
                     //   MessageBox.Show("3");
                        button1.Enabled = false;
                        yeniAboneOlustur.Enabled = false;

                    }
                    else
                    {

                        yeniAboneOlustur.Enabled = true;
                        textAboneKimlik.Enabled = true;
                        if (aboneArac.Abone_Tur.AboneTurleri_id == -1)
                        {
                            comboAboneTur.Enabled = true;
                            comboAracTur.Enabled = true;
                            comboParkYer.Enabled = true;
                            yeniAboneOlustur.Enabled = false;
                            textAboneKimlik.Enabled = false;
                            guncelle = 1;

                        }

                        else if (aboneArac.Abone_Tur.AboneTurleri_id == null) 
                        {
                            yeniAboneOlustur.Enabled = true;
                            textAboneKimlik.Enabled = true;
                            guncelle = 0;

                        }
                        else if (aboneArac.Abone_Tur.AboneTurleri_id != null)
                        {
                            comboAboneTur.Enabled = false;
                            comboAracTur.Enabled = false;
                            comboParkYer.Enabled = false;
                            yeniAboneOlustur.Enabled = false;
                            textAboneKimlik.Enabled = false;
                            guncelle = 1;
                        }
                    

                    }
                   
                   // buttonEkle.Enabled = false;

                }
                else
                {
                    textAboneKimlik.Text = "";
                    comboAboneTur.SelectedIndex = 0;
                    comboAracTur.SelectedIndex = 0;
                    richTextBox1.Text = "";
                   // label10.Text = "";
                    comboAboneTur.Enabled = true;
                    comboAracTur.Enabled = true;
                    comboParkYer.Enabled = true;
                    richTextBox1.Enabled = true;
                  //  buttonEkle.Enabled = true;
                }
            }
            catch
            {

            }
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
                //MessageBox.Show("1");
                label3.Text = GirecekAbone.Abone_adsoyad + " - " + GirecekAbone.Abone_telefon.ToUpper();
                button1.Enabled = true;
            }
            else
            {
              //  MessageBox.Show("2");
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

       
    }
}
