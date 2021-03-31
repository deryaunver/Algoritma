using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Metini Büyük Harfe Çevirme";

            Console.WriteLine("Bir metin giriniz:");
            string metin = Console.ReadLine();
       
            Console.WriteLine(metin.ToUpper());

            Console.ReadKey();

        }
    }
}
