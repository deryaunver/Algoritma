using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Program.plusMinus(arr);

        }
        public static void plusMinus(List<int> arr)
        {

            int kacTanePozitif = 0;
            int kacTaneNegatif = 0;
            int kacTaneIsaretsiz = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)//pozitif
                {
                    kacTanePozitif++;
                }
                else if (arr[i] < 0)//negatif
                {
                    kacTaneNegatif++;
                }
                else// işaretsiz
                {
                    kacTaneIsaretsiz++;
                }
            }

            double hesaplaPozitifOran = kacTanePozitif / arr.Count;
            double hesaplaNegatifOran = kacTaneNegatif / arr.Count;
            double hesaplaIsatsizOran = kacTaneIsaretsiz / arr.Count;
        }

    }
}
