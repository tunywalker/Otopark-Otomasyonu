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
        JPEGStream kamera1Video;
        MJPEGStream kamera2Video;
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
                picOriginal.Image = bmp;
            }
            catch { }
        }
        void kamera2Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                pictureBox1.Image = bmp;
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
                lbxPlates.Items.Clear();

                var results = alpr.Recognize(fileName);

                var images = new List<Image>(results.Plates.Count());
                //    var i = 1;
                if (results.Plates.Count() == 0)
                {
                    picOriginal.ImageLocation = fileName;
                    picOriginal.Load();
                }
                foreach (var result in results.Plates)
                {
                    var rect = boundingRectangle(result.PlatePoints);
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                    picOriginal.Image = cropImage2(img);
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

            timerLoad.Interval = 5000;
            timerLoad.Start();
           
            timerKamera1.Interval = 3000;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            rastgele = rnd.Next(1, 10000);
            if (true)
            {


                if (picOriginal.Image != null)
                {
                    if (timer % 10 == 0)
                    {
                        lbxPlates.Items.Clear();
                    }

                    Bitmap varBmp = new Bitmap(picOriginal.Image);
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        /*    if (tabControl1.SelectedIndex==1)
            {
                tabControl1.SelectedIndex = 0;
               
            }*/
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kameraMenüsüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

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
               
                kamera1Video.NewFrame += kamera1Video_NewFrame;

                kamera1Video.Start();
                    timerKamera1.Start();
                }
                //MessageBox.Show("zz");
                if (aktifkameralar[1]!=null)
                {
                    kamera2 = (Kamera)aktifkameralar[1];
                    kameraGroup2.Text = kamera2.k_adi;
                    kamera2Video = new MJPEGStream(kamera2.k_url.ToString());

                    kamera2Video.NewFrame += kamera2Video_NewFrame;

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
    }
}
