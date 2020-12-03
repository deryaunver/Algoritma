using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dikdörtgen alan çevre hesaplama".ToUpper();
            Console.WriteLine("Kenar 1 in değerinin giriniz:");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kenar 2 in değerinin giriniz:");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            int alan;
            int cevre;
            alan = kenar1 * kenar2;
            cevre = 2 * (kenar1 + kenar2);
            Console.WriteLine($"Alan:{alan}");
            Console.WriteLine($"Cevre{cevre}");
            Console.ReadKey();
        }
    }
}
