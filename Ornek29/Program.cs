using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "tAM BÖLÜNÜYOR MU?";
            Console.WriteLine("BİRİNCİ SAYIYI GİRİNİZ?");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iKİNCİ SAYIYI GİRİNİZ?");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            double sonuc=sayi1/sayi2;
            if (sonuc==0)
            {
                Console.WriteLine(" birinci sayı ikinci sayıya Tam bölünüyor!".ToUpper());
            }
            else
            {
                Console.WriteLine("birinci sayı ikinci sayıya Tam bölünmüyor".ToUpper());
            }

            Console.ReadKey();

        }
    }
}
