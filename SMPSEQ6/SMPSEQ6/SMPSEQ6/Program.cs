using System;

namespace SMPSEQ6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            string ArrInputS = Console.ReadLine();
            string ArrInputQ = Console.ReadLine();
            string[] DaneSplit = inputNumbers.Split(' ');
            string[] ArrS = ArrInputS.Split(' ');
            string[] ArrQ = ArrInputQ.Split(' ');
            int lengthArr = Convert.ToInt32(DaneSplit[0]);
            int x = Convert.ToInt32(DaneSplit[1]);
            if (x >= 0)
            {
                for (int i = 0; i < lengthArr; i++)
                {
                    for (int y = -x; y <= x && i + y > 0 && i + y < lengthArr; y++)
                    {
                        if (i + y < lengthArr)
                        {
                            if (i + y >= 0)
                            {
                                if (ArrS[i] == ArrQ[i + y])
                                {
                                    Console.Write($"{i + 1}" + " ");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.Write("");
            }
        }
    }
}
