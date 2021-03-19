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
        public Bitmap plakaResim;
        public AracGiris()
        {
            InitializeComponent();
        }
        public Boolean kayitDurumu { get { return kayit; } }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            try
            {
                comboBox1.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                textPlaka.Text = plaka;
                labelGirisTarihi.Text = DateTime.Now.ToString();
                pictureBox1.Image = plakaResim;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
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
            Arac A1 = new Arac(textPlaka.Text, aracturu, DateTime.Now.ToString(), "1", (Bitmap)pictureBox1.Image, comboBox3.Text.Replace("-",""), label8.Text, richTextBox1.Text);
     kayit=   A1.aracKaydet(A1);
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
