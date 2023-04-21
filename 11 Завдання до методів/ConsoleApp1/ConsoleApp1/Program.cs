Console.WriteLine("Завдання 1");
Console.WriteLine("Введіть перше число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть друге число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

sum(num1, num2);

Console.ReadLine();

static void sum(int x, int y)
{
    double sum = x + y;
    Console.WriteLine("Відповідь: " + sum);
}