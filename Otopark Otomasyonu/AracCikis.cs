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
    public partial class AracCikis : Form
    {
        public AracCikis()
        {
            InitializeComponent();
        }
       private Arac cikacak = new Arac();

        private string aracPlaka;
        private Bitmap plakaResim;

        public Bitmap PlakaResim { get { return plakaResim; } set => plakaResim = value; }
        public String AracPlaka { get {return  aracPlaka; } set => aracPlaka = value; }

        internal Arac Cikacak { get => cikacak; set => cikacak = value; }

        private void AracCikis_Load(object sender, EventArgs e)
        {
            textPlaka.Text = AracPlaka;
            labelCikisTarih.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult. OK;
        }

        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
            if (textPlaka.Text.Length>=5)
            {

           
            try
            {
              
                Cikacak = Cikacak.aracGetir(textPlaka.Text);
                labelGirisTarihi.Text = Cikacak.Arac_giris;
                labelAracSahip.Text = Cikacak.Arac_sahip;
                labelAractur.Text = Cikacak.Arac_tur;
            }
            catch (Exception)
            {

                throw;
            }
            }
        }
    }
}
