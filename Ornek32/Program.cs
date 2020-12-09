using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DÖRDERLİ GERİYE SAYDIRMA";
            Console.WriteLine("Başlangıç sayısını giriniz: ");
            long baslangic = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Bitis sayısını giriniz: ");
            long bitis = Convert.ToInt64(Console.ReadLine());
            Console.Write($"{bitis} - {baslangic} geriye saydırma: ");
            Console.WriteLine();
            for (long i =bitis; i >=baslangic; i-=4)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
