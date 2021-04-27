using Otopark_Otomasyonu.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu.View
{
    public partial class formYonetimPaneli : Form
    {
        public formYonetimPaneli()
        {
            InitializeComponent();
        }
        FiyatTarifesiController ftControl = new FiyatTarifesiController();
        FiyatTarifesi fiyatTarifesi=new FiyatTarifesi();
        
        private void formYonetimPaneli_Load(object sender, EventArgs e)
        {
            ftControl.DataGridViewFiyatTarifesi = dataGridView1;
            buttonFtGuncelle.Visible = false;
            ftControl.gridViewDoldur();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
               //
            }
            catch
            {


            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                ftControl.FiyatTarifesi = ftControl.fiyatTarifesiById(id);
                if (ftControl.FiyatTarifesi!=null)
                {
                    ftControl.formDoldur(textKisaltma, textUzunAd, textFiyat);
                    buttonFtGuncelle.Visible = true;
                    buttonFtEkle.Visible = false;
                }
                else
                {
                    buttonFtGuncelle.Visible = false;
                    buttonFtEkle.Visible = true ;

                }
              
            }
            catch
            {


            }
        }

        private void buttonFtSil_Click(object sender, EventArgs e)
        {
            this.ftControl.sil();
            buttonFtGuncelle.Visible = false;
            buttonFtEkle.Visible = true;
            ftControl.gridViewDoldur();
            ftControl.formDoldur(textKisaltma, textUzunAd, textFiyat);
        }

        private void buttonFtEkle_Click(object sender, EventArgs e)
        {
            ftControl.FiyatTarifesi = new FiyatTarifesi(Convert.ToInt16(textFiyat.Text), textKisaltma.Text, textUzunAd.Text);
            ftControl.olustur();
            ftControl.gridViewDoldur();
        }

        private void buttonFtGuncelle_Click(object sender, EventArgs e)
        {
            ftControl.FiyatTarifesi = new FiyatTarifesi((int)dataGridView1.SelectedRows[0].Cells[0].Value,Convert.ToInt16(textFiyat.Text), textKisaltma.Text, textUzunAd.Text);
            this.ftControl.guncelle();
            ftControl.gridViewDoldur();
            buttonFtGuncelle.Visible = false;
            buttonFtEkle.Visible = true;
        }

        private void textKisaltma_TextChanged(object sender, EventArgs e)
        {
            textKisaltma.MaxLength = 3;

        }

        private void textFiyat_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textFiyat.Text, "[^0-9]"))
            {
             
                textFiyat.Text = textFiyat.Text.Remove(textFiyat.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ftControl.FiyatTarifesi = new FiyatTarifesi();
            ftControl.formDoldur(textKisaltma, textUzunAd, textFiyat);
            buttonFtGuncelle.Visible = false;
            buttonFtEkle.Visible = true;
        }
    }
}