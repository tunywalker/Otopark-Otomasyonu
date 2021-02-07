using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Otopark_Otomasyonu
{
    public partial class kameraEkle : Form
    {

        public kameraEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        databaseConnection c1;
        private void kameraEkle_Load(object sender, EventArgs e)
        {
            c1 = new databaseConnection();
        c1.kameraAdGetir(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.formdoldur(textBox1, comboBox1, textBox3, comboBox2, checkBox1, checkBox2);
        }
    }
}
