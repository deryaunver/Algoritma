using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Binary search";
            int[] dizi = {2, 4, 6, 8, 10, 12};
            Console.WriteLine(BinarySearchIterative(dizi, 8));
            var sonuc = BinarySearchIterative(dizi, 8);
            Console.WriteLine(dizi[sonuc]);
            
            Console.ReadKey();
        }
        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;//0
            int max = inputArray.Length - 1;//5
            int poz = -1;
            while (min <= max)
            {
                int mid = (min + max) / 2;//2
                if (key == inputArray[mid])
                {
                  // return inputArray[mid];// indisteki eleman 
                  return  mid;//indis
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }

}
