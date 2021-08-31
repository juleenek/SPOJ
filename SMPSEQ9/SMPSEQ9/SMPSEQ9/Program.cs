using System;
using System.Linq;

namespace SMPSEQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string line = Console.ReadLine();
            int[] arr1 = Array.ConvertAll<string, int>(line.Split(" "), int.Parse);

            int length2 = Convert.ToInt32(Console.ReadLine());
            string line2 = Console.ReadLine();
            int[] arr2 = Array.ConvertAll<string, int>(line2.Split(" "), int.Parse);


            var sum1 = arr1.Sum();
            var sum2 = arr2.Sum();

            if ((sum2 / length2) < (sum1 / length))
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < length2; i++)
                {
                    Console.Write(arr2[i] + " ");
                }
            }
        }
    }
}
