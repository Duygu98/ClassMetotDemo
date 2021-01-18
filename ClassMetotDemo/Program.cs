using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Duygu";
            musteri1.Soyadi = "Uğur";
            musteri1.Eposta = "duygu@gmail.com";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Fadik";
            musteri2.Soyadi = "Uğur";
            musteri2.Eposta = "fadik@gmail.com";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Mustafa";
            musteri3.Soyadi = "Yasar";
            musteri3.Eposta = "mustafa@gmail.com";


            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ali";
            musteri4.Soyadi = "Mutlu";
            musteri4.Eposta = "ali@gmail.com";


            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Samet";
            musteri5.Soyadi = "Akca";
            musteri5.Eposta = "samet@gmail.com";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            MusteriManeger musteriManeger = new MusteriManeger();

            Console.WriteLine("Sistemde Hangi İlemi Yapmak İstersiniz.");
            Console.WriteLine("\t 1- Müsteri Listeleme");
            Console.WriteLine("\t 2- Müsteri Silme");
            Console.WriteLine("\t 3- Müsteri Ekleme");
            Console.WriteLine("\t 4- Cıkıs");

            string deger = Console.ReadLine();
            
            if (deger=="1")
            {
                foreach (var musteri in musteriler)
                {
                    musteriManeger.MusterileriListeleme(musteri);
                }
            }

            else if (deger == "2")
            {
                musteriManeger.MusteriSilme();
            }

            else if (deger == "3")
            {
                musteriManeger.MusteriEkle();
            }
            else
            {
                Environment.Exit(-1);
            }
           

        }
    }
}
