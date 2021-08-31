using System;

namespace Stozek
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long[] arr = Array.ConvertAll<string, long>(input.Split(" "), long.Parse);

            long r = arr[0]; // promień (R)
            long l = arr[1]; // tworząca (L)
            double h;
            double v;
            double vCeil;
            double vFloor;

            double rDouble = double.Parse(r.ToString());
            double lDouble = double.Parse(l.ToString());

            if (r < 0 || l < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }

            h = Math.Sqrt((double)(l * l) - (r * r));
            double hDouble = double.Parse(h.ToString());

            if (rDouble > lDouble || hDouble > lDouble + rDouble || rDouble > hDouble + lDouble || lDouble > hDouble + rDouble)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }
            else
            {

                if (h < 0)
                {
                    Console.WriteLine("ujemny argument");
                    return;
                }
                else if (double.IsNaN(h))
                {
                    Console.WriteLine("obiekt nie istnieje");
                    return;
                }
                else
                {
                    try
                    {
                        v = (double)(Math.PI * (double)(rDouble * rDouble) * (double)hDouble) / 3; // objętość stożka
                        vCeil = Math.Ceiling((double)v);
                        vFloor = Math.Floor((double)v);
                        if (vFloor >= 0 && vCeil >= 0) Console.WriteLine($"{(double)vFloor} {(double)vCeil}");
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("obiekt nie istnieje");
                        return;
                    }
                }
            }
        }
    }
}
