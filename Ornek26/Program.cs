using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Mol sayısı Hesaplama ";
            Console.WriteLine("molekül ağırlığını girin: ");
            decimal molAgirlik = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kütleyi girin: ");
            decimal kutle = Convert.ToDecimal(Console.ReadLine());
            decimal molSayisi = kutle / molAgirlik;
            Console.WriteLine($"mol sayısı= {molSayisi}");
            Console.ReadKey();

        }
    }
}
