Console.WriteLine("Завдання 2.1");
int[] masiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
Console.Write("Маємо масив: ");
foreach (int ma in masiv)
{
    Console.Write(" " +ma);
}
Console.WriteLine(" ");
int number = 0;
int sum = 0;
foreach(int i in masiv)
{
    if (i % 2 != 1)
    {
        sum += i;
        number++;
    }
}
double average = sum/number;
Console.WriteLine("Середнє арифметичне непарних елементів масиву = " + average);
Console.ReadLine();

Console.WriteLine("Завдання 2.4");
int[] height = { 167, 172, 180, 192, 175, 174, 178, 173, 169, 177 };
int sum2 = 0;
int count = 0;

foreach(int number2 in height)
{
    sum2 += number2;
    count++;
}

double average2 = sum2 / count;
int pupils = 0;

foreach(int number2 in height)
{
    if(average2 < number2)
    {
        pupils++;
    }
}

Console.WriteLine("Середній зріст учнів: " + average2);
Console.WriteLine("Кількість унів, у яких ріст вище середньго: " +pupils);
Console.ReadLine();