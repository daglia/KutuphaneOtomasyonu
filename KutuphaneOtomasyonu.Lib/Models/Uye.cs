using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Lib.Models
{
    public class Uye : Kisi
    {
        public int Ceza { get; set; }
        public DateTime AlisTarihi { get; set; }
        public List<Kitap> kiralananKitaplar;
    }
}
