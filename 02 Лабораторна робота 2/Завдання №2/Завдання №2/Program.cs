Console.WriteLine("Завдання 2.1");
Console.WriteLine("Введіть значення x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення z:");
double z = double.Parse(Console.ReadLine());
double min = x;

if (y<min)
{
    min = y;
}

if (z < min)
{
    min = z;
}
Console.WriteLine($"Найменше число: {min}");
Console.ReadLine();

Console.WriteLine("Завдання 2.3");
Console.WriteLine("Введіть значення a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення c:");
double c = double.Parse(Console.ReadLine());

double yA=Math.Sin(a);
double yB=Math.Sin(b);
double yC=Math.Sin(c);

int count = 1;
if(yA!=yB)
{
    count++;
}
if(yA!=yC && yB!=yC)
{
    count++;
}
Console.WriteLine($"Кількість різних значень функції y=sinx, дорівнює {count}");
Console.ReadLine();

Console.WriteLine("Завдання 2.5");
Console.WriteLine("Введіть значення:");
double numeric = double.Parse(Console.ReadLine());
if(numeric>0)
{
    Console.WriteLine("Значення більше нуля");
}
else if(numeric==0)
{
    Console.WriteLine("Значення дорівнює нулю");
}
else
{
    Console.WriteLine("Значення меньше нуля");
}
Console.ReadLine();

Console.WriteLine("Завдання 2.7");
Console.WriteLine("Введіть значення a:");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення b:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення c:");
double c1 = double.Parse(Console.ReadLine());
double resoult;
if (a1<=b1 && a1<=c1)
{
    resoult = a1*Math.Min(b1,c1);
}
else if(b1<=a1 && b1<=c1)
{
    resoult = b1 * Math.Min(a1, c1);
}
else
{
    resoult = c1*Math.Min(a1, b1);
}
Console.WriteLine($"Добуток двох менших чисел дорівнює {resoult}");
Console.ReadKey();