using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu
{
    class FiyatTarifesi
    {



        int fiyatTarifesi_id,fiyatTarifesi_fiyat;


        string fiyatTarifesi_kisaltma, fiyatTarifesi_uzunAd;

        public FiyatTarifesi(int fiyatTarifesi_id, int fiyatTarifesi_fiyat, string fiyatTarifesi_kisaltma, string fiyatTarifesi_uzunAd)
        {
            this.fiyatTarifesi_id = fiyatTarifesi_id;
            this.fiyatTarifesi_fiyat = fiyatTarifesi_fiyat;
            this.fiyatTarifesi_kisaltma = fiyatTarifesi_kisaltma;
            this.fiyatTarifesi_uzunAd = fiyatTarifesi_uzunAd;
        }
        public FiyatTarifesi(int fiyatTarifesi_fiyat, string fiyatTarifesi_kisaltma, string fiyatTarifesi_uzunAd)
        {
          
            this.fiyatTarifesi_fiyat = fiyatTarifesi_fiyat;
            this.fiyatTarifesi_kisaltma = fiyatTarifesi_kisaltma;
            this.fiyatTarifesi_uzunAd = fiyatTarifesi_uzunAd;
        }

        public FiyatTarifesi()
        {
        }

        public int FiyatTarifesi_id { get => fiyatTarifesi_id; set => fiyatTarifesi_id = value; }
        public int FiyatTarifesi_fiyat { get => fiyatTarifesi_fiyat; set => fiyatTarifesi_fiyat = value; }
        public string FiyatTarifesi_kisaltma { get => fiyatTarifesi_kisaltma; set => fiyatTarifesi_kisaltma = value; }
        public string FiyatTarifesi_uzunAd { get => fiyatTarifesi_uzunAd; set => fiyatTarifesi_uzunAd = value; }

       
    }
}
