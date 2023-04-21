Console.WriteLine("Завдання 2");
Console.WriteLine("Введіть суму вкладу: ");
decimal deposit = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введіть кількість місяців: ");
int months = Convert.ToInt32(Console.ReadLine());
decimal interestRate = 0.06m;
int i = 1;
while (i <= months)
{
    deposit += deposit * interestRate /12;
    i++;
}
Console.WriteLine($"Кінцева сума вкладу: {deposit}");
Console.ReadLine();