using KutuphaneOtomasyonu.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Lib.Data
{
    public class MockData
    {
        public Context Context { get; set; }
        public MockData()
        {
            Context = new Context();

            for (int i = 0; i < 10; i++)
            {
                Context.Uyeler.Add(new Uye()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                });
            }
            for (int i = 0; i < 10; i++)
            {
                Context.Yazarlar.Add(new Yazar()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                });
            }
        }
    }
}
