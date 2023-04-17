// Задайте двумерный массив из целых чисел.
// Найдите средне арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

using System;
using static System.Console;

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
   for (int j = 0; j < arr.GetLength(1); j++)
   {
    arr[i, j] = random.Next(1, 10);
    Write(arr[i, j] + " ");
   }
   WriteLine();
}
WriteLine("------------------");
WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Write($"{sum / arr.GetLength(0)}");
}
ReadLine();






