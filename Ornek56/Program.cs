using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lorem";
            string metin =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            char[] harfler = {'a', 'e', 'o', 'ı', 'u'};
            int[] harfSayilari = {0, 0, 0, 0, 0};

            for (int i = 0; i < harfler.Length; i++)// her harf için
            {
                for (int j = 0; j < metin.Length; j++)// birkez metini oku
                {
                    if (harfler[i]==metin[j])
                    {
                        harfSayilari[i]++;
                    }
                }
            }

            for (int i = 0; i < harfler.Length; i++)// harf sayısını ekrana yaz 
            {
                Console.WriteLine($"{harfler[i]} sayısı: {harfSayilari[i]}");
            }

            Console.ReadLine();
        }
    }
}
