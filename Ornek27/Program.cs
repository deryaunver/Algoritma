using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Birinci dereceden bir denklemin köklerini bulma";
            Console.WriteLine("1. Katsayıyı gir: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("2. Katsayıyı gir: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"denkleminiz:{a}x + {b}\n");
            decimal x = -1*(b / a);
            Console.WriteLine($"denkleminizin kökü={x}");
            Console.ReadKey();
        }
    }
}
