using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sayıyı tekrarlatarak yazdırma";
            Console.WriteLine("Bir sayı giriniz: ");
            long sayi = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <=(2*sayi); i++)
            {
                Console.WriteLine($"{i}.kere yazıldı : {sayi}");
            }

            Console.ReadKey();
        }
    }
}
