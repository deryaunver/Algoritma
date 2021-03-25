using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "♥ Kullanıcıdan aldığı sayıyı dizi ile ekrana yazdırma ♥";
            int[] yazdır = new int[11];
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"lütfen {i}. sayıyı giriniz:");
                int sayiAl = int.Parse(Console.ReadLine());
                yazdır[i] = sayiAl;
            }

            for (int i = 1; i < yazdır.Length; i++)
            {
                Console.Write(yazdır[i]+" ");
            }

            Console.ReadKey();


        }
    }
}
