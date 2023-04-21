using System.Runtime.CompilerServices;

Console.WriteLine("Завдання 4.2");
Console.WriteLine("Введіть номер дня тижня");
int a = int.Parse(Console.ReadLine());
switch (a)
        {
        case 1: Console.WriteLine("Понеділок");
            break;
        case 2: Console.WriteLine("Вівторок");
            break;
        case 3:
            Console.WriteLine("Середа");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("П'ятниця");
            break;
        case 6:
            Console.WriteLine("Субота");
            break;
        case 7:
            Console.WriteLine("Неділя");
            break;
        default: Console.WriteLine("Невірний номер");
            break;
    }
Console.ReadLine();

Console.WriteLine("Завдання 4.4");
Console.WriteLine("Введіть команду: „у”- продовжити роботу, „п” - завершити.");
char command = char.Parse(Console.ReadLine());
switch (Char.ToLower(command))
{
    case 'у': Console.WriteLine("Продовжуємо роботу програми");
        break;
    case 'п': Console.WriteLine("Програму завершено");
        break;
    default: Console.WriteLine("Невірна команда");
        break;
}