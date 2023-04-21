Console.WriteLine("Завдання 1");
Console.WriteLine("Введіть суму вкладу:");
decimal deposit = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введіть кількість місяців:");
int months = Convert.ToInt32(Console.ReadLine());
decimal interestRate = 0.06m;
for (int i = 1; i <= months; i++)
{
    deposit += deposit * interestRate / 12;
}
Console.WriteLine($"Кінцева сума вкладу: {deposit}");
Console.ReadLine();

