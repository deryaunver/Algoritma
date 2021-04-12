using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Liste kullanmadan  girilen elemanları tersten yazdırma";
            string[] kelimeler= new string[0];
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Kelime girin:");
                string kelime = Console.ReadLine();
                Array.Resize(ref kelimeler, kelimeler.Length + 1);// diziyi her seferinde boyutlandırdık
                kelimeler[kelimeler.Length - 1] = kelime;
                if (kelime==" ")
                {
                    for (int i = kelimeler.Length-1; i>=0; i--)
                    {
                        Console.WriteLine(kelimeler[i]);

                    } 

                    durum = false;
                }

            }
          
            Console.ReadKey();

        }
    }
}
