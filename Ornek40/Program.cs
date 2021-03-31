using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek40
{
    class Program
    {
        static void Main(string[] args)
        {

            bool durum =true;
            while (durum)
            {
                Console.WriteLine("bir metin girin :");
                string metin = Console.ReadLine();
                if (metin.Length < 8)
                {
                    Console.WriteLine(" girilen metnin uzunluğu en az 8 karakter olmalıdır.");

                }
                else
                {
                    Console.WriteLine(metin.Substring(3, 5));
                    durum = false;
                }

            }

            Console.ReadKey();



        }
    }
}
