﻿// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
    else if (i < j && i + j >= array.GetLength(0) - 1) i++;
    else if (i >= j && i + j > array.GetLength(1) - 1) j--;
    else i--;
}

PrintArray(array);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] / 10 <= 0)
                Console.Write($" {arr[i, j]} ");

            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

