using System;

namespace Proste_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {

                string linia;

                while ((linia = Console.ReadLine()) != null)
                {
                    
                }


                string lan;
                long sumAll = 0;
                while (((lan = Console.ReadLine())) != null)
                {
                    long sum = 0;
                    string[] tab = lan.Split();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        sum += Convert.ToInt32(tab[i]);
                    }
                    sumAll += suma;
                    Console.WriteLine(sum);
                }
                Console.WriteLine(sumAll);


    }
    }
}
