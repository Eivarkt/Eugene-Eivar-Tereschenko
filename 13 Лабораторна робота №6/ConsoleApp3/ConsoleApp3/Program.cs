using System;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть сторони трикутника:");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площа трикутника = " +Area(a, b, c));
            Console.ReadLine();
        }
        static double Area(double a, double b, double c)
        {
            double p = (a+b+c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}