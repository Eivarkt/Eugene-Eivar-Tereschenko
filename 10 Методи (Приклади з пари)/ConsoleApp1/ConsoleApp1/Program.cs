static void Sum(int x, int y, out int a)
{
    a = x + y;
}
int x = 10;
int z;
Sum(x, 15, out z);
Console.WriteLine(z);
Console.ReadLine();