using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogs_ödev
{
    internal class versıon_1
    {
        public giderKaydi()
        {
            //gider kayıt hesaplama 
        }

        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("----- MENÜ -----");

                Console.WriteLine("1. Gider Kaydı");

                Console.WriteLine("2. Gider Girişi");
               
                Console.WriteLine("3. Gideler Toplamı");
                
                Console.WriteLine("4. Vergi Hesaplama");
                
                Console.WriteLine("5. Çıkış");
                
                Console.WriteLine("-----------------");
                
                Console.WriteLine("Lütfen seçiminizi yapın: ");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Gider Kaydı menüsüne hoş geldiniz.");
                        break;

                    case 2:
                        Console.WriteLine("Gider Girişi menüsüne hoş geldiniz.");
                        break;

                    case 3:
                        Console.WriteLine("Gideler Toplamı menüsüne hoş geldiniz.");
                        break;

                    case 4:
                        Console.WriteLine("Vergi Hesaplama menüsüne hoş geldiniz.");
                        break;

                    case 5:
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
