﻿Console.WriteLine("Вправа 1");

int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            Console.Write(mas[i, j, k] + " ");
        }
    }
    Console.WriteLine();
}
Console.ReadLine();