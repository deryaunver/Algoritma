using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "10-100 arasında ki asal sayıları bulma";
            //asal sayı 1 ve kendinden başka sayıya bolunmeyecek 2 istisnadır
            for (int i = 10; i <=100; i++)
            {
                if (i%2!=0 && i%3!=0 && i%5!=0 && i%7!=0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
