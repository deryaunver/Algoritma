using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime girin :");
            string kelime = Console.ReadLine();
            string kelimeDegisen="";
            int i = 0;
            for ( i = kelime.Length-1; i >=0; i--)
            {
                kelimeDegisen = kelimeDegisen + kelime.Substring(i, 1);
            }

            if (kelime==kelimeDegisen)
            {
                Console.WriteLine("Palindromdur");
            }
            else
            {
                Console.WriteLine("Palindrom değildir");
            }


            #region Yontem2
            //Console.Write("Bir kelime giriniz: ");
            //string kelime = Console.ReadLine();
            //string kelime_ters = "";
            //for (int i = kelime.Length - 1; i >= 0; i--)
            //{
            //    kelime_ters += kelime[i];
            //}
            //Console.WriteLine("\nKelimenin tersten yazılısı = " + kelime_ters);
            //if (kelime_ters == kelime)
            //{
            //    Console.WriteLine("\nGirilen kelime Palindromik bir kelimedir.");
            //}
            //else
            //{
            //    Console.WriteLine("\nGirilen kelime Palindromik bir kelime değildir.");
            //}
            //Console.ReadLine(); 
            #endregion
            #region Yontem3
            int a, b, toplam = 0, sayi;
            Console.Write("Bir sayı giriniz:");
            a = int.Parse(Console.ReadLine());
            sayi = a;
            while (a > 0)
            {
                b = a % 10;
                toplam = (toplam * 10) + b;
                a = a / 10;
            }
            if (sayi == toplam)
                Console.Write("Girdiğiniz sayı palindrom bir sayıdır.");
            else
                Console.Write("Girdiğiniz sayı palindrom bir sayı değildir.");
            #endregion
            Console.ReadLine();
        }
    }
}
