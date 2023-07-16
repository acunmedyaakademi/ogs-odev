using System;

class Program
{
    static void Main(string[] args)
    {
        bool cıkıs = false;

        while (cıkıs)
        {
            Console.WriteLine("1. Vergi hesapla");
            Console.WriteLine("2. Çıkış");
            Console.Write("Seçiminizi yapın (1 veya 2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                vergihespla();
            }
            else if (choice == "2")
            {
                cıkıs = true;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }

            Console.WriteLine();
        }
    }

    static void vergihespla()
    {
        Console.Write("Gelirinizi girin: ");
        double gelir = Convert.ToDouble(Console.ReadLine());

        Console.Write("Vergi oranını girin (%): ");
        double vergiorani = Convert.ToDouble(Console.ReadLine());

        double vergimiktarı = (gelir * vergiorani) / 100;

        Console.WriteLine("Vergi Miktarı: " + vergimiktarı);
    }
}