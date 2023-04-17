// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 → такого числа в массиве нет

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, columns];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.Write("Введите индекс строки нужного элемента: ");
int index_i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца нужного элемента: ");
int index_j = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < numbers.GetLength(i); i++)
{
    if (index_i == i+1)
    {
        for (int j = 0; j < numbers.GetLength(j); j++)
        {
            if (index_j == j+1)
            {
                Console.WriteLine($"Значение[{index_i}, {index_j}] элемента массива: {numbers[i, j]}");
            }
        }
    }
}

{
    if (index_i > numbers.GetLength(0) || index_j > numbers.GetLength(1))
    Console.WriteLine("Указанного элемента в массиве нет: ");
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


