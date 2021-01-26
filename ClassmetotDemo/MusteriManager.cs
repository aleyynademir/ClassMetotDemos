using System;
using System.Collections.Generic;
using System.Text;

namespace ClassmetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Eklendi: " + musteri.Firstname );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silindi:" + musteri.Firstname);
        }
    }
}
