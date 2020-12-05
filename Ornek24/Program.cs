using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Koni Hacmi Hesapla";
            Console.WriteLine("yarıçap belirleyiniz:");
            int yaricap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yükseklik belirleyiniz:");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            double hesapla = pi * yaricap * yaricap / yukseklik;
            Console.WriteLine($"Koni hacim= {hesapla}");
            Console.ReadLine();
        }
    }
}
