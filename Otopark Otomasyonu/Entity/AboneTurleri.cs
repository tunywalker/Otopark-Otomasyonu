﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyonu.Entity
{
    class AboneTurleri
    {
        int aboneTurleri_id;
        string aboneTurleri_ad, aboneTurleri_fiyat;

        public string AboneTurleri_ad { get => aboneTurleri_ad; set => aboneTurleri_ad = value; }
        public string AboneTurleri_fiyat { get => aboneTurleri_fiyat; set => aboneTurleri_fiyat = value; }
        public int AboneTurleri_id { get => aboneTurleri_id; set => aboneTurleri_id = value; }

        public AboneTurleri()
        {
        }

        public AboneTurleri(int aboneTurleri_id, string aboneTurleri_ad, string aboneTurleri_fiyat)
        {
            this.AboneTurleri_id = aboneTurleri_id;
            this.AboneTurleri_ad = aboneTurleri_ad;
            this.AboneTurleri_fiyat = aboneTurleri_fiyat;
        }

        public AboneTurleri(string aboneTurleri_ad, string aboneTurleri_fiyat)
        {
            this.AboneTurleri_ad = aboneTurleri_ad;
            this.AboneTurleri_fiyat = aboneTurleri_fiyat;
        }
    }
}
