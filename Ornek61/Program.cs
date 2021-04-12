using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek61
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Klavyeden girilen n tane kelimeyi tersten sıralayarak ekrana yazdırma (liste ile)";
            ArrayList liste = new ArrayList();
            string girilen = "";
            do
            {
                Console.WriteLine("Kelime Gir:");
                 girilen = Console.ReadLine();
                liste.Add(girilen);


            } while (girilen!="");

            liste.Reverse();// girileni ters çevirdi

            Console.WriteLine("Tersten yazdırma");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }

            Console.ReadKey();


        }
    }
}
