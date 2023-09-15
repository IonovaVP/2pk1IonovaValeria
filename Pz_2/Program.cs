using System;

namespace Pz_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            double d;
            double n;
            double e = 2.718;
            double k;
            double m;

            Console.WriteLine("Введите c:");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите d:");
            d = Double.Parse(Console.ReadLine());

            Console.WriteLine("n:");
            if (c > 5)
            {
                Console.WriteLine(n = Math.Pow(c, 2) + Math.Sin(c * d) + Math.Sqrt(Math.Abs(c)));
            }
            else 
            {
                Console.WriteLine(n = d * Math.Cos(c * d) + 1/Math.Sqrt(Math.Abs(c)));
            }

            Console.WriteLine("m:");

            if (n <= 2)
            {
               
                Console.WriteLine(m = Math.Pow(e,c) + Math.Pow(Math.Sin(c * n + d),2));
            }
            else
            {
               
                Console.WriteLine(m = c * Math.Cos(5/(n - 3)));
            }

            k = 20 * d + 10 * n - (m + n) / 2;

            Console.WriteLine("k:");
            Console.WriteLine(k);  
        }
    }
}