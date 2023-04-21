using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть сторони трикутника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("P= " + Answer(a, b, c));
            Console.ReadLine();
        }
        static int Answer(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}