using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1");
            Console.WriteLine("Введіть перше число");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть третє число");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Максимальне значення: " + Max(num1, num2, num3));
            Console.ReadLine();
        }
        static double Max(double num1, double num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        static double Max(double num1, double num2, double num3)
        {
            return Max(Max(num1, num2), num3);
        }
    }
}





