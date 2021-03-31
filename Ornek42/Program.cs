using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Çekiliş Programı";
            ArrayList liste = new ArrayList();
            string[] katilimcilar =
                {"Derya", "Emrah", "Evren", "Duygu", "Nurgül", "Şakir", "Fatih", "Ayşenur", "Nursel", "Yavus"};


            liste.AddRange(katilimcilar);
            Random random = new Random();
            int endex = 0;
            int x = 0;

            string[] kazananlar = new string[4];
            for (x = 0; x <= 2; x++)
            {
                endex = random.Next(0, katilimcilar.Length - 1);
                kazananlar[x] = katilimcilar[endex].ToString();
                liste.RemoveAt(endex);
            }

            for (x = 0; x <= 2; x++)
            {
                Console.WriteLine(x + 1 + ".talihli:" + kazananlar[x]);
            }

            Console.ReadKey();

        }

    }
}
