// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Задайте число m в двумерном массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте число n в двумерном массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[3, 4];

Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int count = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    count++;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine("Среднее арифметическое столбца {0}: {1}", count,
    Math.Round(sum / array.GetLength(0), 1));
}
