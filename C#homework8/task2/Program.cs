// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите прямоугольный двумерный массив: ");
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
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

int countSum = 0;
int count = 0;
int sumMin = 99;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    count++;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }

    if (sum < sumMin)
    {
        sumMin = sum;
        countSum = count;
    }
    Console.WriteLine("Cумма элементов строки {0}: {1}", count, sum);
}
Console.WriteLine($"Наименьшая сумма строки {sumMin}, номер строки {countSum}");

