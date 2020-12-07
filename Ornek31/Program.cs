using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek31
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = " Üçer Üçer Saydırma".ToUpper();
            Console.WriteLine("Başlangıç sayısını giriniz: ");
            long baslangic = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Bitiş sayısını giriniz: ");
            long bitis = Convert.ToInt64(Console.ReadLine());
            Console.Write($"\n{baslangic} - {bitis} arası Üçerli Saydırma: ".ToUpper());
            for (long i = baslangic; i <=bitis; i+=3)
            {
                Console.Write(i+" ");
            }

            Console.ReadKey();
        }
    }
}
