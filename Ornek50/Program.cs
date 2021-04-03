using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin giriniz:");
            string metin = Console.ReadLine();

            for (int i = 0; i <=metin.Length; i++)
            {
                Console.WriteLine(metin.Substring(0,i));
            }
       
            Console.ReadKey();
        }
    }
}
