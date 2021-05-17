using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using openalprnet;
using AForge.Video; 
using AForge.Video.DirectShow; 
using System.Drawing.Imaging;
using System.Threading;
using AForge.Vision.Motion;
using Tulpep.NotificationWindow;
using System.Net;
using System.Linq;
using Otopark_Otomasyonu.View;
using Otopark_Otomasyonu.Controller;

namespace Otopark_Otomasyonu
{
    public partial class formKameraMonitor : Form
    {
        JPEGStream kamera1Video;
        JPEGStream kamera2Video;
        AsyncVideoSource asenkronKamera1;
        public formKameraMonitor()
        {

            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
           

        }
        Kamera kamera1 = new Kamera();
        Kamera kamera2 = new Kamera();
        FilterInfoCollection fic;
       // MotionDetector motionDetector;
        
        void kamera1Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
          
            try {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                pictureBoxKamera1.Image = bmp;
            }
            catch { }


          
        }
        void kamera2Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                pictureboxKamera2.Image = bmp;
            }
            catch { }
        }

        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        public Rectangle boundingRectangle(List<Point> points)
        {
            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);
            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
        private static Image cropImage2(Image img)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage;
        }

        public static Bitmap combineImages(List<Image> images)
        {

            Bitmap finalImage = null;

            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }

                finalImage = new Bitmap(width, height);

                using (var g = Graphics.FromImage(finalImage))
                {

                    g.Clear(Color.Black);

                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();


                throw ex;
            }
            finally
            {

                foreach (var image in images)
                {
                    image.Dispose();

                }
            }
        }

        
        public string processImageFileCikis(string fileName)
        {


            var region = "eu";
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
            try
            {
                using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
                {


                    var results = alpr.Recognize(fileName);

                    var images = new List<Image>(results.Plates.Count());
                    //    var i = 1;
                    if (results.Plates.Count() > 0)
                    {
                        
                        kamera2kilit = 1;
                        lbxPlatesCikis.Items.Clear();
                    }
                    foreach (var result in results.Plates)
                    {
                        var rect = boundingRectangle(result.PlatePoints);
                        var img = Image.FromFile(fileName);
                        var cropped = cropImage(img, rect);
                        //resimKutusu.Image = cropImage2(img);
                        img.Dispose();
                        images.Add(cropped);

                        foreach (var plate in result.TopNPlates)
                        {

                            lbxPlatesCikis.Items.Add(plate.Characters);

                        }


                    }

                    if (images.Any())
                    {

                        picLicensePlateCikis.Image = combineImages(images);
                    }

                }

                return "";
            }
            catch
            {
                return "";
            }
        }

        int timer = 0;
        Random rnd = new Random();
        int rastgele;
        MotionDetector detector;
        public void butonResimAyarla(Button btn)
        {

            btn.AutoSize = false;

            Image image = new Bitmap(20, 20);
            using (Graphics g = Graphics.FromImage(image))
            {
                g.DrawImage(btn.Image, 0, 0, 20, 20);
            }
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.Image = image;
        }

        public void kapasiteHesapla()
        {

        }
        int kapasite;
        Otopark otopark1 = new Otopark();
        public void istatistikGuncelle()
        {

            istatistik istatistikler = new istatistik();
            label19.Text = istatistikler.aboneSayisi();
            label20.Text = istatistikler.icerdekiAracSayisi();
            label21.Text = istatistikler.aracSayisi();
        }
        private void kameraMonitor_Load(object sender, EventArgs e)

        {
            istatistikGuncelle();
            kapasite   = 100;
           // FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            label1.Text = "";

            /* IMotionDetector motionDetector =  new TwoFramesDifferenceDetector() ;
             // create instance of motion processing algorithm
             BlobCountingObjectsProcessing motionProcessing = new BlobCountingObjectsProcessing();
             // create motion detector
              detector = new MotionDetector(motionDetector, motionProcessing);*/
            butonResimAyarla(button2);
            butonResimAyarla(butonGirisReddet);
            butonResimAyarla(sonraKaydet);
            butonResimAyarla(buttonTekrarTani);
            butonResimAyarla(buttonTekrarTani2);
            butonResimAyarla(button3);



            labelFiligran1.Parent = pictureBoxKamera1;
            labelFiligran2.Parent = pictureboxKamera2;
            labelFiligran1.Location = new Point(0, pictureBoxKamera1.Height-40);
            labelFiligran2.Location = new Point(0, pictureBoxKamera1.Height - 40);
            kamera1LoadingLabel.Parent = pictureBoxKamera1;
            kamera2LoadingLabel.Parent = pictureboxKamera2;


            timerLoad.Interval = 5000;
            timerLoad.Start();
           
            timerKamera1.Interval = 5000;
           timerKamera2.Interval = 5000;
           
        }
        int kamera1kilit=0, kamera2kilit=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kamera1kilit != 1)
            {
                try
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(@"C:\plaka\");

                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                }
                catch (Exception)
                {

                  //  throw;
                }
                timer++;
                rastgele = rnd.Next(1, 10000);
                if (true)
                {


                    if (pictureBoxKamera1.Image != null)
                    {
                        if (timer % 10 == 0)
                        {
                            lbxPlates.Items.Clear();
                        }

                        Bitmap varBmp = new Bitmap(pictureBoxKamera1.Image);
                        Bitmap newBitmap = new Bitmap(varBmp);
                        //processImageFile("C:/plaka/SavedImage.jpg");
                        varBmp.Save(@"C:\plaka\" + rastgele + ".png", ImageFormat.Png);
                        //Now Dispose to free the memory
                        varBmp.Dispose();
                        varBmp = null;
                        String dosyayolu = "C:/plaka/" + rastgele + ".png";
                      
                        kamera1Thread = new Thread(() => processImageFileGiris(dosyayolu));
                        kamera1Thread.IsBackground = true;
                        kamera1Thread.Start();
                    }
                }
            }

        }



        Thread urlCheck;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            formKameraEkle kameraEkleForm = new formKameraEkle();
            kameraEkleForm.Show();
           
        }
        Kamera[] aktifkameralar = new Kamera[2];
        
        private void timerLoad_Tick(object sender, EventArgs e)
        {
         
            
            
            // MessageBox.Show(otopark1.bosParkyerleri().ElementAt(0));
            toolStripLabel2.Text = otopark1.dolulukOrani(kapasite)+"/"+kapasite;
            if (Convert.ToInt16(otopark1.dolulukOrani(kapasite)) >= kapasite)
                kameraGroup1.Enabled = false;
            if (Convert.ToInt16(otopark1.dolulukOrani(kapasite)) >= kapasite)
                kameraGroup1.Enabled = true;

            try
            {
                if (kamera1Video != null)
                    kamera1Video.Stop();
                
                if (kamera2Video != null)
                    kamera2Video.Stop();
              
                labelFiligran1.Text = "zzz";
                labelFiligran2.Text = "";
                kamera1Video = null;
                kamera2Video = null;
            }
            catch
            {
                MessageBox.Show("hata");
            }

            try
            {
                
                aktifkameralar = kamera1.kameraGetirAktif();
                if(aktifkameralar[0].k_lokasyon == "1" && aktifkameralar[1].k_lokasyon == "0")
                {
                    Kamera tempKamera = new Kamera();
                    tempKamera = aktifkameralar[0];
                    aktifkameralar[0] = aktifkameralar[1];
                    aktifkameralar[1] = tempKamera;

                }
               
                if (aktifkameralar[0] != null) { 
                  
                        kamera1 = (Kamera)aktifkameralar[0];
                        kameraGroup1.Text = kamera1.k_adi;
                   

                    kamera1Video = new JPEGStream(kamera1.k_url.ToString());
                   
                    labelFiligran1.Text = aktifkameralar[0].k_filigran;
                  
                     kamera1Video.NewFrame += kamera1Video_NewFrame;
                    kamera1LoadingLabel.Text = "";

                    if (CheckURLValid(aktifkameralar[0].k_url))
                    {
                        labelFiligran1.Visible = true;
                        kamera1Video.Start();
                        timerKamera1.Start();
                    }
                    else
                    {

                        pictureBoxKamera1.Image = Properties.Resources.connecting;
                        labelFiligran1.Visible = false;
                        kamera1LoadingLabel.Text = "'"+aktifkameralar[0].k_adi+"' isimli kameraya bağlanılıyor.";
                    }
                }
             
                if (aktifkameralar[1] != null) { 
                  
                        
                    kamera2 = (Kamera)aktifkameralar[1];
                    kameraGroup2.Text = kamera2.k_adi;
                    kamera2Video = new JPEGStream(kamera2.k_url.ToString());
                    labelFiligran2.Text = aktifkameralar[1].k_filigran;
                    kamera2Video.NewFrame += kamera2Video_NewFrame;
                    kamera2LoadingLabel.Text = "";
                    if (CheckURLValid(aktifkameralar[1].k_url))
                    {
                        //   MessageBox.Show("");
                        labelFiligran2.Visible = true;
                        kamera2Video.Start();
                        timerKamera2.Start();
                    }
                    else
                    {
                        pictureboxKamera2.Image = Properties.Resources.connecting;
                        labelFiligran2.Visible = false;
                        kamera2LoadingLabel.Text = "'" + aktifkameralar[1].k_adi + "' isimli kameraya bağlanılıyor.";
                    }
                 
                }


            }
            catch
            {

                
            }
          
          
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            picLicensePlate.Image = null;
            kamera1kilit = 0;
            lbxPlates.Items.Clear();
            textPlaka.Text = "";
        }

        private void pictureBoxKamera1_Click(object sender, EventArgs e)
        {

        }
        public static bool CheckURLValid(string source)
        {
            bool value=false ; // Used to store the return value
            var thread = new Thread(
              () =>
              {
                  HttpWebRequest request = (HttpWebRequest)WebRequest.Create(source);
                  request.Timeout = 100;
                  request.Method = "HEAD"; // As per Lasse's comment
                  try
                  {
                      using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                      {
                          value= response.StatusCode == HttpStatusCode.OK;
                      }

                  }
                  catch (WebException)
                  {
                      value= false;
                  }
                  
              });
            thread.Start();
            thread.Join();
            return value;
        }
        private void timerKamera2_Tick(object sender, EventArgs e)
        {
            if (kamera2kilit!=1)
            {
                try
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(@"C:\plaka\");

                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
               }
                catch (Exception)
                {

                    throw;
                }
                timer++;
                rastgele = rnd.Next(1, 10000);
                if (true)
                {


                    if (pictureboxKamera2.Image != null)
                    {
                        if (timer % 10 == 0)
                        {
                            lbxPlates.Items.Clear();
                        }

                        Bitmap varBmp = new Bitmap(pictureboxKamera2.Image);
                        Bitmap newBitmap = new Bitmap(varBmp);
                        //processImageFile("C:/plaka/SavedImage.jpg");
                        varBmp.Save(@"C:\plaka\" + rastgele + "x.png", ImageFormat.Png);
                        //Now Dispose to free the memory
                        varBmp.Dispose();
                        varBmp = null;
                        String dosyayolu = "C:/plaka/" + rastgele + "x.png";
                        kamera2Thread = new Thread(() => processImageFileCikis(dosyayolu));
                        kamera2Thread.IsBackground = true;
                        kamera2Thread.Start();
                    }
                }
            }
           
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {

        }
        Thread kamera1Thread,kamera2Thread;
        private string processImageFileGiris(String fileName)
        {
            var region = "eu";
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
            try
            {
                using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
                {


                    var results = alpr.Recognize(fileName);

                    var images = new List<Image>(results.Plates.Count());
                    //    var i = 1;
                    if (results.Plates.Count() > 0)
                    {
                        kamera1kilit = 1;

                        lbxPlates.Items.Clear();
                    }
                    foreach (var result in results.Plates)
                    {
                        var rect = boundingRectangle(result.PlatePoints);
                        var img = Image.FromFile(fileName);
                        var cropped = cropImage(img, rect);
                        //resimKutusu.Image = cropImage2(img);
                        img.Dispose();
                        images.Add(cropped);

                        foreach (var plate in result.TopNPlates)
                        {

                            lbxPlates.Items.Add(plate.Characters);

                        }


                    }

                    if (images.Any())
                    {

                        picLicensePlate.Image = combineImages(images);
                    }

                }

                return "";
            }
            catch
            {
                return "";
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String filename = e.Argument.ToString();
           
            
            /*  String filename = e.Argument.ToString();
              processImageFileGiris(filename);*/
        }

        private void lbxPlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                textPlaka.Text = lbxPlates.Items[lbxPlates.SelectedIndex].ToString();
            }
            catch { }
           
        }

       public void bildirimYazdir(String Tur, String Metin)
        {
            PopupNotifier popup = new PopupNotifier();
            Bitmap Icon=null;
            String Baslik="";
            switch (Tur)
            {
                case "Uyarı":
                   Baslik= "Hata Bildirimi";
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
        public void girisTemizle()
        {
            picLicensePlate.Image = null;
            lbxPlates.Items.Clear();
            textPlaka.Text = "";
           // groupBox2.Visible = false;
        }
        public void girisİslemleri(bool kayitDurumu, String plakaNo)
        {
            picLicensePlate.Image = null;
            kamera1kilit = 0;
            lbxPlates.Items.Clear();
            textPlaka.Text = "";

            if (kayitDurumu)
            {
                bildirimYazdir("Giriş", " '" + plakaNo + "' nolu plaka için giriş onayı verildi.");
                girisTemizle();
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
        public void cikisİslemleri(bool kayitDurumu, String plakaNo)
        {

            kamera2kilit = 0;
            picLicensePlateCikis.Image = null;
            textPlkaCikis.Text = null;
            lbxPlatesCikis.Items.Clear();
            if (kayitDurumu)
            {
                bildirimYazdir("Çıkış", " '" + plakaNo + "' nolu plaka için çıkış onayı verildi.");
                girisTemizle();
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
        private void button2_Click(object sender, EventArgs e)
        {
            formAracGiris aracGirisForm = new formAracGiris() {
                plaka = textPlaka.Text, plakaResim = (Bitmap)picLicensePlate.Image,
                bosParkyerleri = otopark1.bosParkyerleri()
                
            };
            if (aracGirisForm.ShowDialog() == DialogResult.OK)
            {
                girisİslemleri(aracGirisForm.kayitDurumu, aracGirisForm.plakaNo);

            }




        }
        FiyatTarifesiController ftController = new FiyatTarifesiController();
        private void sonraKaydet_Click(object sender, EventArgs e)
        {
            if (picLicensePlate.Image==null)
            {
                picLicensePlate.Image = Properties.Resources.image;
            }
           
            Arac A1 = new Arac(textPlaka.Text,ftController.fiyatTarifesiById(-1), DateTime.Now.ToString(), "1", (Bitmap)picLicensePlate.Image,otopark1.randomParkYeriOlustur(), "-1","Üyeliksiz Giriş");
            girisİslemleri(A1.aracKaydet(A1), textPlaka.Text);
            
        }

        private void butonGirisReddet_Click(object sender, EventArgs e)
        {
            girisTemizle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textPlkaCikis.Text = lbxPlatesCikis.Items[lbxPlatesCikis.SelectedIndex].ToString();
            }
            catch { }
        }
      
        
        private void button3_Click(object sender, EventArgs e)
        {
            AracCikis aracCikisForm = new AracCikis()
            {
                AracPlaka = textPlkaCikis.Text,
           //     plakaResim = (Bitmap)pictureboxKamera2.Image

            };
            if (aracCikisForm.ShowDialog() == DialogResult.OK)
            {
                //   girisİslemleri(aracGirisForm.kayitDurumu, aracGirisForm.plakaNo);
                cikisİslemleri(aracCikisForm.cikisDurumu, aracCikisForm.AracPlaka);

            }
        }

        private void pictureboxKamera2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            picLicensePlateCikis.Image = null;
            textPlkaCikis.Text = null;
            lbxPlatesCikis.Items.Clear();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            formYonetimPaneli YonetimPaneliForm = new formYonetimPaneli()
            { 

            };
            YonetimPaneliForm.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formAboneler aboneForm = new formAboneler() {
                Otopark1 = this.otopark1

            };
            aboneForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            formAboneAraclar aboneAracForm = new formAboneAraclar()
            {
                Kimlik = "icerdeki",
                //     plakaResim = (Bitmap)pictureboxKamera2.Image

            };
            aboneAracForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            kayitlar kayitlarForm = new kayitlar();
            kayitlarForm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureboxKamera2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            String filename = e.Argument.ToString();
           
            processImageFileCikis(filename);
        }
    }
}
