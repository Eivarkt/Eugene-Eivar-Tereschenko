using System.Globalization;

Console.WriteLine("Завдання Масиви");
Console.WriteLine(" ");
int[] massif = new int[9] { 56, 23, 2, 209, 78, 80, 34, 23, 99};
Console.Write("Маємо масив: ");
foreach (int i in massif)
{
    Console.Write($"{i} ");
}
Console.WriteLine(" ");
Console.WriteLine(" ");
int minNum = massif[0];
foreach (int num in massif)
{
    if (num < minNum)
    {
        minNum = num;
    }
}
Console.WriteLine("Мінімальне значення масиву: " + minNum);
int average = 0;
foreach(int num in massif)
{
    average += num;
}
average /= massif.Length;
Console.WriteLine("Середнє значення масиву: " + average);
Console.ReadLine();