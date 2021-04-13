using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek63
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Açıklama-stack
            //Push = ekleme
            //Pop =en üstteki değeri okur ve bir değişkene atar.ve silinir
            //peek=dizinin en üstündeki elemanı öğrenmesilme yapmaz
            //substring > belli aralıkları alma(metinin i sinden başla 1 tane al(i,1))
            #endregion
            Console.Title = "Klavyeden girilen elamnları tersten yazdırma(Stack-Yığın İle)";

      
            Stack harfler = new Stack();
            string harf = "";
            int hedef = 0;
            Console.WriteLine("Bir metin girin:");
            string metin = Console.ReadLine();

          
      
            for (int i = 0; i < metin.Length; i++)
            {
                harf = metin.Substring(i,1);
                harfler.Push(harf);
            }

            hedef = harfler.Count;
            for (int i = 0; i <hedef; i++)
            {
                Console.WriteLine(harfler.Pop());
            }

            Console.ReadKey();

        }
    }
}
