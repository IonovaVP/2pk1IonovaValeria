namespace Pz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            for (int i = 80; i >= 20; i-=4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Задание 2:");
            for (char simvol = 'G'; simvol <= 'K' ; simvol ++)
            {
                Console.Write(simvol);
            }

            Console.WriteLine("Задание 3:");
            for (var a = 0; a < 6; a ++)
            {
                for (var b = 0; b < 5; b ++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание 4:");
            for (int h = -900; h <= 500; h++)
                if (h % 6 == 0)
                {
                    Console.WriteLine(h);
                }

            Console.WriteLine("Задание 5:");
            for (int o = 4, p = 40; Math.Abs(o-p)!=24; o++, p--)
            {
                Console.WriteLine("{0} {1}", o,p);
            }

        }
    }
}