using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Tc+"TC kimlik numaralı"+musteri.Ad+" "+musteri.Soyad+"isimli"+musteri.TelefonNo+"numaralı kişi kaydedilmiştir.");
            Console.ReadKey();
        }
        public void Kaldir(Musteri musteri)
        {
            Console.WriteLine(musteri.Tc + "TC kimlik numaralı" + musteri.Ad + " " + musteri.Soyad + "isimli" + musteri.TelefonNo + "numaralı kişi kaldırılmıştır.");
            Console.ReadKey();
        }
        public void MusteriList(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri TC kimlik no: "+musteri.Tc);
                Console.WriteLine("Müşterinin adı ve soyadı: "+musteri.Ad+" "+musteri.Soyad);
                Console.WriteLine("Müşteri tel no: "+musteri.TelefonNo);
            }
        }
    }
}
