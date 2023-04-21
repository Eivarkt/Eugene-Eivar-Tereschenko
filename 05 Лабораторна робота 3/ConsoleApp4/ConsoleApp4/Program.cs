Console.WriteLine("Завдання 1.1");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {i * i}");
}
Console.ReadLine();

Console.WriteLine("Завдання 1.4");
Console.WriteLine("Введіть кількість чисел для обчислення суми: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 2; i <= 2*n; i+=2)
{
    sum += i;
}
Console.WriteLine($"Відповідь: {sum}");
Console.ReadLine();