using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "••• SANAL BEBEK ••• ";

            Bebek bebek = new Bebek();
            string[] menu = {"Besle","Uyut","Oynat","Çıkış"};
            Console.Write("Bebeğine bir isim ver :");
            bebek.ad = Console.ReadLine();
             bool durum = true;
            while (durum)
            {
                Console.WriteLine(MenuOlustur(menu));
                char secim = Console.ReadKey(true).KeyChar;

                switch (secim)
                {
                    case '1':
                        bebek.Besle();
                        break;
                    case '2':
                        bebek.Uyut();
                        break;
                    case '3':
                        bebek.Oynat();
                        break;
                    case '4':
                        Console.WriteLine("Çıkış yapmak istediğinize emin misiniz: [e/h]");
                        char cikis = Console.ReadKey(true).KeyChar;
                        if (cikis=='E'||cikis=='e')
                        {
                            durum = false;
                        }
                        else if(cikis == 'H' || cikis == 'h')
                        {
                            durum = true;
                        }
                        else
                        {
                            Console.WriteLine("geçersiz seçim yaptınız ...");
                        }
                        break;
                    default:
                        Console.WriteLine("geçersiz seçim tekrar seçim yapınız");
                        break;
                }
                Thread.Sleep(1000);
                Console.Clear();
                BebekDurumunuYaz(bebek);
              
            }



            Console.ReadKey();
        }
        static string MenuOlustur(string[]  menuler)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string menu = "\t ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺\n \n";

            for (int i = 0; i < menuler.Length; i++)
            {
                menu += $"\t {i + 1}-) {menuler[i]}  ";
            }
            menu += "\n\n \t ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺";

            return menu;
        }
        public static void BebekDurumunuYaz(Bebek bebek)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t \t Uyku:        \t {0}", bebek.Uyku );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t \t Enerji:\t {0}", bebek.Enerji);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t \t Açlık:        \t {0}", bebek.Aclik);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t \t Hijyen:\t {0}", bebek.Hijyen);
           
          
         
        }
    }
    class Bebek
    {
        private Random random = new Random();
        public string ad;
        private int uyku=50;
        private int aclik=50;
        private bool hayattaMi=true;
        private int enerji=50;
        private int hijyen=50;

        public int Uyku
        {
            get
            {
                return uyku;
            }
            set
            {
                if (uyku <= 0)
                    uyku = 0;
                else if (uyku >= 100)
                {
                    uyku = 100;
                    hayattaMi = false;
                }
                else
                    uyku = value;
            }
        }
        public int Enerji
        {
            get
            {
                return enerji;
            }
            set
            {
                if (enerji <= 0)
                {
                    enerji = 0;
                    hayattaMi = false;
                }
                else if (enerji >= 100)
                    enerji = 100;
                else
                    enerji = value;
            }
        }
        public int Hijyen
        {
            get
            {
                return hijyen;
            }
            set
            {
                if (hijyen <= 0)
                {
                    hijyen = 0;
                    hayattaMi = false;
                }
                else if (hijyen >= 100)
                    hijyen = 100;
                else
                    hijyen = value;
            }
        }
        public int Aclik
        {
            get
            {
                return aclik;
            }
            set
            {
                if (aclik <= 0)
                    aclik = 0;
                else if (aclik >= 100)
                {
                    aclik = 100;
                    hayattaMi = false;
                }
                else
                    aclik = value;
            }
        }


        public void Besle()
        {
            aclik -= random.Next(15);
            hijyen += random.Next(15);
            enerji += random.Next(15);
            uyku += random.Next(15);
        }
        public void Uyut()
        {
            aclik += random.Next(15);
            hijyen -= random.Next(15);
            enerji += random.Next(15);
            uyku -= random.Next(15);
        }
        public void Oynat()
        {
            aclik += random.Next(15);
            hijyen -= random.Next(15);
            enerji -= random.Next(15);
            uyku += random.Next(15);
        }
        public void Yıka()
        {
            aclik += random.Next(15);
            hijyen += random.Next(15);
            enerji += random.Next(15);
            uyku += random.Next(15);
        }
    }
    
}
