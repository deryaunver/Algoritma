using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rasgele girilen 10 sayıdan negatif ve pozitif olanların sayısını bulma :");
            Console.WriteLine("###################################################################### \n ");
            int negatifSayiAdedi = 0;
            int pozitifSayiAdedi = 0;
            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine($"{i}. sayiyi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    negatifSayiAdedi = negatifSayiAdedi + 1;
                }
                else if (sayi > 0)
                {
                    pozitifSayiAdedi = pozitifSayiAdedi + 1;
                }

            }

            Console.WriteLine($"P.S.A: {pozitifSayiAdedi}");
            Console.WriteLine($"N.S.A: {negatifSayiAdedi}");
            Console.ReadKey();

        }
    }
}
