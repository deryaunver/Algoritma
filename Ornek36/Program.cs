using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek36
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Rakam-Ay Karşılığı";
            string[] aylar = new string[]
            {
                "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım",
                "araralık"
            };
         
            bool durum = true;
            while (durum)
            {
              
                string ayAdi = "";
                Console.WriteLine("1 İLE 12 arası bir değer giriniz:");
                int deger = int.Parse(Console.ReadLine());
                // char deger = Console.ReadKey(true).KeyChar;
                bool kontrol = (deger >= 1 && deger <= 12);
                if (kontrol == false)
                {
                    durum = false;
                }
                else
                {
                    ayAdi = aylar[deger - 1];
                    Console.WriteLine(ayAdi);
                    //for (int i = 0; i < aylar.Length; i++)
                    //{
                    //    Console.WriteLine($"{aylar[i]} ---> {i+1}.Ay \n");
                    //}


                }
                Console.WriteLine("devam etmek için [e] ye basınız:");
                char devam = Console.ReadKey().KeyChar;
                if (devam == 'e' || devam == 'E')
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }

            }

            Console.ReadKey();



        }
    }
}
