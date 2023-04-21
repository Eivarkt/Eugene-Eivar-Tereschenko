Console.WriteLine("Завдання 3.1");

int[] masiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
Console.Write("Маємо масив: ");
foreach (int ma in masiv)
{
    Console.Write(" " + ma);
}
Console.WriteLine(" ");

for (int i=0; i<masiv.Length; i++)
{
    if (masiv[i] % 2 == 0)
    {
        masiv[i]=0;
    }
}
Console.Write("Змінений масив:");
foreach (int ma in masiv)
{
    Console.Write(" " + ma);
}
Console.WriteLine(" ");
Console.ReadLine();

Console.WriteLine("Завдання 3.4");
int[] masiv2 = { 242, 24, 12, 100, 34, 398, 132, 76, 32, 87, 70 };
Console.Write("Маєемо масив:");
foreach(int ma2 in masiv2)
{
    Console.Write(" " + ma2);
}
Console.WriteLine();

int max = masiv2[0];
int count = 0;

for (int i=1; i<masiv2.Length; i++)
{
    if (masiv2[i] > max)
    {
        max = masiv2[i];
        count = i;  
    }
}

Console.WriteLine("Максимальне число масиву: " + max);
Console.WriteLine("Його порядковий номер: " + count);
Console.ReadLine();
