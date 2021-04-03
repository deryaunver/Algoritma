using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Eşssiz sayılar";
            Random random = new Random();
             int [] sayilar = new int[6];// 3,5,0,0,0

             int atanan = 0;

             for (int i = 0; i < sayilar.Length; i++)
             {
                 while (true)
                 {
                     int esolamayan = 0;
                     int yeniSayi = random.Next(6);
                     for (int j = 0; j < atanan; j++)
                     {
                         if (yeniSayi!=sayilar[j])
                         {
                             esolamayan++;
                         }
                     }

                     if (atanan==esolamayan)
                     {
                         sayilar[i] = yeniSayi;
                         atanan++;
                         break;
                     }

                 }

               
             }
             for (int i = 0; i < sayilar.Length; i++)
             {
                 Console.Write(sayilar[i] + " ");
             }
            Console.ReadLine();
        }
    }
}
