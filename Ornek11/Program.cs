using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "♣ IF - ELSE İLE 4 İSLEM ♣";
            //if-else ile 4 işlem yapma:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.SAYIYI GİRİNİZ: ");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("2.SAYIYI GİRİNİZ: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yapacak olduğunuz işlemi giriniz:\n" +
                              "\t1-)TOPLAMA\n" +
                              "\t2-)ÇIKARMA\n" +
                              "\t3-)ÇARPMA\n" +
                              "\t4-)BÖLME");
            char secim = Console.ReadKey(true).KeyChar;
            double sonuc = 0.0;
            string islem = "";
            if (secim=='1')
            {
                islem = "TOPLAMA;";
                sonuc = sayi1 + sayi2;
            }
            else if(secim=='2')
            {
                islem = "ÇIKARMA";
                sonuc = sayi1 - sayi2;
            }
            else if (secim == '3')
            {
                islem = "ÇARPMA";
                sonuc = sayi1 * sayi2;
            }
            else if (secim == '4')
            {
                islem = "BÖLME";
                sonuc = sayi1 / sayi2;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Seçmiş olduğunuz {islem} işleminin sonucu {sonuc} !!");


            Console.ReadKey();


        }
    }
}
