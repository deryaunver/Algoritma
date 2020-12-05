using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek25
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 inç 2.54 cm
            Console.Title = "İnç uzunluğu santimetre uzunluğuna cevirme".ToUpper();
            Console.WriteLine("İnç türünden uzunluk giriniz");
            decimal incUzunluk = decimal.Parse(Console.ReadLine());
            decimal cmUzunuluk = 2.54M* incUzunluk;
            Console.WriteLine($"sonuc={cmUzunuluk}");
            Console.ReadLine();

        }
    }
}
