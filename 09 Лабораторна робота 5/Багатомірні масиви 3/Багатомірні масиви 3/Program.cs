using System.Diagnostics.Metrics;

Console.WriteLine("Завдання 3.2");
int[,] masiv = { {12, 23, 35, 42 }, { 53, 66, 74, 89 }, { 90, 10, 23, 56}, { 29, 13, 2, 97 } };
Console.Write("Маємо масив: ");
foreach (int ma in masiv)
{
    Console.Write(" " + ma);
}
Console.WriteLine(" ");

for (int i = 0; i < masiv.GetLength(0); i++)
{
    for (int j = 0; j < masiv.GetLength(1); j++)
    {
        if ((i * masiv.GetLength(1) +j) % 2 == 0)
        {
            masiv[i, j] = 0;
        }
    }
}

Console.Write("Змінений масив:");
foreach (int ma in masiv)
{
    Console.Write(" " + ma);
}
Console.WriteLine(" ");
Console.ReadLine();

Console.WriteLine("Завдання 3.3");
int[,] masiv2 = { { 12, 23, 35, }, { 53, 66, 74, }, { 90, 10, 23 } };
int sum = 0;
for (int i = 0; i < masiv2.GetLength(0); i++)
{
    sum += masiv2[i, 0];
}
Console.WriteLine("Сума елементів першого стовпчика = " + sum);
Console.ReadLine();