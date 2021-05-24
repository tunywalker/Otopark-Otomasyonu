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

namespace Otopark_Otomasyonu.View
{
    public partial class formParkYerleri : Form
    {
        public formParkYerleri()
        {
            InitializeComponent();
        }
        Otopark oto1 = new Otopark();
        public void bildirimYazdir(String Tur, String Metin)
        {
            PopupNotifier popup = new PopupNotifier();
            Bitmap Icon = null;
            String Baslik = "";
            switch (Tur)
            {
                case "Uyarı":
                    Baslik = "Hata Bildirimi";
                    Icon = Properties.Resources.uyari2; //icon from resources

                    break;
                case "Giriş":
                    Baslik = "Giriş Bildirimi";
                    Icon = Properties.Resources.basari; //icon from resources
                    break;
                case "Çıkış":
                    Baslik = "Çıkış Bildirimi";
                    Icon = Properties.Resources.basarisiz; //icon from resources
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
        private void formParkYerleri_Load(object sender, EventArgs e)
        {
            Buttoncek();
          
           // Control ctn = this.Controls[name];

          
        }
        public void girisİslemleri(bool kayitDurumu, String plakaNo)
        {
          

            if (kayitDurumu)
            {
                bildirimYazdir("Giriş", " '" + plakaNo + "' nolu plaka için giriş onayı verildi.");
               
            }
            else
            {
                if (plakaNo.Trim() == "")
                {
                    bildirimYazdir("Uyarı", "Plaka numarası boş olamaz.");
                }
                else
                    bildirimYazdir("Uyarı", " '" + plakaNo + "' nolu araç zaten içeride.");
            }
        }
        public void Buttoncek()
        {

            List<string> parkAlani = oto1.parkAlaniOlustur();
            for (int i = 0; i < 100; i++)
            {
                string butonAdi = "Button" + (i + 1).ToString();
                Control ctn = this.Controls[butonAdi];
                Arac a1 = new Arac();
                a1 = a1.aracByParkyeri(parkAlani.ElementAt(i));
                ctn.Text = parkAlani.ElementAt(i);
                ctn.Click -= new EventHandler(buttonZ_Click);
                ctn.Click += new EventHandler(buttonZ_Click);
                ctn.BackColor = Color.LimeGreen;
                if (a1.Arac_plaka != "")
                {
                    ctn.BackColor = Color.Red;
                    ctn.Text = ctn.Text +
                        ":\n" + a1.Arac_plaka;
                    if (a1.Arac_icerde == "0")
                    {
                        ctn.BackColor = Color.Orange;
                    }
                }
                foreach (Control item in this.Controls)
                {
                    item.Enabled = true;      // = true: enable all, = false: disable all
                }
            }

        }
        public void cikisİslemleri(bool kayitDurumu, String plakaNo)
        {


            if (kayitDurumu)
            {
                bildirimYazdir("Çıkış", " '" + plakaNo + "' nolu plaka için çıkış onayı verildi.");

            }
            else
            {
                if (plakaNo.Trim() == "")
                {
                    bildirimYazdir("Uyarı", "Plaka numarası boş olamaz.");
                }
                else
                    bildirimYazdir("Uyarı", " '" + plakaNo + "' nolu plaka için çıkış başarısız.");
            }
        }
        private void buttonZ_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
           
            if (button.BackColor== Color.Orange)
            {
                formAracGiris aracGirisForm = new formAracGiris()
                {
                    plaka = button.Text.Split(':')[1].ToString().Trim(),
                    bosParkyerleri = oto1.bosParkyerleri()
                    //plakaResim = (Bitmap)picLicensePlate.Image,
                    //   bosParkyerleri = otopark1.bosParkyerleri()

                };
                if (aracGirisForm.ShowDialog() == DialogResult.OK)
                {
                    foreach(Control item in this.Controls)
{
                        item.Enabled = false;      // = true: enable all, = false: disable all
                    }
                    girisİslemleri(aracGirisForm.kayitDurumu, aracGirisForm.plakaNo);
               //     button.BackColor = Color.Black;
                    Buttoncek();

                }
            }
           
           
            else if (button.BackColor == Color.LimeGreen)
            {
                formAracGiris aracGirisForm = new formAracGiris()
                {
                    plaka = "",
                    bosParkyerleri = oto1.bosParkyerleri(),
                    parkGelen = button.Text.Trim()
                    //plakaResim = (Bitmap)picLicensePlate.Image,
                    //   bosParkyerleri = otopark1.bosParkyerleri()

                };
                if (aracGirisForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control item in this.Controls)
                    {
                        item.Enabled = false;      // = true: enable all, = false: disable all
                    }
                    girisİslemleri(aracGirisForm.kayitDurumu, aracGirisForm.plakaNo);
                  //  button.BackColor = Color.Black;
                    Buttoncek();

                }
                
            }
            else if (button.BackColor == Color.Red)
            {
                AracCikis aracCikisForm = new AracCikis()
                {
                    AracPlaka = button.Text.Split(':')[1].ToString().Trim(),
                    //     plakaResim = (Bitmap)pictureboxKamera2.Image

                };
                if (aracCikisForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control item in this.Controls)
                    {
                        item.Enabled = false;      // = true: enable all, = false: disable all
                    }
                    //   girisİslemleri(aracGirisForm.kayitDurumu, aracGirisForm.plakaNo);
                    cikisİslemleri(aracCikisForm.cikisDurumu, aracCikisForm.AracPlaka);
                //    button.BackColor = Color.Black;
                    Buttoncek();
                }
            }

        }
    }
}
