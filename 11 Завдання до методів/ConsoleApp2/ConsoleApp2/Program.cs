using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Завдання 2");
Console.WriteLine("Введіть перше число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть друге число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Виберіть дію (+ або -)?");
char d = Convert.ToChar(Console.ReadLine());
int resoult;

if (d == '+')
{
    resoult = sum(num1, num2);
}
else if(d == '-')
{
    resoult = minus(num1, num2);
}
else
{
    Console.WriteLine("Відповідь невірна");
    return;
}

Console.WriteLine("Відповідь: " + resoult);
Console.ReadLine();

static int sum(int x, int y)
{
    return x + y;
}

static int minus(int x, int y)
{
    return x - y;
}