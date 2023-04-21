Console.WriteLine("Вправа 1");
Console.WriteLine("Введіть перше число: ");
int num1 = int.Parse(Console.ReadLine());        //int.parse - число у вигляді цілого
Console.WriteLine("Введіть друге число: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 == num2)
        {
    Console.WriteLine("Два числа рівні");
}
else if (num1 > num2)
{
    Console.WriteLine("Перше число більше другого");
}
else
{
    Console.WriteLine("Перше число менше другого");
}
Console.ReadLine();

Console.WriteLine("Вправа 2");
Console.WriteLine("Введіть число");
int a = int.Parse(Console.ReadLine());
if (a > 5 && a < 10)
{
    Console.WriteLine("Число більше 5 і меньше 10");
}
else
{
    Console.WriteLine("Невідоме число");
}
Console.ReadLine();

Console.WriteLine("Вправа 3");
Console.WriteLine("Введіть число");
int a1 = int.Parse(Console.ReadLine());
if(a1 == 5)
{
    Console.WriteLine("Число дорівнює 5");
}
else if(a1 == 10)
{
    Console.WriteLine("Число дорівнює 10");
}
else
{
    Console.WriteLine("Невідоме число");
}
Console.ReadLine();

Console.WriteLine("Вправа 4");
Console.WriteLine("Введіть суму вкладу");
double deposit = double.Parse(Console.ReadLine());          //double.parse - число з плаваючою комою
double b;                                                   //b - процентна ставка
if (deposit < 100)
{
    b = 0.05;
}
else if (deposit < 200)
{
    b = 0.07;
}
else
{
    b = 0.1;
}
double c = deposit * b;         //c - сума відсотків
double d = deposit * c;         //d - cума вкладу з нарахованими відсотками
Console.WriteLine($"Сума вкладу з нарахованими відсотками: {d}");
Console.ReadLine();

Console.WriteLine("Вправа 5");
Console.WriteLine("Введіть суму вкладу");
double deposit1 = double.Parse(Console.ReadLine());          //double.parse - число з плаваючою комою
double b1;                                                   //b - процентна ставка
if (deposit1 < 100)
{
    b1 = 0.05;
}
else if (deposit1 < 200)
{
    b1 = 0.07;
}
else
{
    b1 = 0.1;
}
double c1 = deposit1 * b1;
double d1 = deposit1 * c1 + 15;             //15 - бонуси
Console.WriteLine($"Сума вкладу з нарахованими відсотками та бонусами: {d1}");
Console.ReadLine();

Console.WriteLine("Вправа 6");
Console.WriteLine("Введіть номер опреації: 1.Складання 2.Віднімання 3.Умноження");
int operationNum = int.Parse(Console.ReadLine());
switch(operationNum)
{
    case 1: Console.WriteLine("Ви вибрали операцію складання");
            break;
    case 2: Console.WriteLine("Ви вибрали операцію віднімання");
            break;
    case 3: Console.WriteLine("Ви вибрали операцію умноження");
            break;
    default: Console.WriteLine("Неправельний номер операції");
            break;
}
Console.ReadLine();

Console.WriteLine("Вправа 7");
Console.WriteLine("Введіть номер опреації: 1.Складання 2.Віднімання 3.Умноження");
double operationNum1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть перше число");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число");
double number2 = double.Parse(Console.ReadLine());
switch (operationNum1)
{
    case 1:
        Console.WriteLine("Ви вибрали операцію складання");
        double answer1 = number1 + number2;
        Console.WriteLine($"Відповідь: {answer1}");
        break;
    case 2:
        Console.WriteLine("Ви вибрали операцію віднімання");
        double answer2 = number1 - number2;
        Console.WriteLine($"Відповідь: {answer2}");
        break;
    case 3:
        Console.WriteLine("Ви вибрали операцію умноження");
        double answer3 = number1 * number2;
        Console.WriteLine($"Відповідь: {answer3}");
        break;
    default:
        Console.WriteLine("Неправельний номер операції");
        break;
}
Console.ReadLine();