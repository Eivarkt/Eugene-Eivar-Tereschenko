Console.WriteLine("Завдання 3");
int a;
int b;
for (a = 1; a <= 10; a++)
{
    for (b = 1; b <= 10; b++)
    {
        Console.Write("{0,4}", a * b); //ввести кожне число з певним відступом
    }
    Console.WriteLine();
}
Console.ReadLine();