Console.WriteLine("Завдання 3.1");
int c;
Console.WriteLine("Введіть перше число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число");
int b = int.Parse(Console.ReadLine());
c = a;
while (c >= b)
{
    c -= b;
}
Console.WriteLine($"Відповідь: {c}");
Console.ReadLine();

Console.WriteLine("Завдання 3.4");
int sum = 0;
int count = 4;
while (count <= 100)
{
    sum += count;
    count += 4;
}
Console.WriteLine($"Відповідь: {sum}");
Console.ReadLine();