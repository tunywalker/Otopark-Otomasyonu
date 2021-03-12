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

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

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
    }
}
