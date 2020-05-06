using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0;
            Console.WriteLine("a: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dx: ");
            float dx = float.Parse(Console.ReadLine());
            double x = a + dx;
            Console.WriteLine("  x       y=f(x)\n");
            while (x <= b)
            {  
                res = (Math.Log10(x)) / (4 * x + 13);
                Console.WriteLine(Math.Round(x, 5) + "  |  "+ Math.Round(res, 5));
                x += dx;
            }
        }
    }
}
