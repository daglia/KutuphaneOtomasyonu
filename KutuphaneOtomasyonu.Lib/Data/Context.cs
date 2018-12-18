using KutuphaneOtomasyonu.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Lib.Data
{
    public class Context
    {
        public List<Uye> Uyeler { get; set; } = new List<Uye>();
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();
        public List<Yazar> Yazarlar { get; set; } = new List<Yazar>();

    }
}
