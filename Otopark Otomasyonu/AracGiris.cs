using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class AracGiris : Form
    {
       public String plaka = "";
        public List<string> bosParkyerleri;
        public Bitmap plakaResim;
        public AracGiris()
        {
            InitializeComponent();
        }
        public Boolean kayitDurumu { get { return kayit; } }
        public String plakaNo { get { return aracPlaka; } }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            try
            {
                comboBox1.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                textPlaka.Text = plaka;
                labelGirisTarihi.Text = DateTime.Now.ToString();
                pictureBox1.Image = plakaResim;

                comboBox3.Items.Clear();
                foreach (string parkYeri in bosParkyerleri)
                 comboBox3.Items.Add(parkYeri);
                
                comboBox3.SelectedIndex = 0;
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String aracPlaka;
        Boolean kayit;
        private void button1_Click(object sender, EventArgs e)
        {
            string aracturu="";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    aracturu = "HS";
                    break;
                case 1:
                    aracturu= "M";
                    break;
                case 2: 
                    aracturu="MK";
                    break;
                case 3:
                    aracturu = "O";
                    break;
                default:
                    break;
            }
            Arac A1 = new Arac(textPlaka.Text, aracturu, DateTime.Now.ToString(), "1", (Bitmap)pictureBox1.Image, comboBox3.Text.Replace("geerg",""), label8.Text, richTextBox1.Text);
             kayit=   A1.aracKaydet(A1);
            aracPlaka = textPlaka.Text; 
            Close();
            DialogResult = DialogResult.OK;
        }

        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
