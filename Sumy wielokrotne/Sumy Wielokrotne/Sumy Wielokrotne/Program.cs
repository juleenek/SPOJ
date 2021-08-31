using System;
using System.ComponentModel;

namespace Sumy_Wielokrotne
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            long sumaGlobalna = 0;
            
            while (true)
            {
                linia = Console.ReadLine();
                var tab = linia.Split(' ');
                long sumaLokalna = 0;
                for (int i = 0; i < tab.Length; i++)
                {
                    sumaLokalna += long.Parse(tab[i]);
                }

                sumaGlobalna += sumaLokalna;
                Console.WriteLine(sumaLokalna);
                Console.WriteLine(sumaGlobalna);
            }

            



        }
    }
}
