using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть два числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uint= " +Func1(a, b));
            Console.WriteLine("Int= " + Func2(a, b));
            Console.WriteLine("Long= " + Func3(a, b));
            Console.ReadLine();
        }
        static uint Func1(int a, int b) => (uint)(a*b+1);
        static int Func2(int a, int b) => a*b+2;
        static long Func3(int a, int b) => a*b+3;
    }
}