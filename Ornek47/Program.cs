using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci Hesabı";

            Console.WriteLine("bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // Fibonacci: 0 1 1 2 3
            int sabit1 = 0;
            int sabit2 = 1;
            Console.Write($"{sabit1} {sabit2} " );
            Console.Write(sabit1+sabit2);
            int yenideger=0;
            int sonuc = 0;
  
            for (int i = 0; i < sayi; i++)
            {
                yenideger = sabit1 + sabit2;
                sabit1 = sabit2;
                sabit2 = yenideger;
                sonuc = yenideger + sabit1;
                Console.Write(" "+sonuc);
            }
            Console.ReadLine();
    
        }
    }
}
