using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Faktöriyel Hesaplama".ToUpper();
            Console.Write("Faktöriyeli hesaplatmak istediğiniz sayıyı giriniz: ");
            long sayi = Convert.ToInt64(Console.ReadLine());
            long faktHesapla = 1;
            for (int i = 1; i <=sayi; i++)
            {
                faktHesapla = faktHesapla * i;
            }
            Console.WriteLine($"{sayi} Sayısının Faktöriyeli: {faktHesapla}");
            Console.ReadKey();
        }
    }
}
