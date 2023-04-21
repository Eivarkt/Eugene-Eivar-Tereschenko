Console.WriteLine("Завдання 1.1");
int sum = 0;        
int input = 0;      
do
{
    Console.WriteLine("Введіть число");
    input = int.Parse(Console.ReadLine());      
    if (input > 0)
    {
        sum += input;
    }
} while (input != 0);
Console.WriteLine($"Відповідь: сума = {sum}");
Console.ReadLine();

Console.WriteLine("Завдання 1.4");
int count = 0;
int input2 = 0;
do
{
    Console.WriteLine("Введіть значення");
    input2 = int.Parse(Console.ReadLine());
    if(input2 < 0)
    {
        count++;
    }
}while (input2 != 0);
Console.WriteLine($"Відповідь: {count}");
Console.ReadLine();