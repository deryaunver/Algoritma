using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen İki Sayının Toplamını Bulan Kod Parçası ");
            Console.WriteLine("###############################################");

            Console.Write("1.Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc;
            sonuc = sayi1 + sayi2;
            Console.WriteLine($"Sonuc:{sonuc}");

            Console.ReadKey();


        }
    }
}
