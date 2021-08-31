 using System;

namespace KM001Z01
{
    class Program
    {
        static void Main(string[] args)
        {
            char starChar = '*';
            char dotChar = '.';


            string[] dane = Console.ReadLine().Split(" ");
            var inputChar = Convert.ToChar(dane[0]);
            

            if (inputChar == 'A') // Wzorek A
            {
                var m = Convert.ToInt32(dane[1]);
                var n = Convert.ToInt32(dane[2]);

                if (n >= 3 && m <= 100 && n <= 100 && m >= 3)
                {
                    if (n % 2 == 0) n = n + 1;
                    if (m % 2 == 0) m = m + 1; 

                    for (int i = 0; i < m - 1; i++)
                    {
                        Console.Write(starChar);
                    }

                    Console.WriteLine(starChar);

                    for (int i = 0; i < (n / 2) - 1; i++)
                    {
                        Console.Write(starChar);

                        for (int j = 0; j < (m / 2) - 1; j++)
                        {
                            Console.Write(dotChar);
                        }

                        Console.Write(starChar);

                        for (int j = (m / 2) + 1; j < m - 1; j++)
                        {
                            Console.Write(dotChar);
                        }

                        Console.WriteLine(starChar);
                    }

                    for (int i = 0; i < m - 1; i++)
                    {
                        Console.Write(starChar);
                    }

                    Console.WriteLine(starChar);

                    for (int i = 0; i < (n / 2) - 1; i++)
                    {
                        Console.Write(starChar);

                        for (int j = 0; j < (m / 2) - 1; j++)
                        {
                            Console.Write(dotChar);
                        }

                        Console.Write(starChar);

                        for (int j = (m / 2) + 1; j < m - 1; j++)
                        {
                            Console.Write(dotChar);
                        }

                        Console.WriteLine(starChar);
                    }

                    for (int i = 0; i < m - 1; i++)
                    {
                        Console.Write(starChar);
                    }

                    Console.WriteLine(starChar);
                }
            } else if (inputChar == 'B') // Wzorek B
            {
                var n = Convert.ToInt32(dane[1]);

                if (n >= 3 && n <= 100)
                {

                    for (int i = 0; i < n - 1; i++)
                    {
                        Console.Write(starChar);
                    }

                    Console.WriteLine(starChar);

                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write(dotChar);

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(dotChar);
                        }

                        Console.Write(starChar);

                        for (int j = 0; j < n - i - 3; j++)
                        {
                            Console.Write(dotChar);
                        }

                        Console.WriteLine(dotChar);
                    }

                    for (int i = 0; i < n ; i++)
                    {
                        Console.Write(starChar);
                    }
                }
            }
        }
    }
}
