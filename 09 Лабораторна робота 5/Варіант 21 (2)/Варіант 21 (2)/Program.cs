Console.WriteLine("Варінат 21 (Завдання 2)");

Console.WriteLine("Введіть число m");
int m = int.Parse(Console.ReadLine());

int[,] masiv = new int[m, m];
Random numbers = new Random();
Console.WriteLine();

//Матриця та рандом числа
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        masiv[i, j] = numbers.Next(1, 100);                 //числа від 1 до 100
    }
}

Console.WriteLine($"Матриця з розмірами {m} на {m}: ");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(" " + masiv[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();

int d1 = 1;
int d2 = 1;
double d = 0;
for (int i = 0;i < m; i++)
{
    d1 *= masiv[i, i];
    d2 *= masiv[m-1-i,i];
    d = d1 + d2;
}
Console.WriteLine("Перша діагональ = " +d1);
Console.WriteLine("Друга діагональ = " +d2);
Console.WriteLine($"Добуток елементів по 2-м головним діагоналям = {d}");
Console.ReadLine();