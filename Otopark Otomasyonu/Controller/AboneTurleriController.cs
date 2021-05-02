using Otopark_Otomasyonu.DAO;
using Otopark_Otomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu.Controller
{
    class AboneTurleriController
    {
        private List<AboneTurleri> _aboneTurleriList = null;
        private AboneTurleriDAO _aboneTurleriDao;
        private FiyatTarifesi _fiyatTarifesi;
        private DataGridView _dataGridViewAboneTurleri;



        internal List<FiyatTarifesi> FiyatTarifesiList
        {
            get
            {
                if (_aboneTurleriList == null) this._aboneTurleriList = new List<FiyatTarifesi>();
                this._aboneTurleriList = this.FiyatTarifesiDao.getFiyatTarifesi();
                return _aboneTurleriList;
            }

        }

        internal FiyatTarifesiDAO FiyatTarifesiDao
        {
            get
            {
                if (_aboneTurleriDao == null) this._aboneTurleriDao = new FiyatTarifesiDAO();

                return _aboneTurleriDao;
            }

        }
        public int fiyatHesapla(int saat)
        {
            if (saat <= 1)
                return this._fiyatTarifesi.FiyatTarifesi_fiyat;
            else if (saat >= 1 && saat <= 2)
                return (this._fiyatTarifesi.FiyatTarifesi_fiyat / 3) * 4;
            else if (saat >= 2 && saat <= 4)
                return (this._fiyatTarifesi.FiyatTarifesi_fiyat / 3) * 5;
            else if (saat >= 4 && saat <= 8)
                return (this._fiyatTarifesi.FiyatTarifesi_fiyat) * 2;
            else if (saat >= 8 && saat <= 12)
                return (this._fiyatTarifesi.FiyatTarifesi_fiyat) / 2 * 3;
            else if (saat >= 12 && saat <= 24)
                return (this._fiyatTarifesi.FiyatTarifesi_fiyat) / 2 * 8;
            else if (saat > 24)
                return saat / 24 * fiyatHesapla(24);
            else
                return 99;

        }
        internal FiyatTarifesi FiyatTarifesi
        {
            get
            {
                if (this._fiyatTarifesi == null)
                    this._fiyatTarifesi = new FiyatTarifesi();
                return _fiyatTarifesi;
            }
            set { _fiyatTarifesi = value; }
        }

        public DataGridView DataGridViewFiyatTarifesi { get => _dataGridViewAboneTurleri; set => _dataGridViewAboneTurleri = value; }




        public void sil()
        {
            try
            {
                //   Console.WriteLine("aa");
             //   Debug.WriteLine("Controller Sil" + this._fiyatTarifesi.FiyatTarifesi_uzunAd);
                this.FiyatTarifesiDao.Delete(this.FiyatTarifesi);
                this.FiyatTarifesi = new FiyatTarifesi();
            }
            catch { }
        }
        public void guncelle()
        {
            try
            {
                Debug.WriteLine("Controller Update" + this._fiyatTarifesi.FiyatTarifesi_uzunAd);
                this.FiyatTarifesiDao.Update(this.FiyatTarifesi);
                this.FiyatTarifesi = new FiyatTarifesi();
            }
            catch { }
        }
        public void olustur()
        {
            try
            {
                Debug.WriteLine("Controller Create" + this._fiyatTarifesi.FiyatTarifesi_uzunAd);
                this.FiyatTarifesiDao.Insert(this.FiyatTarifesi);
                this.FiyatTarifesi = new FiyatTarifesi();
            }
            catch { }

        }
        public Object comboDataSource()
        {
            ComboBox comboTemp = new ComboBox();
            Dictionary<string, string> test = new Dictionary<string, string>();


            foreach (var ft in FiyatTarifesiList)
            {
                test.Add(ft.FiyatTarifesi_id.ToString(), ft.FiyatTarifesi_uzunAd);

            }



            return test;
        }
        public FiyatTarifesi fiyatTarifesiById(int id)
        {
            this.FiyatTarifesi = this.FiyatTarifesiDao.GetFiyatTarifesiById(id);
            return this.FiyatTarifesi;
        }
        public void formDoldur(TextBox kisaltma, TextBox uzunAd, TextBox Fiyat)
        {
            kisaltma.Text = this.FiyatTarifesi.FiyatTarifesi_kisaltma;
            uzunAd.Text = this.FiyatTarifesi.FiyatTarifesi_uzunAd;
            Fiyat.Text = (this.FiyatTarifesi.FiyatTarifesi_fiyat.ToString() == "0") ? "" : this.FiyatTarifesi.FiyatTarifesi_fiyat.ToString();
        }
        public void gridViewDoldur()
        {
            var atList = this.;


            var aboneTurleriList = new BindingList<AboneTurleri>(ftList);
            var source = new BindingSource(aboneTurleriList, null);
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
}
