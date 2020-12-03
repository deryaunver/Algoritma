using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek18
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[] dizi= new int[4];
            int min;
            int max;
            double toplam = 0;
            double toplam2 = 0;
            Console.WriteLine("rasgele sayılar girin:");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine($"girilen rasgele  {i}.sayi {dizi[i]} ");
                toplam = toplam + dizi[i];
            }

            min = dizi[0];
            max = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (min>dizi[i])
                {
                    min = dizi[i];
                }
                if (max < dizi[i])
                {
                    max = dizi[i];
                }
            }
            Console.WriteLine($" min:{min} max: {max}");
            Console.WriteLine($"sayıların toplamı:{toplam}");
            double ortalama1 ;
               ortalama1 = (toplam) / 4;
            Console.WriteLine($"ortalama1: {ortalama1}");
            toplam2 = min + max;
            double ortalama2 = (toplam2) / 2;

            Console.WriteLine($"ortalama2: {ortalama2}");
            double sonuc = ortalama1 - ortalama2;
            Console.WriteLine($"ortalamaFark: {sonuc}");

            Console.ReadKey();
        }
    }
}
