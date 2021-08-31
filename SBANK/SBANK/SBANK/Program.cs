using System;
using System.Collections.Generic;
using System.Text;

namespace SBANK
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder(); // optymalizacja 1 - zamiast Console.WriteLine
            int t = Convert.ToInt32(Console.ReadLine());

            if (t <= 5)
            {
                for (int tests = 0; tests < t; tests++)
                {
                    var slownikNumerow = new Dictionary<string, int>(); // optymalizacja 2
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 100000)
                    {
                        for (int accounts = 0; accounts < n; accounts++)
                        {
                            var addingString = Console.ReadLine();

                            if(slownikNumerow.ContainsKey(addingString))
                            {
                                slownikNumerow[addingString]++;

                            } else
                            {
                                slownikNumerow.Add(addingString,1);
                            }
                        }

                    }
                    //baza załadowana
                    string[] konta = new string[slownikNumerow.Keys.Count];
                    slownikNumerow.Keys.CopyTo(konta, 0);
                    Array.Sort(konta);

                    foreach (var numer in konta)
                    {
                        result.AppendLine($"{numer} {slownikNumerow[numer]}");
                    }
                    result.AppendLine();
                    Console.ReadLine();
                }

                Console.Write(result.ToString()); // jawne wypisanie wartości
            }
        }
    }
}
