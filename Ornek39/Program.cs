using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Meitini belli kısımlarını yazdırma";

            Console.WriteLine("Bir metin değeri giriniz");
            string metin = Console.ReadLine();

            #region Yöntem1
            //for (int i = 0; i < metin.Length; i++)
            //{

            //    if (i == 6)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write(metin[i + 2]);
            //    }
            //}
            #endregion

            #region Yöntem2
            Console.WriteLine(metin.Substring(3, 5)); 
            #endregion

            Console.ReadKey();
        }
    }
}
