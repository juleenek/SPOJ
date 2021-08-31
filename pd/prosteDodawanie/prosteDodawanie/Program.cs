using System;

namespace prosteDodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // W pierwszym wierszu znajduje się liczba t testów (0 < t < 100) Każdy test opisany jest w następujący sposób. W pierwszym wierszu dana jest liczba n - liczba liczb do zsumowania. Następnie podanych jest n liczb pooddzielanych spacją.
            // 2
            // 5
            // 1 2 3 4 5
            // 2
            // -100 100 
            // Output
            // 15
            // 0

            var howMuchListNumbers = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= howMuchListNumbers; i++)
            {
                int suma = 0;
                var indexNumbers = int.Parse(Console.ReadLine());
                string[] linia = Console.ReadLine().Split(' ');
                // var numbers = Convert.ToInt32(linia);

                // var tab = new int[lenghtNumbers];

                for (int j = 0; j < indexNumbers; j++)
                {
                    var liczba = int.Parse(linia[j]);
                    suma += liczba;
                }

                Console.WriteLine(suma);
            }
        }

    }
}