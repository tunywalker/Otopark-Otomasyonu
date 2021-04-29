using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class formAboneAraclar : Form
    {
        public formAboneAraclar()
        {
            InitializeComponent();
        }
        public string Kimlik;

        private void formAboneAraclar_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(Kimlik);
            gridViewCek();
            
    }
        public void StretchLastColumn(DataGridView dataGridView)
        {
            var lastColIndex = dataGridView.Columns.Count - 1;
            var lastCol = dataGridView.Columns[lastColIndex];
            lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public byte[] Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            image = ScaleImage(image, 200, 100);
            return imageToByteArray(image);
        } 
    public byte[] imageToByteArray(System.Drawing.Image imageIn)
    {

        MemoryStream ms = new MemoryStream();
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        return ms.ToArray();
    }
        void AutoHeightGrid(DataGridView grid)
        {
            var proposedSize = grid.GetPreferredSize(new Size(0, 0));
            grid.Height = proposedSize.Height;
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public void gridViewCek()
            {

                string connectionString = "Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8";
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
                this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
          
                string query = "select * from araclar where arac_sahip= "+Kimlik; // set query to fetch data "Select * from  tabelname"; 
            if (Kimlik == "icerdeki")
            {
                this.Text = "İçerdeki Araçlar";
                 query = "select * from araclar where arac_icerde=1 "; // set query to fetch data "Select * from  tabelname"; 
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                 
                    
                    DataColumn column = ds.Tables[0].Columns.Add("Plaka Resim", typeof(byte[]));
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        try
                        {
                          //  MessageBox.Show(row["arac_plakaresim"].ToString());
                            row[column] = Base64ToImage(row["arac_plakaresim"].ToString());
                        }
                        catch
                        {


                            row[column] = null;
                        }
                    }
                    ds.Tables[0].Columns.Remove("arac_plakaresim");
                    ds.Tables[0].Columns.Remove("arac_cikis");
                 //   this.dataGridView1.Columns["arac_tur"].HeaderText = "Araç Türü";
                   
                    dataGridView1.DataSource = ds.Tables[0];


                    dataGridView1.Columns["arac_giris"].HeaderText = "İlk Giriş Tarihi";
                    dataGridView1.Columns["arac_sahip"].HeaderText = "Araç Sahibi";
                    dataGridView1.Columns["arac_icerde"].HeaderText = "İçerde Mi";
                    dataGridView1.Columns["arac_aciklama"].HeaderText = "Açıklama";
                    dataGridView1.Columns["arac_tur"].HeaderText = "Araç Türü";
                    dataGridView1.Columns["arac_plaka"].HeaderText = "Araç Plaka";
                    
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                }
            }
            }
        }
    
}
