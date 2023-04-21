Console.WriteLine("Завдання 1");
Console.WriteLine("Введіть А");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть B");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть C");
double c = Convert.ToDouble(Console.ReadLine());
double d = Math.Pow(b, 2)-4*a*c;
if(d < 0)
{
    Console.WriteLine("Рівняння не має коренвів");
}
else if(d == 0)
{
    double x = (b * (-1)) / (2 * a);
    Console.WriteLine($"Система має один корінь - {x}");
}
else
{
    double x1 = (b * (-1) + Math.Sqrt(d)) / (2 * a);
    double x2 = (b * (-1) - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"Система має два корені - {x1}; {x2}");
}
Console.ReadLine();