using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Girilen Sayıların Küplerini Hesaplama".ToUpper();
            Console.WriteLine("Başlangıç sayısını giriniz: ");
            long baslangic = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Bitiş sayısını giriniz: ");
            long bitis = Convert.ToInt64(Console.ReadLine());
            long KupHesapla ;
            for (long i = baslangic; i < bitis; i++)
            {
                KupHesapla = i * i * i;
                Console.WriteLine($"{i}->Küpü: {KupHesapla}");
            }

            Console.ReadKey();
        }
    }
}
