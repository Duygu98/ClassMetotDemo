using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManeger
    {
        public void MusteriEkle()
        {
            Console.WriteLine("Musteri Id Giriniz : " );
            Console.ReadLine();
            Console.WriteLine("Musteri Adi Giriniz : ");
            Console.ReadLine();
            Console.WriteLine("Musteri Soyadi Giriniz : ");
            Console.ReadLine();
            Console.WriteLine("Musteri Eposta Giriniz : ") ;
            Console.ReadLine();
            Console.WriteLine("Musteri Kaydedildi. ");
           
        }
        public void MusterileriListeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Id : " + musteri.Id);
            Console.WriteLine("Musteri Adi : " + musteri.Adi);
            Console.WriteLine("Muster Soyadi : " + musteri.Soyadi);
            Console.WriteLine("Musteri Eposta : " + musteri.Eposta);
            Console.WriteLine("---------------------------------");



        }
        public void MusteriSilme()
        {
            Console.WriteLine("Silmek istediginiz musteri Id'sini giriniz.");
            string mId = Console.ReadLine();
            Console.WriteLine(mId +" Id'li musteri silinmistir.");


        }
       
    }
}
