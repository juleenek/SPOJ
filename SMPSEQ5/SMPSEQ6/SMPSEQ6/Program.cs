using System;

namespace SMPSEQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            int[] arr1 = Array.ConvertAll<string, int>(s.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
            

            var m = int.Parse(Console.ReadLine());
            s = Console.ReadLine();
            int[] arr2 = Array.ConvertAll<string, int>(s.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (n >= 2 && n <= 100 && m >= 2 && m <= 100)
            {
                int lengthOutput = n;

                if (n > m)
                {
                    lengthOutput = m;
                }

                int[] output = new int[lengthOutput];
                int number = 0;

                for (int i = 0; i < lengthOutput; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        output[number] = i;
                        number++;
                    }
                }

                for (int i = 0; i < number; i++)
                {
                    Console.Write(output[i] + 1 + " ");
                }
            }

        }
    }
}
