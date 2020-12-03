using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tkullanıcının girdiği sayıların toplamını yazan algoritma\n" +
                              "\talgoritma kullanıcı sıfır girene kadar girdiği sayıları toplasın\n" +
                              "\tve kullanıcı sıfır girdiğinde kullanıcıdan sayı alma işlemini kesip\n" +
                              "\tgirilen sayıların toplkamını ekrana yazdırsın...");
            Thread.Sleep(5000);
            Console.Clear();
       
            bool durum = true;
            int toplam = 0;
            do
            {
                Console.Write("SAYİ GİRİŞİ YAPIN: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi==0)
                {
                    toplam = toplam + sayi;
                    Console.WriteLine($" girdiğiniz sayıların toplamı  {toplam}");
                    durum = false;
                }
                else
                {
                    toplam = toplam + sayi;
                }
            } while (durum);

            Console.ReadKey();
        }
    }
}
