using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Yuvalanmış Nesne Örneği";
            bool durum = true;
            string[] menuler =
            {
                "Servis Ekle", "Öğrenci Ekle", "Servis Görüntüle", "Öğrenci Görüntüle","Öğrenci Sil", "Servis Sil",
                "Çıkış Yap"
            };
            List<Servis>servisler= new List<Servis>();

            while (durum)
            {
                Console.WriteLine(Arayuz.MenuOlustur(menuler));
                char secim = Console.ReadKey().KeyChar;
                switch (secim)
                {
                    case '1':
                        Console.WriteLine("Servis ekleme");
                        Servis servis = new Servis();
                        Console.WriteLine("Servis Şoför Adı");
                        servis.SoforAd = Console.ReadLine();
                        Console.WriteLine("Servis Şoför Soyadı");
                        servis.SoforSoyad= Console.ReadLine();
                        Console.WriteLine("Servis Plaka");
                        servis.Plaka = Convert.ToInt32(Console.ReadLine());
                        servisler.Add(servis);
                        Console.WriteLine("Servis ekleme işlemi tamamlandı!!!");
                        break;
                    case '2':
                        if (servisler.Count<=0)
                        {
                            Console.WriteLine("KAYITLI SERVİD BULUNAMADI \n L" +
                                              "LÜTFEN SERVİS EKLEYİN!");
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));

                        }
                        Console.WriteLine(Arayuz.ServisGoruntule(servisler));
                        break;
                    case '3':
                     
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        Console.WriteLine("Çıkış yapmak istediğinize emin misiniz?[e/h]");
                        char cikis = Console.ReadKey().KeyChar;
                        if (cikis=='E'|| cikis=='e')
                        {
                            durum = false;
                        }
                        else if (cikis == 'H' || cikis == 'h')
                        {
                            Console.Clear();
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));
                        }
                        else
                        {
                            Console.WriteLine("\n \t Geçerli bir seçim yapmadınız!!!");
                            Console.Clear();
                            Console.WriteLine(Arayuz.MenuOlustur(menuler));
                        }
                        break;
                    default:
                        Console.WriteLine("LÜtfen Geçerli Bir Seçim Yapınız!");
                        break;
                }

            }
            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }

    class Servis
    {
        public Servis()
        {
            Ogrenciler = new List<Ogrenci>();
        }
        public int Plaka { get; set; }
        public string SoforAd { get; set; }
        public string SoforSoyad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

    }

    class Arayuz
    {
        //Menü oluşturma
        public static string MenuOlustur(string[] menuler)
        {
            string menu = "\t-----------------\n";
            for (int i = 0; i < menuler.Length; i++)
            {
                menu += $"\t{i + 1}->{menuler[i]}\n";
            }

            menu += "\t-----------------\n";
            return menu;

        }

        public static string ServisGoruntule( List<Servis> servis)
        {
            string cizgi = "\t-----------------\n";
            for (int i = 0; i < servis.Count; i++)
            {
                Console.WriteLine($"{servis[i].Plaka}\t{servis[i].SoforAd}\t{servis[i].SoforSoyad}");
            }

            cizgi += "\t-----------------\n";
            return cizgi;
        }
        
    }
}
