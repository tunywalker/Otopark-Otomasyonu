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
            label1.Text = "";
            textPlaka.Text = AracPlaka;
            
        }

        public int sureHesapla(int gunSayisi, string GirisTarihi)
        {

            DateTime giris = Convert.ToDateTime(GirisTarihi);
            DateTime simdi = Convert.ToDateTime(DateTime.Now);
            TimeSpan sonuc = simdi-giris;
            int sure = gunSayisi * 60*24;
            int gecensure = sonuc.Days * 24 * 60+sonuc.Hours*60+sonuc.Minutes;
            int sonucc = sure - gecensure+1;
           labelAracSahip.Text="Kalan"+ (sure-gecensure).ToString();
            if (sonucc>1)
            {
                return sonucc-1;
            }
            else
            {
                return sonucc;
            }
            
        }

        public int CikisHesabi()
        {
           
            if (cikacak.Abone_Tur.AboneTurleri_id == -1)
            {
                cikisdurum = 0; 
            }
            else
            {
            int sonuc=    sureHesapla(Convert.ToInt32(atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_sure), cikacak.Arac_giris);
                if (sonuc<0)
                {
                    sonuc = Math.Abs(sonuc);
                    DateTime giris = DateTime.Parse(Cikacak.Arac_giris);
                    DateTime cikis = DateTime.Now;
                    labelKalanSure.Text = "Abonelik Süresi Doldu";
                //  int  saat = ((cikis - giris).Days * 24 + (cikis - giris).Hours);
                    if (ftController.fiyatTarifesiById(cikacak.Arac_tur.FiyatTarifesi_id) != null)
                    {
                        labelAractur.Text = cikacak.Arac_tur.FiyatTarifesi_uzunAd;
                        // FiyatTarifesi ft = new FiyatTarifesi(Cikacak.Arac_tur.Trim());
                        label14.Text = ftController.fiyatHesapla(sonuc/60).ToString() + " TL";
                        asim = Convert.ToInt32(ftController.fiyatHesapla(sonuc / 60).ToString());
                    }
                   
                  
                    //MessageBox.Show(sonuc.ToString());
                    int Gun = (sonuc / 60) / 24;
                    if (Gun >= 1)
                        sonuc = sonuc - (Gun * 24 * 60);
                    int saat2 = sonuc / 60;
                    if (saat2 >= 1)
                        sonuc = sonuc - (saat2 * 60);
                    int dakika = sonuc;
                    label18.Text = Gun.ToString() + " Gün " + saat2.ToString() + " Saat " + dakika.ToString() + " Dakika";
                    cikisdurum = 1;
                }
                else
                {
                    cikisdurum = 2;
                    asim = 0;
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
        int asim,cikisdurum=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            aracPlaka = textPlaka.Text;
         cikis=   Cikacak.cikisYap(textPlaka.Text,cikisdurum);
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
            labelAracSahip.Text = "-";
            labelAractur.Text = "-";
            label9.Text = "-";
            label8.Text = "-";
            labelGirisTarihi.Text = "-";
            labelCikisTarih.Text = "-";
            labelKalanSure.Text = "-";
            label15.Text = "-";
            label14.Text = "-";
            label5.Text = "-";
            
           // label17.Text = "-";
            label18.Text = "-";
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
                        labelGirisTarihi.Text = "-";
                        label9.Text = "-";
                    }
                    else
                    {
                        if (Cikacak.Arac_giris != "")
                        {
                            labelGirisTarihi.Text = Cikacak.Arac_giris;
                        }
                        label9.Text = cikacak.Arac_parkyeri;
                        CikisHesabi();
                        label8.Text = atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_ad+" - " + atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_sure +" Gün";
                        label15.Text = atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_fiyat +" TL";
                        
                        label5.Text = (Convert.ToInt32( atController.aboneTurleriById(Cikacak.Abone_Tur.AboneTurleri_id).AboneTurleri_fiyat)+asim).ToString()+ "TL";
                        label1.Text = "";
                        if (asim==0)
                        {
                            label5.Text = "0 TL";
                            label1.Text = "Abonelik Devam Ediyor";

                        }
                        button1.Enabled = true;
                        DateTime giris = DateTime.Parse(Cikacak.Arac_giris);
                        DateTime cikis = DateTime.Now;
                      //  MessageBox.Show(asim.ToString());
                        labelCikisTarih.Text = DateTime.Now.ToString();
                        Debug.WriteLine(Cikacak.Arac_tur);
                        if (ftController.fiyatTarifesiById(cikacak.Arac_tur.FiyatTarifesi_id) != null)
                        {
                            labelAractur.Text = cikacak.Arac_tur.FiyatTarifesi_uzunAd;
                            // FiyatTarifesi ft = new FiyatTarifesi(Cikacak.Arac_tur.Trim());
                           
                        }
                    }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
