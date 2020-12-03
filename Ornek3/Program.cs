using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen 3 tamsayının  en büyüğünü bulan kod parçası : ");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("3 SAYI GİRİNİZ: ");

            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2 && sayi1>sayi3)
            {
                Console.WriteLine($" En büyük sayi SAYI 1 :{sayi1}");
            }
            else if(sayi2>sayi1 && sayi2>sayi3)
            {
                Console.WriteLine($" En büyük sayi SAYI 2 :{sayi2}");
            }
            else
            {
                Console.WriteLine($" En büyük sayi SAYI 3 :{sayi3}");
            }
            
            Console.ReadKey();
        }
    }
}
