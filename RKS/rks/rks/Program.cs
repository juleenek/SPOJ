using System;
using System.Linq;
using System.Collections.Generic;

namespace rks
{
    class Program
    {
        static void Main(string[] args)
        {
            var numWithCount = new Dictionary<int, int>();
            string inputNum = Console.ReadLine();

            int first = Convert.ToInt32(inputNum.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            int second = Convert.ToInt32(inputNum.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

            string inputLineNum = Console.ReadLine();

            List<int> allNumbers = new List<int>(Array.ConvertAll(inputLineNum.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse));


            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (!numWithCount.ContainsKey(allNumbers[i]))
                {
                    numWithCount.Add(allNumbers[i], allNumbers.FindAll(x => x == allNumbers[i]).Count);
                }
            }

            foreach (KeyValuePair<int, int> item in numWithCount.OrderByDescending(x => x.Value)) // "Definiuje parę klucz/wartość, która może być ustawiona lub pobrana"
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
