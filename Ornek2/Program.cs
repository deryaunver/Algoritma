using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1'den 100'e kadar olan tam sayıların toplamını bulan kod parçası: ");
            Console.WriteLine("#################################################################");

            int sonuc = 0;
            for (int i = 0; i < 100; i++)
            {
                sonuc = sonuc + i;
            }
            Console.WriteLine($"işlem sonucunuz: {sonuc}");

            Console.ReadKey();
        }
    }
}
