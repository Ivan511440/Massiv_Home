// Напишите программу, которая заполнит спирально массив размером 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 15 16 06
// 10 09 08 07

using System;
using static System.Console;

WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1) ++j;
    else if (i < j && i + j >= size - 1) ++i;
        else if (i >= j && i + j > size - 1) --j;
        else
            --i;
        ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
    }
}


