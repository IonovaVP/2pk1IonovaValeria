using System.Security.Cryptography;

namespace Pz_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case (<=10):
                Console.WriteLine("первая декада месяца");
                    break;

                case (<= 20):
                    Console.WriteLine("вторая декада месяца");
                    break;

                case (<= 31):
                    Console.WriteLine("третья декада месяца");
                        break;

                default:
                    Console.WriteLine("неправильная дата");
                    break;

            }
        }
    }
}