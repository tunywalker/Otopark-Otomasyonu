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

namespace Otopark_Otomasyonu
{
    public partial class kameraMonitor : Form
    {
        JPEGStream stream;
        public kameraMonitor()
        {
            stream = new JPEGStream("http://192.168.1.108:8080/photo.jpg");
            //http://192.168.1.5:8080/shot.jpg?rnd=660075

            InitializeComponent();
            stream.NewFrame += stream_NewFrame;
           
        }
        Kamera kamera1 = new Kamera();
        Kamera kamera2 = new Kamera();

        void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                picOriginal.Image = bmp;
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

                    //   picLicensePlate.Image = combineImages(images); PLakayı kes
                }

            }

            return "";
        }
       
        int timer = 0;
        Random rnd = new Random();
        int rastgele;
        private void kameraMonitor_Load(object sender, EventArgs e)
        {
         stream.Start();
            timerKamera1.Interval = 3000;
            timerKamera1.Start();
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

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            kamera1=kamera1.kameraGetirAktif();
        }
    }
}
