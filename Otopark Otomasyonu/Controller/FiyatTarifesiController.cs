using Otopark_Otomasyonu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu.Controller
{

    class FiyatTarifesiController
    {
        private List<FiyatTarifesi> _fiyatTarifesiList = null;
        private FiyatTarifesiDAO _fiyatTarifesiDao;
        private FiyatTarifesi _fiyatTarifesi;
        private DataGridView dataGridViewFiyatTarifesi;


        internal List<FiyatTarifesi> FiyatTarifesiList {
            get { 
                if (_fiyatTarifesiList == null) this._fiyatTarifesiList= new List<FiyatTarifesi>();
                this._fiyatTarifesiList = this.FiyatTarifesiDao.getFiyatTarifesi();
                return _fiyatTarifesiList;
            }

          }

        internal FiyatTarifesiDAO FiyatTarifesiDao
        {
            get
            {
                if (_fiyatTarifesiDao == null) this._fiyatTarifesiDao = new FiyatTarifesiDAO();
               
                return _fiyatTarifesiDao;
            }

        }

        internal FiyatTarifesi FiyatTarifesi { 
            get { if (this._fiyatTarifesi == null)
                    this._fiyatTarifesi = new FiyatTarifesi();
                return _fiyatTarifesi; 
            }
            set { _fiyatTarifesi = value; } }

        public DataGridView DataGridViewFiyatTarifesi { get => dataGridViewFiyatTarifesi; set => dataGridViewFiyatTarifesi = value; }

        public void sil()
        {
            //   Console.WriteLine("aa");
            Debug.WriteLine("Controller Sil" + this._fiyatTarifesi.FiyatTarifesi_uzunAd);
            this.FiyatTarifesiDao.Delete(this.FiyatTarifesi);
            this.FiyatTarifesi = new FiyatTarifesi();
        }
        public void guncelle()
        {
            Debug.WriteLine("Controller Update" + this._fiyatTarifesi.FiyatTarifesi_uzunAd);
            this.FiyatTarifesiDao.Update(this.FiyatTarifesi);
            this.FiyatTarifesi = new FiyatTarifesi();

        }
        public void olustur()
        {
            Debug.WriteLine("Controller Create" + this._fiyatTarifesi.FiyatTarifesi_uzunAd);
            this.FiyatTarifesiDao.Insert(this.FiyatTarifesi);
            this.FiyatTarifesi = new FiyatTarifesi();

        }
        public FiyatTarifesi fiyatTarifesiById(int id)
        {
            this.FiyatTarifesi = this.FiyatTarifesiDao.GetFiyatTarifesiById(id);
            return this.FiyatTarifesi;
        }
        public void formDoldur(TextBox kisaltma, TextBox uzunAd,TextBox Fiyat)
        {
            kisaltma.Text = this.FiyatTarifesi.FiyatTarifesi_kisaltma;
            uzunAd.Text = this.FiyatTarifesi.FiyatTarifesi_uzunAd;
            Fiyat.Text = (this.FiyatTarifesi.FiyatTarifesi_fiyat.ToString() == "0") ? "" : this.FiyatTarifesi.FiyatTarifesi_fiyat.ToString();
        }
        public void gridViewDoldur()
        {
            var ftList = this.FiyatTarifesiList;

            
                var fiyatTarifeList = new BindingList<FiyatTarifesi>(ftList);
                var source = new BindingSource(fiyatTarifeList, null);
                this.DataGridViewFiyatTarifesi.DataSource = source;
                this.DataGridViewFiyatTarifesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                //Fit the contain
                this.DataGridViewFiyatTarifesi.AutoResizeColumns();
                this.DataGridViewFiyatTarifesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewFiyatTarifesi.Columns["fiyatTarifesi_id"].HeaderText = "ID";
            this.DataGridViewFiyatTarifesi.Columns["fiyatTarifesi_kisaltma"].HeaderText = "Kısaltma";
            this.DataGridViewFiyatTarifesi.Columns["fiyatTarifesi_uzunAd"].HeaderText = "Tam Ad";
            this.DataGridViewFiyatTarifesi.Columns["fiyatTarifesi_fiyat"].HeaderText = "Fiyat";

            this.DataGridViewFiyatTarifesi.RowHeadersVisible = false;
                for (int i = 0; i < this.DataGridViewFiyatTarifesi.Columns.Count; i++)
                {
                    this.DataGridViewFiyatTarifesi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int colw = this.DataGridViewFiyatTarifesi.Columns[i].Width;
                    this.DataGridViewFiyatTarifesi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    this.DataGridViewFiyatTarifesi.Columns[i].Width = colw;
                }

            this.DataGridViewFiyatTarifesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
                var lastColIndex = this.DataGridViewFiyatTarifesi.Columns.Count - 1;
                var lastCol = this.DataGridViewFiyatTarifesi.Columns[lastColIndex];
                lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewFiyatTarifesi.ReadOnly = true;
            this.DataGridViewFiyatTarifesi.AllowUserToAddRows = false;
            this.DataGridViewFiyatTarifesi.ClearSelection();




        }

    }
}
