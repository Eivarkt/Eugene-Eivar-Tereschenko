Console.WriteLine("Завдання 4");
while (true)
{
    Console.WriteLine("Введіть перше число (від 0 до 10):");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть друге число (від 0 до 10):");
    int b = int.Parse(Console.ReadLine());
    if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
    {
        int answer = a * b;
        Console.WriteLine($"Результат множення: {answer}");
        break;
    }
    else
    {
        Console.WriteLine("Введені числа неприпустимі, спробуйте ще раз.");
    }
}