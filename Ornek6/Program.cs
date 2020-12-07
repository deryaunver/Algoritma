using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 haneli bir tamsayının birler,onlar ve yuüzler hanesini bulan kod parçası:( Basamak Değeri Bulma ) ");
            Console.WriteLine("#################################################################\n");

            Console.WriteLine("3 Haneli bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("BASAMAK ANALİZİ: \n");

            int yuzler;
            yuzler = (sayi / 100) * 100;
            Console.WriteLine($"YÜZLER: {yuzler}");

            int onlar;
            onlar = ((sayi - yuzler) / 10) * 10;
            Console.WriteLine($"ONLAR:{onlar}");

            int birler;
            birler = (sayi - yuzler) - onlar;
            Console.WriteLine($"BİRLER:{birler}");

            Console.ReadKey();
        }
    }
}
