using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Ad Soyad: " + musteri.AdSoyad);
            Console.WriteLine("Hesap No: " + musteri.HesapNo);
            Console.WriteLine("Bakiye: " + musteri.Bakiye);
            Console.WriteLine("Ek Hesap Bilgisi: " + musteri.EkHesap);
        }
    }
}
