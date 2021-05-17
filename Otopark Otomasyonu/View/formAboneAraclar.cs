using MySql.Data.MySqlClient;
using Otopark_Otomasyonu.Controller;
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
using Tulpep.NotificationWindow;

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
            String kimlikTemp = Kimlik;
            if (Kimlik.Trim() != "icerdeki")
            {
                comboBox1.Visible = false;
                label1.Visible = false;
            }
            // MessageBox.Show(Kimlik);
            comboBox1.SelectedIndex = 0;
            Kimlik = kimlikTemp;
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
        AboneTurleriController atController = new AboneTurleriController();
        FiyatTarifesiController ftController = new FiyatTarifesiController();
        string query;
        public void gridViewCek()
        {

            string connectionString = "Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8";
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            int uydu = 1;
            query = "select * from araclar where arac_sahip= " + Kimlik; // set query to fetch data "Select * from  tabelname"; 
            if (Kimlik == "İçerdeki" || Kimlik == "icerdeki")
            {
                uydu = 0;
                this.Text = "İçerdeki Araçlar";
                query = "select * from araclar where arac_icerde=1 "; // set query to fetch data "Select * from  tabelname"; 
            }
            if (Kimlik == "Tümü")
            {
                uydu = 0;
                this.Text = "İçerdeki Araçlar";
                query = "select * from araclar  "; // set query to fetch data "Select * from  tabelname"; 
            }
            if (Kimlik == "Dışardaki")
            {
                uydu = 0;
                this.Text = "İçerdeki Araçlar";
                query = "select * from araclar where arac_icerde=0  "; // set query to fetch data "Select * from  tabelname"; 
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
                    DataColumn column2 = ds.Tables[0].Columns.Add("Abonelik Türü", typeof(String));
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        try
                        {
                            //  MessageBox.Show(row["arac_plakaresim"].ToString());
                            row[column2] = atController.aboneTurleriById(Convert.ToInt32(row["arac_abonetur_id"].ToString())).AboneTurleri_ad;
                        }
                        catch
                        {


                            row[column2] = "-";
                        }
                    }
                    DataColumn column3 = ds.Tables[0].Columns.Add("Araç Türü", typeof(String));
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        try
                        {
                            //  MessageBox.Show(row["arac_plakaresim"].ToString());
                            row[column3] = ftController.fiyatTarifesiById(Convert.ToInt32(row["arac_tur"].ToString())).FiyatTarifesi_uzunAd;
                        }
                        catch
                        {


                            row[column3] = null;
                        }
                    }
                    DataColumn column4 = ds.Tables[0].Columns.Add("İçerde", typeof(String));
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        try
                        {
                            if (row["arac_icerde"].ToString().Trim() == "1")
                            {
                                row[column4] = "Evet";
                            }
                            else
                                row[column4] = "Hayır";

                        }
                        catch
                        {


                            row[column4] = null;
                        }
                    }

                    ds.Tables[0].Columns.Remove("arac_abonetur_id");
                    ds.Tables[0].Columns.Remove("arac_tur");
                    ds.Tables[0].Columns.Remove("arac_plakaresim");
                    ds.Tables[0].Columns.Remove("arac_cikis");

                    //   this.dataGridView1.Columns["arac_tur"].HeaderText = "Araç Türü";

                    dataGridView1.DataSource = ds.Tables[0];


                    dataGridView1.Columns["arac_giris"].HeaderText = "İlk Giriş Tarihi";
                    dataGridView1.Columns["arac_sahip"].HeaderText = "Araç Sahibi";
                    dataGridView1.Columns["arac_icerde"].HeaderText = "İçerde Mi";
                    dataGridView1.Columns["arac_aciklama"].HeaderText = "Açıklama";

                    dataGridView1.Columns["arac_plaka"].HeaderText = "Araç Plaka";
                    dataGridView1.Columns["arac_parkyeri"].HeaderText = "Park Yeri";
                    //       dataGridView1.Columns["arac_giris"].DisplayIndex = "İlk Giriş Tarihi";
                    dataGridView1.Columns["Plaka Resim"].DisplayIndex = 0;
                    dataGridView1.Columns["arac_plaka"].DisplayIndex = 1;

                    dataGridView1.Columns["arac_sahip"].DisplayIndex = 5;
                    dataGridView1.Columns["Araç Türü"].DisplayIndex = 3;
                    dataGridView1.Columns["arac_giris"].DisplayIndex = 6;
                    dataGridView1.Columns["arac_parkyeri"].DisplayIndex = 2;
                    dataGridView1.Columns["Abonelik Türü"].DisplayIndex = 4;
                    dataGridView1.Columns["İçerde"].DisplayIndex = 7;
                    dataGridView1.Columns["arac_aciklama"].DisplayIndex = 8;
                    dataGridView1.Columns["arac_icerde"].Visible = false;
                    dataGridView1.Columns["İçerde"].Visible = false;
                    if (uydu == 1)
                    {
                        dataGridView1.Columns["İçerde"].Visible = true;
                    }


                    //  dataGridView1.Columns["arac_aciklama"].DisplayIndex = "Açıklama";


                    // dataGridView1.Columns["arac_parkyeri"].DisplayIndex = "Park Yeri";

                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    StretchLastColumn(dataGridView1);
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                
                label2.Text = dataGridView1.RowCount.ToString() + " Kayıt Gösteriliyor";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                    plaka = dataGridView1.Rows[e.RowIndex].Cells["arac_plaka"].Value.ToString();
                    string iceri = dataGridView1.Rows[e.RowIndex].Cells["arac_icerde"].Value.ToString();
                    if (iceri.Trim()=="0")
                    {
                        button1.Enabled = false;
                    }
                    else
                        button1.Enabled = true;


                }
            }
            catch
            {


            }
        }
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
        string plaka;
        private void button1_Click(object sender, EventArgs e)
        {
            AracCikis aracCikisForm = new AracCikis()
            {
                AracPlaka = plaka,
                //     plakaResim = (Bitmap)pictureboxKamera2.Image

            };
            if (aracCikisForm.ShowDialog() == DialogResult.OK)
            {
                //   girisİslemleri(aracGirisForm.kayitDurumu, aracGirisForm.plakaNo);
                cikisİslemleri(aracCikisForm.cikisDurumu, aracCikisForm.AracPlaka);
                gridViewCek();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(comboBox1.Text);
            Kimlik = comboBox1.Text.Trim();
            gridViewCek();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
