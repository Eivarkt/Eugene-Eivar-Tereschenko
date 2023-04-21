using System.Security.Cryptography;

Console.WriteLine("Лабораторна робота 4 Варінат 21");

double f, x;
double a = 0.1, b = 2.5, c = 1.9, k = 0.2, h = 0.24;

Console.WriteLine("Завдання А");
x = a;

do
{
    if (x < c)
    {
        f = Math.Atan(2 * a + x);
    }
    else 
    {
        f = Math.Pow(Math.E, k * x);
    }
    Console.WriteLine($"x= {x}; f={f}");
    x += h;
} while (a <= x && x <= b);
Console.ReadLine();

Console.WriteLine("Завдання В");
for (int n = 1; n<14; n++)
{
    Console.WriteLine("Введіть значення X" +n);
    x = Convert.ToDouble(Console.ReadLine());
    if (x < c)
    {
        f = Math.Atan(2 * a + x);
    }
    else
    {
        f = Math.Pow(Math.E, k * x);
    }
    Console.WriteLine("f=" + f);
}
Console.ReadLine();