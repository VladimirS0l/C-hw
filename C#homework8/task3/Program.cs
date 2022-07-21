// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int rows = 4;
int columns = 4;
int[,] arrayFirst = GenerateArray(rows, columns);
int[,] arraySecond = GenerateArray(rows, columns);
int[,] array = new int[rows, columns];

Console.WriteLine("Массив номер один: ");
PrintArray(arrayFirst);
Console.WriteLine("Массив номер два: ");
PrintArray(arraySecond);
Console.WriteLine("Произведение двух матриц: ");
CompositionArray(arrayFirst, arraySecond, array);
PrintArray(array);

int[,] GenerateArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(1, 9);
        }
    }
    return arr;
}
void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write(arrayPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CompositionArray(int[,] arrayFirst, int[,] arraySecond, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayFirst[i, j] * arraySecond[i, j];
        }
    }
}



