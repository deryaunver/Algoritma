using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 İLE 100 arasındaki tamsayıların tek ve çift olanlarının ayrı ayrı toplamını bulan kod parçası: ");
            Console.WriteLine("#################################################################");

            int toplamCift = 0;
            int toplamTek = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i%2==0)
                {
                    toplamCift = toplamCift + i;
                }
                else
                {
                    toplamTek = toplamTek = i;
                }
            }
            Console.WriteLine($"Tek Toplamları: {toplamTek}");
            Console.WriteLine($"Çift Toplamları: {toplamCift}");

            Console.ReadKey();
        }
    }
}
