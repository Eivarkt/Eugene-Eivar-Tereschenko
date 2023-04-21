Console.WriteLine("Завдання 1");
Console.WriteLine("Вкажіть значення X");
double x = Convert.ToInt32(Console.ReadLine());
double y = 7 * x - 3 * x + 6;
Console.WriteLine($"Зачення Y={y}");
Console.ReadKey();

Console.WriteLine("Завдання 2");
Console.WriteLine("Вкажіть перше значення");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вкажіть друге значення");
double b = Convert.ToInt32(Console.ReadLine());
double p = a + a + b + b;
double c = Math.Pow(a, 2) + Math.Pow(b, 2);
double d = Math.Sqrt(c);
Console.WriteLine($"Вiдповiдь: P={p}, D={d}");
Console.ReadKey();

Console.WriteLine("Завдання 3");
Console.WriteLine("Вкажіть кiлькiсть секунд");
double n = Convert.ToInt32(Console.ReadLine());
double a1 = n / 60;
double b1 = a1 / 60;
Console.WriteLine($"Вiдповiдь: {b1} годин");
Console.ReadKey();