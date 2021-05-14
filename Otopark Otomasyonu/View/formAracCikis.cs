using Otopark_Otomasyonu.Controller;
using Otopark_Otomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class AracCikis : Form
    {
        public AracCikis()
        {
            InitializeComponent();
        }
       private Arac cikacak = new Arac();
        public Boolean cikisDurumu { get { return cikis; } }
        bool cikis = false;
        private string aracPlaka;
        private Bitmap plakaResim;

        public Bitmap PlakaResim { get { return plakaResim; } set => plakaResim = value; }
        public String AracPlaka { get {return  aracPlaka; } set => aracPlaka = value; }

        internal Arac Cikacak { get => cikacak; set => cikacak = value; }

        private void AracCikis_Load(object sender, EventArgs e)
        {
            textPlaka.Text = AracPlaka;
            label1.Text = "";
        }

        public int sureHesapla(int gunSayisi, string GirisTarihi)
        {

            DateTime giris = Convert.ToDateTime(GirisTarihi);
            DateTime simdi = Convert.ToDateTime(DateTime.Now);
            TimeSpan sonuc = simdi-giris;
            int sure = gunSayisi * 60*24;
            int gecensure = sonuc.Days * 24 * 60+sonuc.Hours+60+sonuc.Minutes;
            int sonucc = sure - gecensure;
            MessageBox.Show("Kalan"+ (sure-gecensure).ToString());
            if (sonucc>1)
            {
                return sonucc;
            }
            else
            {
                return 0;
            }
            
        }

        public int CikisHesabi()
        {
           
            if (cikacak.Abone_Tur.AboneTurleri_id == -1)
            {
                MessageBox.Show("Durum1");
                //Çıkış Yap Park Yerini Boşalt 
            }
            else
            {
            int sonuc=    sureHesapla(Convert.ToInt32(atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_sure), cikacak.Arac_giris);
                if (sonuc==0)
                {
                    labelKalanSure.Text = "Abonelik Süresi Doldu";
                }
                else
                {
                    sonuc = 62000;
                 int   Gun = (sonuc/60) / 24;
                    if(Gun>=1)
                    sonuc = sonuc - (Gun * 24*60);
                    int saat = sonuc / 60;
                    if(saat>=1)
                    sonuc = sonuc - (saat * 60);
                    int dakika = sonuc;
                  labelKalanSure.Text= Gun.ToString() +" Gün "+ saat.ToString() +" Saat "+ dakika.ToString() +" Dakika";
                 //   MessageBox.Show(((sonuc/60)/24) .ToString()+ "Gün" + (sonuc/60 % 24).ToString()+"Saat" + (sonuc / 60 % 60) +"Dakika");
                }    
                //Abonelik Süresi Devam ediyorsa Çıkış Yap Fiyat Hesapla park yerini boşaltma

            }
            return 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            aracPlaka = textPlaka.Text;
         cikis=   Cikacak.cikisYap(textPlaka.Text,1);
            DialogResult = DialogResult.OK;
          //  Cikacak.CikisHesabi(Cikacak, this);
        }
        FiyatTarifesiController ftController = new FiyatTarifesiController();
        AboneTurleriController atController = new AboneTurleriController();
        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "-";
            label1.Text = "";
            label8.Text = "-";
            if (textPlaka.Text.Length>=5)
            {
                labelAractur.Text = "-";
                label5.Text = "-";
                    int saat = 0;
                    Cikacak = Cikacak.aracIcerdenGetir(textPlaka.Text);
                    Abone sahip = new Abone();

                if (Cikacak.Arac_plaka == null)
                {
                    labelCikisTarih.Text = "-";
                    button1.Enabled = false;
                }
               



                if (Cikacak.Arac_giris!=null)
                    {

                    if (Cikacak.Arac_icerde.Trim() == "0")
                    {
                        label1.Text = "Araç Otopark Dışarısında";
                        button1.Enabled = false;
                        label5.Text = "0 TL";
                        label9.Text = "-";
                    }
                    else
                    {
                       
                        label9.Text = cikacak.Arac_parkyeri;
                        CikisHesabi();
                        label8.Text = atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_ad;
                        label1.Text = "";
                        button1.Enabled = true;
                        DateTime giris = DateTime.Parse(Cikacak.Arac_giris);
                        DateTime cikis = DateTime.Now;
                        saat = ((cikis - giris).Days * 24 + (cikis - giris).Hours);
                        labelCikisTarih.Text = DateTime.Now.ToString();
                        Debug.WriteLine(Cikacak.Arac_tur);
                        if (ftController.fiyatTarifesiById(cikacak.Arac_tur.FiyatTarifesi_id) != null)
                        {
                            labelAractur.Text = cikacak.Arac_tur.FiyatTarifesi_uzunAd;
                            // FiyatTarifesi ft = new FiyatTarifesi(Cikacak.Arac_tur.Trim());
                            label5.Text = ftController.fiyatHesapla(saat).ToString() + " TL";
                        }
                    }
                }


                if (Cikacak.Arac_giris!="")
                {
                    labelGirisTarihi.Text = Cikacak.Arac_giris;
                }
                if (Cikacak.Arac_sahip != "")
                {
                    if (Cikacak.Arac_sahip!="-1")
                    {
                        labelAracSahip.Text = Cikacak.Arac_sahip;
                    }
                    else
                    {
                        labelAracSahip.Text = "Kayıtlı Değil";
                    }
                }

              


              


               
                /*     sahip = sahip.aboneIcerdenGetir(Cikacak.Arac_sahip);
                     if (sahip.Abone_ozeldurum.ToLower().Contains("personel"))
                     {
                         label5.Text=("Personel Ücretsiz");
                     }*/


                try
                {

                }
                catch (Exception)
            {

                throw;
            }
            }
        }

        private void labelAracSahip_Click(object sender, EventArgs e)
        {

        }

        private void labelKalanSure_Click(object sender, EventArgs e)
        {

        }
    }
}
