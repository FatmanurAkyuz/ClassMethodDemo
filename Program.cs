using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Fatmanur Akyuz";
            musteri1.HesapNo = 1235;
            musteri1.Bakiye = 15.857;
            musteri1.EkHesap = 1500;

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Emin Akyüz";
            musteri2.HesapNo = 7896;
            musteri2.Bakiye = 10.600;
            musteri2.EkHesap = 15000;

            MusteriManager musteriManeger = new MusteriManager();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Listele(musteri1);
            musteriManeger.Sil(musteri1);

            Console.WriteLine("**********");

            musteriManeger.Ekle(musteri2);
            musteriManeger.Listele(musteri2);
            musteriManeger.Sil(musteri2);

        }
    }
}
