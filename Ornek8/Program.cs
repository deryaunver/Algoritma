using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen Bir Sayının Tam Kare OLUP-OLMADIĞINI bulan kod parçası:");
            Console.WriteLine("################################################################");
            Console.WriteLine("Bir sayı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
          
            double B = Math.Sqrt(sayi);
            if (B*B==sayi)
            {
                Console.WriteLine("Tam kare");
            }
            else
            {
                Console.WriteLine("Tam kare değil");
            }
            Console.ReadKey();
        }
    }
}
