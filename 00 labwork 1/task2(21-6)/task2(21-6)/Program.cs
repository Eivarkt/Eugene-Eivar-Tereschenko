Double x = 16.55*Math.Pow(10, -3);
Double y = -2.75;
Double z = 0.15;
Double s;

s = Math.Sqrt(10 * (Math.Cbrt(x) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2)-Math.Abs(x-y));
Console.WriteLine($"S={s}");
Console.ReadLine();