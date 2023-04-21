using System;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число");
            double number = Convert.ToDouble(Console.ReadLine());
            Check(number);
            Console.ReadLine();
        }
        static void Check(double number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("Число парне");
            } else
            {
                Console.WriteLine("Число не парне");
            }
        }
    }
}