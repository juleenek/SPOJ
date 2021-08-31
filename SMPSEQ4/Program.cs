using System;

namespace SMPSEQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            int[] arr1 = Array.ConvertAll<string, int>(s.Split(" "), int.Parse);
 
            var m = Convert.ToInt32(Console.ReadLine());
            var q = Console.ReadLine();
            int[] arr2 = Array.ConvertAll<string, int>(q.Split(" "), int.Parse);
 
            if (n >= 2 && n <= 100 && arr1.Length == n)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
 
 
                    if (arr1[i] >= -100 && arr1[i] <= 100)
                    {
                        int j;
 
                        for (j = 0; j < arr2.Length; j++)
                        {
                            if (arr1[i] == arr2[j])
                            {
                                Console.Write(arr1[i] + " ");
                            }
 
                        }
                    }
                }
            }
        }
    }
}
