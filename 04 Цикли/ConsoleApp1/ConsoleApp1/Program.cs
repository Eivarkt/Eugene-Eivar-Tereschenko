Console.WriteLine("Завдання цикли");
while (true)
{
    Console.WriteLine("Введіть значення x");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введіть значення y");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine("Введіть значення z");
    double z = double.Parse(Console.ReadLine());

    Double x = x1 * Math.Pow(10, -3);
    Double s;

    s = Math.Sqrt(10 * (Math.Cbrt(x) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
    Console.WriteLine($"S={s}");
    Console.WriteLine("Продовжити роботу (yes/no)?");
    string command = Console.ReadLine();
    if(command == "no" || command == "No" || command == "n" || command == "N")
    {
        break;
    }
    Console.WriteLine("Продовжуємо роботу");
}
Console.ReadLine();