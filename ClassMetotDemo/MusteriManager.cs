using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public List<Musteri> musteriler = new List<Musteri>();

        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Name + "isimli müşteri kaydı sisteme eklenmiştir.");
        }

        public void Silme(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.Name + "isimli müşteri sistemden silinmiştir.");
        }
    }
}
