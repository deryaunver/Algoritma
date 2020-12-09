using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci Dizisi".ToUpper();
            // 0 1 1 2 3 5 8 11 ...
            int index0 = 0;
            int index1 = 1;
           
            Console.Write("Fibonacci dizisinin ilk kaç elemanı hesaplatılsın: ");
            int hesaplat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(index0);
            Console.WriteLine(index1);
            int yeniSayi;
            for (int i = 3; i <=10; i++)
            {
                yeniSayi = index0 + index1;
                Console.WriteLine(yeniSayi);
                index0 = index1;
                index1 = yeniSayi;

            }

            Console.ReadKey();
        }
    }
}
