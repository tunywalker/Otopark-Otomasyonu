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
    public partial class formYeniAbone : Form
    {
        public formYeniAbone()
        {
            InitializeComponent();
        }
        private string aboneKimlik;
        private bool uyelikBasarili;

        public string AboneKimlik { get => aboneKimlik; set => aboneKimlik = value; }
        public bool UyelikBasarili { get => uyelikBasarili; set => uyelikBasarili = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            Abone eklenecek = new Abone(textAdSoyad.Text, textKimlik.Text, textOzelDurum.Text + ",", textTelefon.Text);
            if (eklenecek.aboneKaydet(eklenecek))
            {

                aboneKimlik = textKimlik.Text;
                UyelikBasarili = true;
            }
            else
            {
                UyelikBasarili = false;
                aboneKimlik = textKimlik.Text;

            }
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
