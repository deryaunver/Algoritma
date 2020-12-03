using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-100 arası tam sayılardan 2 katının 1 fazlası" +
                              " 5 ile bölünen kaç sayı olduğunu bulma: ");

            Console.WriteLine("\t ############ \t");
            
            int yeniSayi;
            int toplamBolunen = 0;
            for (int i = 0; i < 13; i++)
            {
                yeniSayi = (i * 2) + 1;
                if (yeniSayi%5==0)
                {
                    toplamBolunen = toplamBolunen + 1;
                }
            }
            Console.WriteLine($"sonuc:{toplamBolunen}");

            Console.ReadKey();

        }
    }
}
