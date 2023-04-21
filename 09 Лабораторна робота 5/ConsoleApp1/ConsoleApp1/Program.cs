Console.WriteLine("Завдання 1.3");
Console.Write("Маємо масив: ");
int[] masiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int count = 0;
foreach (int ma in masiv)
{
    Console.Write(" " +ma);
}
Console.WriteLine(" ");
foreach(int i in masiv)
{
    if (i % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine("Кількість парних елементів в масиві: " + count);
Console.ReadLine();

Console.WriteLine("Завдання 1.5");
Console.WriteLine("Введіть число");
int[] masiv2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int num = int.Parse(Console.ReadLine());
bool find = false;
foreach (int ma2 in masiv2)
{
    if (ma2 == num)
    {
        find = true;
        break;
    }
}

if (find)
{
    Console.WriteLine($"Число {num} знайдено в масиві");
} else
{
    Console.WriteLine($"Число {num} не знайдено в масиві");
}
Console.ReadLine();