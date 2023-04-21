Console.WriteLine("Завдання 1");
Console.WriteLine("Введіть рік народження");
int yar = Convert.ToInt32(Console.ReadLine());
int a = 2023 - yar;
Console.WriteLine($"Ban {a} років");
Console.ReadKey();

Console.WriteLine("Завдання 2");
Console.WriteLine("Введіть перше число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть друге число");
int c = Convert.ToInt32(Console.ReadLine());
int d = Math.Max(b, c);
Console.WriteLine($"Число {d} більше");
Console.ReadKey();

Console.WriteLine("Завдання 3");
Console.WriteLine("Введіть перше число");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть друге число");
int c1 = Convert.ToInt32(Console.ReadLine());
int d1 = Math.Max(b1, c1);
int e = d1 + 1;
Console.WriteLine($"Відповідь: {e} ");
Console.ReadKey();

Console.WriteLine("Завдання 4");
Console.WriteLine("Введіть число в сантиметрах");
int a3 = Convert.ToInt32(Console.ReadLine());
int b3 = a3 * 100;
Console.WriteLine($"Відповідь: {b3} ");
Console.ReadLine();