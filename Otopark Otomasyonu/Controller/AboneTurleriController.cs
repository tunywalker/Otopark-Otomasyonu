using Otopark_Otomasyonu.DAO;
using Otopark_Otomasyonu.Entity;
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
    class AboneTurleriController
    {
        private List<AboneTurleri> _aboneTurleriList = null;
        private AboneTurleriDAO _aboneTurleriDao;
        private AboneTurleri _aboneTurleri;
        private DataGridView _dataGridViewAboneTurleri;



        internal List<AboneTurleri> AboneTurleriList
        {
            get
            {
                if (_aboneTurleriList == null) this._aboneTurleriList = new List<AboneTurleri>();
                this._aboneTurleriList = this.AboneTurleriDAO.getAboneTurleri();
                return _aboneTurleriList;
            }

        }

        internal AboneTurleriDAO AboneTurleriDAO
        {
            get
            {
                if (_aboneTurleriDao == null) this._aboneTurleriDao = new AboneTurleriDAO();

                return _aboneTurleriDao;
            }

        }
  
        internal AboneTurleri AboneTurleri
        {
            get
            {
                if (this._aboneTurleri == null)
                    this._aboneTurleri = new AboneTurleri();
                return _aboneTurleri;
            }
            set { _aboneTurleri = value; }
        }

        public DataGridView DataGridViewAboneTurleri { get => _dataGridViewAboneTurleri; set => _dataGridViewAboneTurleri = value; }




        public void sil()
        {
            try
            {
             
                this.AboneTurleriDAO.Delete(this.AboneTurleri);
                this.AboneTurleri = new AboneTurleri();
            }
            catch { }
        }
        public void guncelle()
        {
            try
            {
                Debug.WriteLine("Controller Update" + this._aboneTurleri.AboneTurleri_ad);
                this.AboneTurleriDAO.Update(this.AboneTurleri);
                this.AboneTurleri = new AboneTurleri();
            }
            catch { }
        }
        public void olustur()
        {
         
                Debug.WriteLine("Controller Create" + this._aboneTurleri.AboneTurleri_ad);
                this.AboneTurleriDAO.Insert(this.AboneTurleri);
                this.AboneTurleri = new AboneTurleri();
            try
            {
            }
            catch { }

        }
        public Object comboDataSource()
        {
            ComboBox comboTemp = new ComboBox();
            Dictionary<string, string> test = new Dictionary<string, string>();


            foreach (var ft in AboneTurleriList)
            {
                test.Add(ft.AboneTurleri_id.ToString(), ft.AboneTurleri_ad);

            }



            return test;
        }
        public AboneTurleri aboneTurleriById(int id)
        {
            if (this.AboneTurleri==null)
            {
                this.AboneTurleri = new AboneTurleri();
            }
            this.AboneTurleri = this.AboneTurleriDAO.GetAboneTurleriById(id);
            return this.AboneTurleri;
        }
        public void formDoldur(TextBox ad, TextBox Fiyat, TextBox Sure)
        {
            try
            {
                ad.Text = this.AboneTurleri.AboneTurleri_ad;
                Fiyat.Text = this.AboneTurleri.AboneTurleri_fiyat;
                Sure.Text = this.AboneTurleri.AboneTurleri_sure;
                
            }
            catch
            {

            }
        }
        public void gridViewDoldur()
        {
            var atList = this.AboneTurleriList;


            var aboneTurleriList = new BindingList<AboneTurleri>(atList);
            var source = new BindingSource(aboneTurleriList, null);
            this.DataGridViewAboneTurleri.DataSource = source;
            this.DataGridViewAboneTurleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //Fit the contain
            this.DataGridViewAboneTurleri.AutoResizeColumns();
            this.DataGridViewAboneTurleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewAboneTurleri.Columns["aboneTurleri_id"].HeaderText = "ID";
            this.DataGridViewAboneTurleri.Columns["aboneTurleri_ad"].HeaderText = "Ad";
            this.DataGridViewAboneTurleri.Columns["aboneTurleri_fiyat"].HeaderText = "Fiyat";
            this.DataGridViewAboneTurleri.Columns["aboneTurleri_sure"].HeaderText = "Süre";
            this.DataGridViewAboneTurleri.Columns["aboneTurleri_id"].DisplayIndex = 0;

            this.DataGridViewAboneTurleri.RowHeadersVisible = false;
            for (int i = 0; i < this.DataGridViewAboneTurleri.Columns.Count; i++)
            {
                this.DataGridViewAboneTurleri.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = this.DataGridViewAboneTurleri.Columns[i].Width;
                this.DataGridViewAboneTurleri.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this.DataGridViewAboneTurleri.Columns[i].Width = colw;
            }

            this.DataGridViewAboneTurleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var lastColIndex = this.DataGridViewAboneTurleri.Columns.Count - 1;
            var lastCol = this.DataGridViewAboneTurleri.Columns[lastColIndex];
            lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewAboneTurleri.ReadOnly = true;
            this.DataGridViewAboneTurleri.AllowUserToAddRows = false;
            this.DataGridViewAboneTurleri.ClearSelection();




        }

    }

}
