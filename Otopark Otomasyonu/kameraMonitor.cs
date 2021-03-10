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
using AForge.Video;  //Referansları ekliyoruz
using AForge.Video.DirectShow; //Referansları ekliyoruz
using System.Drawing.Imaging;
using System.Threading;
using AForge.Vision.Motion;

namespace Otopark_Otomasyonu
{
    public partial class kameraMonitor : Form
    {
        JPEGStream kamera1Video;
        JPEGStream kamera2Video;
        AsyncVideoSource asenkronKamera1;
        public kameraMonitor()
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
           /*
            float motion = detector.ProcessFrame(bmp); // running on worker thread

            float motion2 = motion * 100;
            this.Invoke((MethodInvoker)delegate
            {
                label1.Text = motion2.ToString(); // runs on UI thread

                if (motion2 > 0.80)
                {
                    label1.Text = "0";
                }
                else
                {
                    label1.Text = "1";
                }
            });*/
            try
            {

                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                pictureBoxKamera1.Image = bmp;


               

                // ring alarm or do somethng else



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

        public string processImageFileGiris(string fileName)
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
                        listBox1.Items.Clear();
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

                            listBox1.Items.Add(plate.Characters);

                        }


                    }

                    if (images.Any())
                    {

                        pictureBox1.Image = combineImages(images);
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
        private void kameraMonitor_Load(object sender, EventArgs e)

        {
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



            labelFiligran1.Parent = pictureBoxKamera1;
            labelFiligran2.Parent = pictureboxKamera2;
            labelFiligran1.Location = new Point(0, pictureBoxKamera1.Height-40);
            labelFiligran2.Location = new Point(0, pictureBoxKamera1.Height - 40);

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

                    throw;
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
                        while (backgroundWorker1.IsBusy)
                        {
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(1000);
                        }
                        backgroundWorker1.RunWorkerAsync(argument: dosyayolu);
                        //processImageFile("C:/plaka/" + rastgele + ".png");
                    }
                }
            }

        }

     

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            kameraEkle kameraEkleForm = new kameraEkle();
            kameraEkleForm.Show();
        }
        Kamera[] aktifkameralar = new Kamera[2];
        IVideoSource videoSource;
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            try
            {
                if (kamera1Video != null)
                    kamera1Video.Stop();
                
                if (kamera2Video != null)
                    kamera2Video.Stop();
              
                labelFiligran1.Text = "";
                labelFiligran2.Text = "";
                kamera1Video = null;
                kamera2Video = null;
            }
            catch
            {

            }

            try
            {
                
                aktifkameralar = kamera1.kameraGetirAktif();
                if (aktifkameralar[0] != null) { 
                  
                        kamera1 = (Kamera)aktifkameralar[0];
                        kameraGroup1.Text = kamera1.k_adi;


                   kamera1Video = new JPEGStream(kamera1.k_url.ToString());
                //   videoSource = new JPEGStream(kamera1.k_url.ToString());
                   // videoSourcePlayer1.VideoSource = videoSource;
                    labelFiligran1.Text = aktifkameralar[0].k_filigran;
                  //  videoSourcePlayer1.NewFrame += (this.videoSourcePlayer1_NewFrame);
                  //  videoSourcePlayer1.Start();
                     kamera1Video.NewFrame += kamera1Video_NewFrame;
                   kamera1Video.Start();
                      timerKamera1.Start();
                }
                //MessageBox.Show("zz");
                if (aktifkameralar[1] != null) { 
                    
                        
                    kamera2 = (Kamera)aktifkameralar[1];
                    kameraGroup2.Text = kamera2.k_adi;
                    kamera2Video = new JPEGStream(kamera2.k_url.ToString());
                    labelFiligran2.Text = aktifkameralar[1].k_filigran;
                    kamera2Video.NewFrame += kamera2Video_NewFrame;
                    timerKamera2.Start();
                    kamera2Video.Start();
                }
                

            }
            catch
            {

                MessageBox.Show("");
            }
          
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            kamera1kilit = 0;
            lbxPlates.Items.Clear();
            textBox1.Text = "";
        }

        private void pictureBoxKamera1_Click(object sender, EventArgs e)
        {

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
                        while (backgroundWorker1.IsBusy)
                        {
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(1000);
                        }
                        backgroundWorker2.RunWorkerAsync(argument: dosyayolu);
                    }
                }
            }
           
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String filename = e.Argument.ToString();
            processImageFileGiris(filename);
        }

        private void lbxPlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                textBox1.Text = lbxPlates.Items[lbxPlates.SelectedIndex].ToString();
            }
            catch { }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
