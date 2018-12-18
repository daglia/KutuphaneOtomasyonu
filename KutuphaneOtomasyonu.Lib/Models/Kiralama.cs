using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Lib.Models
{
    public class Kiralama
    {
        public Uye Uye { get; set; }
        public Kitap Kitap { get; set; }
        public DateTime SonGun { get; set; }
    }
}
