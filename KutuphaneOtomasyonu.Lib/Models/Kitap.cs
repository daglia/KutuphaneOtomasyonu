using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Lib.Models
{
    public class Kitap
    {
        public string kitapAd { get; set; }
        public Yazar kitapYazar { get; set; }
        public bool kiralandiMi { get; set; }
    }
}
