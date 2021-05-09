using Otopark_Otomasyonu.Controller;
using Otopark_Otomasyonu.Entity;
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
        FiyatTarifesiController ftController = new FiyatTarifesiController();
        AboneTurleriController atController = new AboneTurleriController();
        private void formAboneAracEkle_Load(object sender, EventArgs e)
        {
            List<AboneTurleri> atList = atController.AboneTurleriList;

            comboAboneTur.DataSource = new BindingSource(atController.comboDataSource(), null);
            comboAboneTur.DisplayMember = "Value";
            comboAboneTur.ValueMember = "Key";


            List<FiyatTarifesi> ftList = ftController.FiyatTarifesiList;

            comboAracTur.DataSource = new BindingSource(ftController.comboDataSource(), null);
            comboAracTur.DisplayMember = "Value";
            comboAracTur.ValueMember = "Key";

            comboParkYer.Items.Clear();

            try
            {
                 
                foreach (string parkYeri in otopark1.bosParkyerleri())
                    comboParkYer.Items.Add(parkYeri);
                aracSahibi = aracSahibi.aboneIcerdenGetir(Kimlik);
                label1.Text = aracSahibi.Abone_adsoyad;
                comboParkYer.SelectedIndex = 0;
            }
            catch
            {
                
            }

       
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            label10.Text = "-";
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Arac KaydolacakArac = new Arac(textBox1.Text,
               ftController.fiyatTarifesiById(Convert.ToInt32(((KeyValuePair<string, string>)comboAracTur.SelectedItem).Key)),
                DateTime.Now.ToString(),
                "0",
                atController.aboneTurleriById(Convert.ToInt32(((KeyValuePair<string, string>)comboAboneTur.SelectedItem).Key)),
                comboParkYer.Text,
                this.Kimlik,
                richTextBox1.Text,
                Properties.Resources.image
                );
            KaydolacakArac.aracKaydet(KaydolacakArac);
            // public Arac(string arac_plaka, FiyatTarifesi arac_tur, string arac_giris,string arac_icerde , AboneTurleri AboneTur, string arac_parkyeri, string arac_sahip, string arac_aciklama)
        }
    }
}
