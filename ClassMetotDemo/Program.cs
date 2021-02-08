using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Tc = 12345678910;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Boz";
            musteri1.TelefonNo = 5346875215;

            Musteri musteri2 = new Musteri();
            musteri2.Tc = 12365478912;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Çukur";
            musteri2.TelefonNo = 5358156482;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("  Hoş geldiniz  ");
            Console.WriteLine("  Müşteriler Listeleniyor  ");
            musteriManager.MusteriList(musteriler);
            Console.WriteLine("  Lütfen 'Enter' tuşuna basın ve müşteriyi eklediğimi görün.  ");
            Console.ReadKey();
            Console.WriteLine("  Müşteri Ekleniyor  ");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("  Lütfen 'Enter' tuşuna basın ve müşteriyi kaldırdığımı görün. ");
            Console.ReadKey();
            Console.WriteLine("  Müşteri Kaldırılıyor ");
            musteriManager.Kaldir(musteri2);
        }
    }
}
