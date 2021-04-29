using Otopark_Otomasyonu.Controller;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            aracPlaka = textPlaka.Text;
         cikis=   Cikacak.cikisYap(textPlaka.Text);
            DialogResult = DialogResult.OK;
        }
        FiyatTarifesiController ftController = new FiyatTarifesiController();
        private void textPlaka_TextChanged(object sender, EventArgs e)
        {

            label1.Text = "";
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
                    }
                    else
                    {

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
                    labelAracSahip.Text = Cikacak.Arac_sahip;
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
    }
}
