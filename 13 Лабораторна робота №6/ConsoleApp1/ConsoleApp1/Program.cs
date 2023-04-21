using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть три числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальне число: " + Maximum(a, b, c));
            Console.ReadLine();
        }
        static int Maximum(int a, int b, int c)
        {
            int[] masiv = new int[3];
            masiv[0] = a;
            masiv[1] = b;
            masiv[2] = c;
            return masiv.Max();
        }
    }
}
