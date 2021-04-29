using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Otopark_Otomasyonu
{
    public partial class formAboneler : Form
    {
        public formAboneler()
        {
            InitializeComponent();
        }
        public void StretchLastColumn(DataGridView dataGridView)
        {
            var lastColIndex = dataGridView.Columns.Count - 1;
            var lastCol = dataGridView.Columns[lastColIndex];
            lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void gridViewCek()
        {

            string connectionString = "Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8";
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            string query = "select * from aboneler"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    StretchLastColumn(dataGridView1);
                    dataGridView1.BackgroundColor = Color.White;
                    dataGridView1.RowHeadersVisible = false;
                    //  this.dataGridView1.Columns["id"].Visible = false;
                    this.dataGridView1.Columns["abone_adsoyad"].HeaderText = "Adı ve Soyadı";
                    this.dataGridView1.Columns["abone_uyeliktarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    this.dataGridView1.Columns["abone_adsoyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    this.dataGridView1.Columns["abone_kimlikno"].HeaderText = "Kimlik Numarası";
                    this.dataGridView1.Columns["abone_ozeldurum"].HeaderText = "Özel Durum";
                    this.dataGridView1.Columns["abone_telefon"].HeaderText = "Telefon Numarası";
                    this.dataGridView1.Columns["abone_uyeliktarihi"].HeaderText = "Üyelik Tarihi";
                    this.dataGridView1.Columns["abone_borc"].HeaderText = "Borç";
                    //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    dataGridView1.AllowUserToAddRows = false;
                  //  dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
                    for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        int colw = dataGridView1.Columns[i].Width;
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dataGridView1.Columns[i].Width = colw;
                    }



                }
            }
        }
        public void tabloFiltrele()
        {


            if (checkBox1.Checked==false)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("abone_borc >= '0' ");
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("abone_borc > '0' ");

            }
        }
        Otopark otopark1;
        Arac aboneArac = new Arac();
        private void formAboneler_Load(object sender, EventArgs e)
        {
            label10.Text = "";
            gridViewCek();
            comboParkYer.Items.Clear();
            foreach (string parkYeri in otopark1.bosParkyerleri())
                comboParkYer.Items.Add(parkYeri);
            comboParkYer.SelectedIndex = 0;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
       Abone eklenecek=     new Abone(textAdSoyad.Text, textKimlik.Text, textOzelDurum.Text+",", textTelefon.Text);
            eklenecek.aboneKaydet(eklenecek);
            gridViewCek();
        }
        public delegate void OnFindText(string txtToFind);
       
        private void button1_Click(object sender, EventArgs e)
        {
            formTemizle();




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tabloFiltrele();
            formTemizle();
        }
       public void formTemizle()
        {
            try
            {
                dataGridView1.Rows[0].Selected = true;
            }
            catch
            {

            }
            textKimlik.Text = "";
            textAdSoyad.Text = "";
            textOzelDurum.Text = "";
            textTelefon.Text = "";
           // checkBox1.Checked = false;
            buttonGuncelle.Visible = false;
            textKimlik.Enabled = true;
            buttonEkle.Visible = true;
            





        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string ad = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string kimlik = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string telefon = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string ozeldurum = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textAdSoyad.Text = ad;
                textKimlik.Text = kimlik;
                textTelefon.Text = telefon;
                textOzelDurum.Text = ozeldurum;
            }
            catch
            {
               
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                buttonGuncelle.Visible = true;

                textKimlik.Enabled = false;
                buttonEkle.Visible = false;
            }
            catch
            {
                

            }
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string kimlikno = dataGridView1.CurrentRow.Cells["abone_kimlikno"].Value.ToString();
            Abone silinecek = new Abone(kimlikno);
            if (silinecek.aboneSil())
            {
                gridViewCek();
                formTemizle();
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Abone guncellenecek = new Abone(textAdSoyad.Text, textKimlik.Text, textOzelDurum.Text, textTelefon.Text);
            if (guncellenecek.aboneGuncelle(guncellenecek)) { 
            gridViewCek();
            formTemizle();
        }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            formAboneAraclar aboneAracForm = new formAboneAraclar()
            {
                Kimlik = textKimlik.Text,
                //     plakaResim = (Bitmap)pictureboxKamera2.Image

            };
            aboneAracForm.Show();
            
            
        }
        public List<string> bosParkyerleri;

        internal Otopark Otopark1 { get => Otopark11; set => Otopark11 = value; }
        internal Otopark Otopark11 { get => otopark1; set => otopark1 = value; }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            aboneArac = aboneArac.aracIcerdenGetir(textBox1.Text);
            
            if (aboneArac.Arac_plaka.Trim()!="")
            {
                MessageBox.Show(aboneArac.Arac_plaka);
                label10.Text = "(KAYITLI)";
                //comboAracTur.SelectedIndex = comboAracTur.FindString(aboneArac.aracTurGetir());
                comboAboneTur.Enabled = false;
                comboAracTur.Enabled = false;
                comboParkYer.Enabled = false;
                richTextBox1.Enabled = false;
                buttonEkle.Enabled = false;
                
            }
            else
            {
                label10.Text = "";
                comboAboneTur.Enabled = true;
                comboAracTur.Enabled = true;
                comboParkYer.Enabled = true;
                richTextBox1.Enabled = true;
            }
        }
    }
}
