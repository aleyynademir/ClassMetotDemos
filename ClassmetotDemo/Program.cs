using System;

namespace ClassmetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

                Musteri musteri1 = new Musteri();
                Musteri musteri2 = new Musteri();
                Musteri musteri3 = new Musteri();
                musteri1.Firstname = "Aleyna";
                musteri1.Surname = "Demir";
                musteri1.ID = 12345;

                musteri2.Firstname = "Emin";
                musteri2.Surname = "Yılmaz";
                musteri2.ID = 78965;

                musteri3.Firstname = "Sultan";
                musteri3.Surname = "Kayık";
                musteri3.ID = 45632;

                Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

                foreach (Musteri bilgiler in musteriler)
                {
                Console.WriteLine(bilgiler.Firstname);
                Console.WriteLine(bilgiler.Surname);
                Console.WriteLine(bilgiler.ID);
                Console.WriteLine("**************");

                }

            MusteriManager manager = new MusteriManager();

            manager.Ekle(musteri1);

            manager.Sil(musteri2);

            


            

        }
    }

    
}
