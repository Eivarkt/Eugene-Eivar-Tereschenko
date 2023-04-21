Console.WriteLine("Завдання 3.1");
for (double x = -2; x <= 2; x += 0.5)
{
    double y = 3 * x + 2;
    Console.WriteLine($"x={x}, y={y}");
}
Console.ReadLine();

Console.WriteLine("Завадння 1.4");
Console.Write("Введіть кількість чисел: ");
int n = int.Parse(Console.ReadLine()); 
int neg = 0;
int pos = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write("Введіть значення: ");
    int x1 = int.Parse(Console.ReadLine());
    if (x1 > 0)
    {
        pos++;
    }
    else if (x1 < 0)
    {
        neg++;
    }
}
Console.WriteLine($"Кількість додатніх чисел: {pos}");
Console.WriteLine($"Кількість від'ємних чисел: {neg}");
