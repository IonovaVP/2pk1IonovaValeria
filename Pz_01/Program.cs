namespace Pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = Math.PI / 2;
            double c = 2;
            double result;

            result = Math.Sqrt((a * b * c) / 2.4) - (0.7 * a * b * c) / Math.Sin(b) + Math.Pow(10, 4) * Math.Pow(Math.Abs(Math.Cos(b)), 1/5) - Math.Abs(b - a)/7.5;


            Console.WriteLine(result);
        }
    }
}