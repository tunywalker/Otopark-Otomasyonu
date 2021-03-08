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

namespace Otopark_Otomasyonu
{
    public partial class kameraMonitor : Form
    {
        MJPEGStream kamera1Video;
        JPEGStream kamera2Video;
        AsyncVideoSource asenkronKamera1;
        public kameraMonitor()
        {

          
            InitializeComponent();
           

        }
        Kamera kamera1 = new Kamera();
        Kamera kamera2 = new Kamera();

       
        void kamera1Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
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

        public string processImageFile(string fileName)
        {


            var region = "eu";
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");

            using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
            {
               

                var results = alpr.Recognize(fileName);

                var images = new List<Image>(results.Plates.Count());
                //    var i = 1;
               if (results.Plates.Count() > 0)
                {
                    lbxPlates.Items.Clear();
                }
                foreach (var result in results.Plates)
                {
                    var rect = boundingRectangle(result.PlatePoints);
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                   // resimKutusu.Image = cropImage2(img);
                    img.Dispose();
                    images.Add(cropped);

                    foreach (var plate in result.TopNPlates)
                    {
                        
                        lbxPlates.Items.Add(plate.Characters);
                        break;
                    }

                }

                if (images.Any())
                {

                       picLicensePlate.Image = combineImages(images); 
                }

            }

            return "";
        }
       
        int timer = 0;
        Random rnd = new Random();
        int rastgele;
        private void kameraMonitor_Load(object sender, EventArgs e)

        {
            labelFiligran1.Parent = pictureBoxKamera1;
            labelFiligran2.Parent = pictureboxKamera2;
            labelFiligran1.Location = new Point(0, pictureBoxKamera1.Height-40);
            labelFiligran2.Location = new Point(0, pictureBoxKamera1.Height - 40);

            timerLoad.Interval = 5000;
            timerLoad.Start();
           
            timerKamera1.Interval = 5000;
            timerKamera2.Interval = 5000;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
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

                    processImageFile("C:/plaka/" + rastgele + ".png");
                }
            }
        }

     

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            kameraEkle kameraEkleForm = new kameraEkle();
            kameraEkleForm.Show();
        }
        Kamera[] aktifkameralar = new Kamera[2];
        
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
                      

                    kamera1Video = new MJPEGStream(kamera1.k_url.ToString());
                    
                    labelFiligran1.Text = aktifkameralar[0].k_filigran;
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
            kamera1.kameraGetirAktif();
        }

        private void pictureBoxKamera1_Click(object sender, EventArgs e)
        {

        }

        private void timerKamera2_Tick(object sender, EventArgs e)
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

                    processImageFile("C:/plaka/" + rastgele + "x.png");
                }
            }
        }
    }
}
