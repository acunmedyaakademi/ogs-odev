using System;
using System.Collections.Generic;

namespace ogs_ödev
{
    internal class versıon_1
    {
        class Gider
        {
            public string Ad { get; set; }
            public decimal Miktar { get; set; }

            public Gider(string ad, decimal miktar)
            {
                Ad = ad;
                Miktar = miktar;
            }
        
        public static void giderGiris(List<Gider> giderler) 
        {
            
            Console.WriteLine("Gider adını girin: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Gider miktarını girin: ");
            decimal miktar = Convert.ToDecimal(Console.ReadLine());

            Gider yeniGider = new Gider(ad, miktar);
            giderler.Add(yeniGider);

            Console.WriteLine("Gider kaydedildi.");
        }
       
        public static void giderToplam(List<Gider> giderler)
        {
            Console.WriteLine("----- Kaydedilen Giderler -----");
            foreach (Gider gider in giderler)
            {
                Console.WriteLine($"Gider Adı: {gider.Ad}, Miktar: {gider.Miktar}");
            }
        }
        public static void vergiHesap()
        {
            //vergi hesaplama kod 
        }


        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("----- MENÜ -----");

                Console.WriteLine("1. Gider Girişi");

                Console.WriteLine("2. Giderler Toplamı");

                Console.WriteLine("3. Vergi Hesaplama");

                Console.WriteLine("4. Çıkış");

                Console.WriteLine("-----------------");

                Console.WriteLine("Lütfen seçiminizi yapın: ");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                   

                    case 1:
                        Console.WriteLine("Gider Girişi menüsüne hoş geldiniz.");
                        giderGiris();
                        break;

                    case 2:
                        Console.WriteLine("Giderler Toplamı menüsüne hoş geldiniz.");
                        giderToplam();
                        break;

                    case 3:
                        Console.WriteLine("Vergi Hesaplama menüsüne hoş geldiniz.");
                        vergiHesap();
                        break;

                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        devam = false;
                        break;

                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                        break;
                }

            }
        }

    }
}
