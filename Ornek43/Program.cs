using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek43
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir metin giriniz: ");
            string metin = Console.ReadLine();

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    Console.Write(metin[i]);
                }
                else
                {
                    i++;
                }
            
               
            }

            Console.ReadKey();


        }
    }
}
