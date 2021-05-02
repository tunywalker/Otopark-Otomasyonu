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
    public partial class formAboneAracEkle : Form
    {
        public formAboneAracEkle()
        {
            InitializeComponent();
        }
        Arac aboneArac= new Arac();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                aboneArac = aboneArac.aracIcerdenGetir(textBox1.Text);

                if (aboneArac.Arac_plaka.Trim() != "")
                {
                    // MessageBox.Show(aboneArac.Arac_plaka);
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
                    buttonEkle.Enabled = true;
                }
            }
            catch
            {

            }
        }
        public string Kimlik;
        private Otopark otopark1;
        Abone aracSahibi = new Abone();

        internal Otopark Otopark1 { get => otopark1; set => otopark1 = value; }
        
        private void formAboneAracEkle_Load(object sender, EventArgs e)
        {
            comboParkYer.Items.Clear();

            try
            {
                 
                foreach (string parkYeri in otopark1.bosParkyerleri())
                    comboParkYer.Items.Add(parkYeri);
                aracSahibi = aracSahibi.aboneIcerdenGetir(Kimlik);
                label1.Text = aracSahibi.Abone_adsoyad;
            }
            catch
            {
                
            }

       
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            label10.Text = "-";
        }
    }
}
