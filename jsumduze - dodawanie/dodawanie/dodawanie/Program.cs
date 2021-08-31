using System;
using System.Globalization;

namespace dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var iloscZestawow = int.Parse(Console.ReadLine());
            long suma = 0;

            for (int i = 1; i <= iloscZestawow; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");

                for (int j = 0; j <= 1; j++)
                {
                    var numbers = Convert.ToInt64(arr[j]);
                    suma += numbers;
                }

                Console.WriteLine(suma);
            }
        }
        
    }
}
