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
            comboLokasyon.SelectedIndex = 0;
            comboYontem.SelectedIndex = 0;
        k.kameraAdGetir(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                k.formdoldur(textKadi, comboYontem, textFiligran, comboLokasyon, checkYabanci, checkAktif, listBox1.SelectedIndex+1);
                this.k = k.kameraGetir(listBox1.SelectedIndex + 1);
                
                  //  MessageBox.Show("Guncelle");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.k = new Kamera(textKadi.Text, comboYontem.SelectedIndex.ToString(),
                textFiligran.Text,
                ((comboLokasyon.SelectedIndex==0) ? "0" : "1").ToString(),
                ((checkYabanci.Checked==true) ? 0 : 1).ToString(),
                ((checkAktif.Checked) ? 0 : 1).ToString()
               );
            if (k.kameraKaydet(this.k))
                k.kameraAdGetir(listBox1);

                
        }

        private void comboYontem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
