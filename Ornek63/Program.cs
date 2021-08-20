using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek63
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    string[] dizi = {"elma", "armut", "portakal", "kizi"};
        //    int i = dizi.Length;
        //    while (i>0)
        //    {
        //        Console.WriteLine(dizi[--i]);
        //    }
        //    Console.ReadKey();

        //}
        public static string StringChallenge(string str)
        {

            string tersKelime = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                tersKelime += str[i];
            }
            if (str == tersKelime)
            {
                Console.WriteLine("Palindromdur");
            }
            else
            {
                Console.WriteLine("Palindrom değildir");
            }
            return str;

        }

        static void Main()
        {
            Console.WriteLine("Bir kelime giriniz:");
            Console.WriteLine(StringChallenge(Console.ReadLine()));
            Console.ReadKey();
        }
        
    }
}
