using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu
{
    class FiyatTarifesi
    {



       
        int fiyat;
         string tamAd;
        string kisaltma;

        public FiyatTarifesi(string tamAd)
        {
           
            this.tamAd = tamAd;
            switch (tamAd)
            {
                case "Hatchbag/Sedan":
                    this.fiyat = 6;
                    this.kisaltma = "HS";
                    break;
                case "Motorsiklet":
                    this.fiyat = 3;
                    this.kisaltma = "M";
                    break;
                case "Minibüs/Kamyonet":
                    this.fiyat = 10;
                    this.kisaltma = "MK";
                    break;
                case "Otobüs":
                    this.fiyat = 15;
                    this.kisaltma = "O";
                    break;
                default:
                    this.fiyat = 10;
                    this.kisaltma = "O";

                    break;
            }
        }

       

        public int fiyatHesapla(int saat)
        {
            if (saat <= 1)
                return fiyat;
            else if (saat >= 1 && saat <= 2)
                return (fiyat / 3) * 4;
            else if (saat >= 2 && saat <= 4)
                return (fiyat / 3) * 5;
            else if (saat >= 4 && saat <= 8)
                return (fiyat) * 2;
            else if (saat >= 8 && saat <= 12)
                return (fiyat) / 2 * 3;
            else if (saat >= 12 && saat <= 24)
                return (fiyat) / 2 * 8;
            else if (saat > 24)
                return saat / 24 * fiyatHesapla(24);
            else
                return 99;
           
        }
    }
}
