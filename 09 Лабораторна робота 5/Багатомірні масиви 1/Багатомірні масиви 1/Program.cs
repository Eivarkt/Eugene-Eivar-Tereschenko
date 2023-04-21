int[,] masiv = { { -2, -5, 8, 9 }, { 3, 6, -7, 2 }, { 6, -2, -9, -4 } };    //масив для завдання 1.2 та 1.4

Console.Write("Маємо масив: ");
foreach (int ma in masiv)
{
    Console.Write(" " + ma);
}
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("Завдання 1.2");
int count = 0;

for (int i = 0;i < masiv.GetLength(0); i++)
{
    for (int j = 0; j<masiv.GetLength(1); j++)
    {
        if (masiv[i,j]<0)
        {
            count++;
        } 
    }
}
Console.Write("кількість від’ємних елементів масиву: " + count);
Console.ReadLine();

Console.WriteLine("Завдання 1.4");
Console.WriteLine("Введіть число: ");
int x = int.Parse(Console.ReadLine());
int count2 = 0;

for (int i = 0; i < masiv.GetLength(0); i++)
{
    for (int j = 0; j < masiv.GetLength(1); j++)
    {
        if (masiv[i, j] == x)
        {
            count2++;
        }
    }
}
Console.WriteLine($"Число {x} зустрічається {count2} разів");
Console.ReadLine();
