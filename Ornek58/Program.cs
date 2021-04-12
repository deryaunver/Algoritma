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
            int[] dizi = {2, 4, 6, 8, 10};
            int hedef = 0;
            int gecici = 0;
            double sonuc = Convert.ToDouble(dizi.Length / 2) - 1;
            for (int i = 0; i <=sonuc; i++)
            {
                gecici = dizi[dizi.Length - 1-i];//10
                dizi[dizi.Length - 1 - i] = dizi[i];//10-->2
                dizi[i] = gecici;//2-->10
            }

            for (int i = 0; i <=dizi.Length-1; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.ReadLine();
        }
    }
}
