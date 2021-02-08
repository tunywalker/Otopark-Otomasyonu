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
        Kamera k = new Kamera();
        private void kameraEkle_Load(object sender, EventArgs e)
        {
           
        k.kameraAdGetir(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                k.formdoldur(textBox1, comboBox1, textBox3, comboBox2, checkBox1, checkBox2, listBox1.SelectedIndex+1);
                this.k = k.kameraGetir(listBox1.SelectedIndex + 1);
                
                  //  MessageBox.Show("Guncelle");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
