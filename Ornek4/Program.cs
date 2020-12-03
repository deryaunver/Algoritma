using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen bir tamsayının TEK yada ÇİFT olduğunu bulan kod parçası: ");
            Console.WriteLine("#################################################################");

            Console.WriteLine("Bir tamsayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi%2==0)
            {
                Console.WriteLine($"girdiğiniz sayi : {sayi} ÇİFTTİR!");
            }
            else
            {
                Console.WriteLine($"girdiğiniz sayi : {sayi} TEKTİR!!");
            }

            Console.ReadKey();
        }
    }
}
