using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " 1-10 arası sayılar çarpımı ";
            int carpım = 1;
            for (int i = 1; i < 11; i++)
            {
                carpım = carpım * i;
            }
            Console.WriteLine($"sonuc:{carpım}");
            Console.ReadKey();
        }
    }
}
