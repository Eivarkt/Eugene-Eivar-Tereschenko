Console.WriteLine("Завдання 3");
Console.WriteLine("Введіть переше число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть друге число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть третє число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
action(ref num1, ref num2, ref num3, out max);

Console.WriteLine($"Число {max} найбільше");
static void action(ref int num1, ref int num2, ref int num3, out int max)
{
    max = num1;
    if (num2 > max)
    {
        max = num2;
    }

    if (num3 > max)
    {
        max = num3;
    }
}
Console.ReadLine();