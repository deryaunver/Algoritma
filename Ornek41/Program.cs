using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rasgele Sayı Üretmek";

            Random random = new Random();
            
            Console.WriteLine("zar 1: "+random.Next(1, 6)+" "+ "zar 2: " + random.Next(1, 6));
       
            Console.ReadKey();

        }
    }
}
