using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Lib.Models
{
    public abstract class Kisi
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString() => $"{this.Ad} {this.Soyad}";
    }
}
