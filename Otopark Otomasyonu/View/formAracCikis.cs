using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            aracPlaka = textPlaka.Text;
         cikis=   Cikacak.cikisYap(textPlaka.Text);
            DialogResult = DialogResult.OK;
        }

        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
            if (textPlaka.Text.Length>=5)
            {

           
            try
                {
                    int saat = 0;
                    Cikacak = Cikacak.aracIcerdenGetir(textPlaka.Text);
                    Abone sahip = new Abone();
                   
                    if (Cikacak.Arac_plaka == null)
                             labelCikisTarih.Text = "-";
                   
                 
                    
                      
                    if (Cikacak.Arac_giris!=null)
                    {
                        DateTime giris = DateTime.Parse(Cikacak.Arac_giris);
                        DateTime cikis = DateTime.Now;
                        saat = ((cikis - giris).Days * 24 + (cikis - giris).Hours);
                        labelCikisTarih.Text = DateTime.Now.ToString();
                    }
                  
                   
                  
                labelGirisTarihi.Text = Cikacak.Arac_giris;
                   
                labelAracSahip.Text = Cikacak.Arac_sahip;
                labelAractur.Text = Cikacak.Arac_tur;
                    if (Cikacak.Arac_tur != null)
                    {
                     //   FiyatTarifesi ft = new FiyatTarifesi(Cikacak.Arac_tur.Trim());
                        //label5.Text = ft.fiyatHesapla(saat).ToString() + " TL";
                    }
               /*     sahip = sahip.aboneIcerdenGetir(Cikacak.Arac_sahip);
                    if (sahip.Abone_ozeldurum.ToLower().Contains("personel"))
                    {
                        label5.Text=("Personel Ücretsiz");
                    }*/
                }
                   
            catch (Exception)
            {

                throw;
            }
            }
        }
    }
}
