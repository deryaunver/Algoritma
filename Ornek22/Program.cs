using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Üçgen alan hesabı";
            Console.Write("ÜÇGENİN TABAN UZUNLUĞUNU GİRİNİZ: ");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("ÜÇGENİN YÜKSEKLİĞİNİ GİRİNİZ: ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            int hesapla =( taban * yukseklik) / 2;
            Console.WriteLine($"Üçgenin alanı :{hesapla}");
            Console.ReadKey();
        }
    }
}
