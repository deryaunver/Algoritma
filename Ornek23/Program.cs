using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Daire alan-cevre hesabı ".ToUpper();
            Console.WriteLine("Dairenin yarıçapını belirleyiniz:".ToUpper());
            double yaricap = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            double alan= yaricap * yaricap * pi;
            double cevre = 2 * yaricap * pi;
            Console.WriteLine($"Cevre={cevre}");
            Console.WriteLine($"Alan={alan}");


            Console.ReadLine();

        }
    }
}
