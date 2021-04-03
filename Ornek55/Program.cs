using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Palindrom-Vektörel";
            Console.WriteLine("Bir cümle giriniz:");
            string cumle = Console.ReadLine();

            string tersCumle = "";

            for (int i = cumle.Length - 1; i >= 0; i++)
            {
                tersCumle += cumle[i];
            }

            if (cumle == tersCumle)
            {
                Console.WriteLine("Palindromdur");
            }
            else
            {
                Console.WriteLine("Palindrom değildir");
            }

            Console.ReadKey();
        }
    }
}
