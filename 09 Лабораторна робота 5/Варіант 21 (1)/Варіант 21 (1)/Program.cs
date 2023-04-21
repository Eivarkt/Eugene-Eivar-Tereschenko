Console.WriteLine("Варіант 21 (Завдання 1)");

int[] masiv = new int[100];
int count = 0;
double sum = 0;
int i;
double average = 0;

Console.WriteLine("Введіть число");

while (true)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        bool x = true;

        //Перевірка на просте число
        for (i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                x = false;
                break;
            }
        }

        //число просте = закриваємо цикл + рахуй середнє знач
        if (x)
        {
            average = sum / count;
            break;
        }

        masiv[count] = number;
        count++;
        sum += number;
    }

Console.WriteLine();

Console.WriteLine("Числа, які менші за середнє арифметичне масиву");
for (i = 0; i < count; i++)
{
    if (masiv[i] < average)
    {
        Console.Write(masiv[i]+ " ");
    }
}
Console.ReadLine();