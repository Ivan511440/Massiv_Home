// Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером: 2x2x2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


using System;
using static System.Console;

WriteLine("Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Write( $"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Write( $"Z({k})={array3D[i, j, k]}; ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while(temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
}

int count = 0;
for(int i = 0; i < array3D.GetLength(0); i++)
{
    for(int j = 0; j < array3D.GetLength(1); j++)
    {
        for(int k = 0; k < array3D.GetLength(2); k++)
        {
            array3D[x, y, z] = count;
            count++;
        }
    }
}


