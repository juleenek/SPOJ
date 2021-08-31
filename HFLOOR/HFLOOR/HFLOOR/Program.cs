using System;
using System.Linq;

namespace HFLOOR
{
    class Program
    {
        static void Check(char[][] size, int j, int k, ref int person)
        {
            if (size[j][k] == 'x' || size[j][k] == '#') return;
            if (size[j][k] == '*') person++;
            size[j][k] = 'x';


            Check(size, j + 1, k, ref person); // top
            Check(size, j - 1, k, ref person); // bottom
            Check(size, j, k + 1, ref person); // right
            Check(size, j, k - 1, ref person); // left
        }
        static void Main(string[] args)
        {
            int testsNumber = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < testsNumber; i++)
            {
                int room = 0;
                int person = 0;

                string inputLine = Console.ReadLine();
                int[] inputArr = Array.ConvertAll<string, int>(inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

                int m = inputArr[0]; // height
                int n = inputArr[1]; // width

                char[][] sizeRoom = new char[m][];

                for (int j = 0; j < m; j++)
                {
                    sizeRoom[j] = new char[n];
                    sizeRoom[j] = Console.ReadLine().ToCharArray();
                }

                for (int j = 0; j < m; j++) // height
                {
                    for (int k = 0; k < n; k++) // width
                    {
                        if(sizeRoom[j][k] == '-' || sizeRoom[j][k] == '*')
                        {
                            room++;

                            Check(sizeRoom, j, k, ref person);
                            
                        }
                    }
                }

                double result = Math.Round(((double)person / room), 2);
                

                Console.WriteLine(result.ToString("0.00"));

                
            }
        }
    }
}
