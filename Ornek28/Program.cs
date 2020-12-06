using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Başarı Ölçümü";
            Console.WriteLine("Notunuzu giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not>=70)
            {
                Console.WriteLine("başarılısınız!!");
            }
            else
            {
                Console.WriteLine("Başarısızsınız!!!");
            }

            Console.ReadKey();
        }
    }
}
