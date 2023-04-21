using System.Diagnostics.Metrics;

Console.WriteLine("Завдання 2.3");
int[,] masiv = { {22, 33, 44, 55 }, { 66, 77, 88, 99 }, { 100, 111, 122, 133 } };
Console.Write("Мажмо масив:");
foreach(int ma in masiv)
{
    Console.Write(" " + ma);
}
Console.WriteLine(" ");

int number = 1;
double sum = 0;

for (int i = 0; i < masiv.GetLength(0); i++)
{
    for (int j = 0; j < masiv.GetLength(1); j++)
    {
        if (masiv[i,j] % 2 != 0)
        {
            sum += masiv[i,j];
            number++;
        }
    }
}

double average = sum / number;
Console.WriteLine("Середнє арифметичне непарних елементів масиву = " + average);
Console.ReadLine();

Console.WriteLine("Завдання 3.5");
int sum2 = 0;

for (int i = 0; i < masiv.GetLength(0); i++)
{
    for (int j = 0; j < masiv.GetLength(1); j++)
    {
        if (masiv[i, j] % 2 != 0)
        {
            sum2 += masiv[i, j];
        }
    }
}

Console.WriteLine("Сума непраних елементів масиву: " + sum2);
Console.ReadLine();