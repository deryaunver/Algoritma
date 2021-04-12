using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Doğrusal Arama ";
            //aranan=2;
            int[] dizi = {1, 2, 3, 4, 5};
           int aranan = 4;
           for (int i = 0; i < dizi.Length; i++)
           {
               if (aranan==dizi[i])
               {
                   Console.WriteLine(i);
               }
           }

           Console.ReadKey();
        }
    }
}
