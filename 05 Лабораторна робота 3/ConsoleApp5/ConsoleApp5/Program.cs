Console.WriteLine("Завдання 2.3");
Console.WriteLine("Введіть значення N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введіть значення x: ");
int x = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= n; i++)
{
    int a = 2 * i;
    double b = Math.Pow(x, a);
    sum += Math.Log(b + 1, Math.E);
}

Console.WriteLine($"Вiдповідь: {sum}");
Console.ReadLine();

Console.WriteLine("Завдання 2.5");
Console.WriteLine("Введіть значення N: ");
int n1 = int.Parse(Console.ReadLine());
double sum1 = 0;
for (int i = 1; i <= n; i++)
{
    sum1 += 1.0 / (2 * i - 1);
}
Console.WriteLine($"Відповідь: {sum1}");
Console.ReadLine();