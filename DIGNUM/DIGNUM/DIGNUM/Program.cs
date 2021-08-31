using System;
using System.Linq;

namespace DIGNUM
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Char[,] zero = {{' ', '_', ' '}, {'|', ' ', '|'}, {'|', '_', '|'}};
            Char[,] one = {{' ', ' ', ' '}, {' ', ' ', '|'}, {' ', ' ', '|'}};
            Char[,] two = {{' ', '_', ' '}, {' ', '_', '|'}, {'|', '_', ' '}};
            Char[,] three = {{' ', '_', ' '}, {' ', '_', '|'}, {' ', '_', '|'}};
            Char[,] four = {{' ', ' ', ' '}, {'|', '_', '|'}, {' ', ' ', '|'}};
            Char[,] five = {{' ', '_', ' '}, {'|', '_', ' '}, {' ', '_', '|'}};
            Char[,] six = {{' ', '_', ' '}, {'|', '_', ' '}, {'|', '_', '|'}};
            Char[,] seven = {{' ', '_', ' '}, {' ', ' ', '|'}, {' ', ' ', '|'}};
            Char[,] eight = {{' ', '_', ' '}, {'|', '_', '|'}, {'|', '_', '|'}};
            Char[,] nine = {{' ', '_', ' '}, {'|', '_', '|'}, {' ', ' ', '|'}};


            string inputLine1;
            string inputLine2;
            string inputLine3;
            string result = "";
            int checker = 0;
            

            while ((inputLine1 = Console.ReadLine()) != null)
            {

                char[] firstLine = inputLine1.ToCharArray();
                int lenght = inputLine1.Length;
                inputLine2 = Console.ReadLine();

                if (inputLine2 == null)
                    break;

                char[] secondLine = inputLine2.ToCharArray();
                int lenght2 = inputLine2.Length;
                inputLine3 = Console.ReadLine();

                if (inputLine3 == null)
                    break;

                char[] thirdLine = inputLine3.ToCharArray();
                int lenght3 = inputLine3.Length;

                for (int i = 0; i < i + 3 && i + 1 < lenght && i + 2 < lenght && i < lenght; i += 3)
                {
                    checker = result.Length;

                    if (inputLine1[i] == zero[0, 0] && inputLine1[i + 1] == zero[0, 1] &&
                        inputLine1[i + 2] == zero[0, 2])
                    {
                        if (inputLine2[i] == zero[1, 0] && inputLine2[i + 1] == zero[1, 1] &&
                            inputLine2[i + 2] == zero[1, 2])
                        {
                            if (inputLine3[i] == zero[2, 0] && inputLine3[i + 1] == zero[2, 1] &&
                                inputLine3[i + 2] == zero[2, 2])
                            {
                                result = result + "0";
                            }
                        }
                    }


                    if (inputLine1[i] == one[0, 0] && inputLine1[i + 1] == one[0, 1] && inputLine1[i + 2] == one[0, 2])
                    {
                        if (inputLine2[i] == one[1, 0] && inputLine2[i + 1] == one[1, 1] &&
                            inputLine2[i + 2] == one[1, 2])
                        {
                            if (inputLine3[i] == one[2, 0] && inputLine3[i + 1] == one[2, 1] &&
                                inputLine3[i + 2] == one[2, 2])
                            {
                                result = result + "1";
                            }
                        }
                    }

                    if (inputLine1[i] == two[0, 0] && inputLine1[i + 1] == two[0, 1] && inputLine1[i + 2] == two[0, 2])
                    {
                        if (inputLine2[i] == two[1, 0] && inputLine2[i + 1] == two[1, 1] &&
                            inputLine2[i + 2] == two[1, 2])
                        {
                            if (inputLine3[i] == two[2, 0] && inputLine3[i + 1] == two[2, 1] &&
                                inputLine3[i + 2] == two[2, 2])
                            {
                                result = result + "2";
                            }
                        }
                    }

                    if (inputLine1[i] == three[0, 0] && inputLine1[i + 1] == three[0, 1] &&
                        inputLine1[i + 2] == three[0, 2])
                    {
                        if (inputLine2[i] == three[1, 0] && inputLine2[i + 1] == three[1, 1] &&
                            inputLine2[i + 2] == three[1, 2])
                        {
                            if (inputLine3[i] == three[2, 0] && inputLine3[i + 1] == three[2, 1] &&
                                inputLine3[i + 2] == three[2, 2])
                            {
                                result = result + "3";
                            }
                        }
                    }

                    if (inputLine1[i] == four[0, 0] && inputLine1[i + 1] == four[0, 1] &&
                        inputLine1[i + 2] == four[0, 2])
                    {
                        if (inputLine2[i] == four[1, 0] && inputLine2[i + 1] == four[1, 1] &&
                            inputLine2[i + 2] == four[1, 2])
                        {
                            if (inputLine3[i] == four[2, 0] && inputLine3[i + 1] == four[2, 1] &&
                                inputLine3[i + 2] == four[2, 2])
                            {
                                result = result + "4";
                            }
                        }
                    }

                    if (inputLine1[i] == five[0, 0] && inputLine1[i + 1] == five[0, 1] &&
                        inputLine1[i + 2] == five[0, 2])
                    {
                        if (inputLine2[i] == five[1, 0] && inputLine2[i + 1] == five[1, 1] &&
                            inputLine2[i + 2] == five[1, 2])
                        {
                            if (inputLine3[i] == five[2, 0] && inputLine3[i + 1] == five[2, 1] &&
                                inputLine3[i + 2] == five[2, 2])
                            {
                                result = result + "5";
                            }
                        }
                    }

                    if (inputLine1[i] == six[0, 0] && inputLine1[i + 1] == six[0, 1] && inputLine1[i + 2] == six[0, 2])
                    {
                        if (inputLine2[i] == six[1, 0] && inputLine2[i + 1] == six[1, 1] &&
                            inputLine2[i + 2] == six[1, 2])
                        {
                            if (inputLine3[i] == six[2, 0] && inputLine3[i + 1] == six[2, 1] &&
                                inputLine3[i + 2] == six[2, 2])
                            {
                                result = result + "6";
                            }
                        }
                    }

                    if (inputLine1[i] == seven[0, 0] && inputLine1[i + 1] == seven[0, 1] &&
                        inputLine1[i + 2] == seven[0, 2])
                    {
                        if (inputLine2[i] == seven[1, 0] && inputLine2[i + 1] == seven[1, 1] &&
                            inputLine2[i + 2] == seven[1, 2])
                        {
                            if (inputLine3[i] == seven[2, 0] && inputLine3[i + 1] == seven[2, 1] &&
                                inputLine3[i + 2] == seven[2, 2])
                            {
                                result = result + "7";
                            }
                        }
                    }

                    if (inputLine1[i] == eight[0, 0] && inputLine1[i + 1] == eight[0, 1] &&
                        inputLine1[i + 2] == eight[0, 2])
                    {
                        if (inputLine2[i] == eight[1, 0] && inputLine2[i + 1] == eight[1, 1] &&
                            inputLine2[i + 2] == eight[1, 2])
                        {
                            if (inputLine3[i] == eight[2, 0] && inputLine3[i + 1] == eight[2, 1] &&
                                inputLine3[i + 2] == eight[2, 2])
                            {
                                result = result + "8";
                            }
                        }
                    }

                    if (inputLine1[i] == nine[0, 0] && inputLine1[i + 1] == nine[0, 1] &&
                        inputLine1[i + 2] == nine[0, 2])
                    {
                        if (inputLine2[i] == nine[1, 0] && inputLine2[i + 1] == nine[1, 1] &&
                            inputLine2[i + 2] == nine[1, 2])
                        {
                            if (inputLine3[i] == nine[2, 0] && inputLine3[i + 1] == nine[2, 1] &&
                                inputLine3[i + 2] == nine[2, 2])
                            {
                                result = result + "9";
                            }
                        }
                    }

                    
                }

                if (result.Length > checker)
                    result += Environment.NewLine;
            }

            Console.Write(result);
        }
    }
}
