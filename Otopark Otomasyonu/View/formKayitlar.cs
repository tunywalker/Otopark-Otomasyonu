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
    public partial class kayitlar : Form
    {
        public kayitlar()
        {
            InitializeComponent();
        }
        public  void StretchLastColumn(DataGridView dataGridView)
        {
            var lastColIndex = dataGridView.Columns.Count - 1;
            var lastCol = dataGridView.Columns[lastColIndex];
            lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private String plaka;

        public string Plaka { get => plaka; set => plaka = value; }

        private void Kayıtlar_Load(object sender, EventArgs e)
        {
            string connectionString="Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8";
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            string query = "select * from arac_log"; // set query to fetch data "Select * from  tabelname"; 
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
                    this.dataGridView1.Columns["id"].Visible = false;
                    this.dataGridView1.Columns["islem_turu"].HeaderText = "İşlem Türü";
                    this.dataGridView1.Columns["islem_plaka"].AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill;
                    this.dataGridView1.Columns["islem_plaka"].HeaderText = "Plaka";
                    this.dataGridView1.Columns["islem_tarih"].HeaderText = "Tarih";
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    dataGridView1.AllowUserToAddRows = false;


                }
            }
            textBox1.Text = Plaka;
        }
        public void tabloFiltrele()
        {


            if (comboBox1.Text == "Giriş/Çıkış")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("islem_turu LIKE '%' AND islem_plaka LIKE '{1}%'", comboBox1.Text,textBox1.Text);
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("islem_turu LIKE '%{0}%' AND islem_plaka LIKE '{1}%'", comboBox1.Text, textBox1.Text);

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tabloFiltrele();
                }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabloFiltrele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            catch
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
