using System;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ім'я");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Name(name);
            Console.ReadLine();
        }
        static void Name(string name)
        {
            int count = 10;
            for (int i = 0; i < count; i++) { Console.WriteLine(name); }
        }
    }
}