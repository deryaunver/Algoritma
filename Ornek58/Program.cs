using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dizi elemanlarını tersten yazdırma";
            int[] dizi = {1, 2, 3, 4, 5};
            int hedef = 0;
            int gecici = 0;
            for (int i = 0; i <=Convert.ToDouble(dizi.Length/2)-1; i++)
            {
                gecici = dizi[dizi.Length - 1]-i;
                dizi[dizi.Length - 1 - i] = dizi[i];
                dizi[i] = gecici;
            }

            for (int i = 0; i <=dizi.Length-1; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.ReadLine();
        }
    }
}
