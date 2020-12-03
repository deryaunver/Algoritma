using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "♦ Ateş Ölçüm Testi(İF-ELSE/SWITCH-CASE) ♦";
            int vucutIsisi = 39;
            #region IF-ELSE ateş ölçüm
            //if (vucutIsisi==36)
            //{
            //    Console.WriteLine("Vücut ısınız 36 , Gayet NORMAL ");
            //}
            //else if (vucutIsisi==37)
            //{
            //    Console.WriteLine("Vücut ısınız 37 , NORMAL ");
            //}
            //else if (vucutIsisi==38)
            //{
            //    Console.WriteLine("Vücut ısınız 38 , Biraz YÜKSEK ");
            //}
            //else if (vucutIsisi == 39)
            //{
            //    Console.WriteLine("Vücut ısınız 39 , YÜKSEK ATEŞ !! DURUM RİSKLİ!! ");
            //}
            //else
            //{
            //    Console.WriteLine(" ♣ YANIYORSUN!! ♣"); 
            //}
            #endregion
            switch (vucutIsisi)
            {
                case 36:
                    Console.WriteLine("Vücut ısınız 36 , Gayet NORMAL ");
                    break;
                case 37:
                    Console.WriteLine("Vücut ısınız 37 , NORMAL ");
                    break;
                case 38:
                    Console.WriteLine("Vücut ısınız 38 , Biraz YÜKSEK ");
                    break;
                case 39:
                    Console.WriteLine("Vücut ısınız 39 , YÜKSEK ATEŞ !! DURUM RİSKLİ!! ");
                    break;
                default:
                    Console.WriteLine(" ♣ YANIYORSUN!! ♣");
                    break;
            }
            Console.ReadKey();
        }
    }
}
