// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using System;
using static System.Console;

WriteLine("Введите размеры матриц и диапазон случайных значений: ");
int m = InputNumbers("Введите число строк 1-ой матрицы: ");
int n = InputNumbers("Введите число столбцов 1-ой матрицы (и строк 2-ой): ");
int p = InputNumbers("Введите число столбцов 2-ой матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
WriteLine($"Первая матрица: ");
WriteAraay(firstMatrix);

int[,] secomdMatrix = new int[n, p];
CreateArray(secomdMatrix);
WriteLine($"Вторая матрица; ");
WriteAraay(secomdMatrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMatrix, secomdMatrix, resultMatrix);
WriteLine($"Произведение первой и второй матриц: ");
WriteAraay(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secomdMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }

    }
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteAraay(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j =0; j < array.GetLength(1); j++)
     {
        Write(array[i, j] + " ");
     }  
     WriteLine();
   } 
}





