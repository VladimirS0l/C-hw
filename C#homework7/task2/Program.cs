// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задайте строку в двумерном массиве: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Задайте столбец в двумерном массиве: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int m = 3;
int n = 4;
int[,] array = new int[m, n];
Random rnd = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
if(pos1 < 0 | pos1 > m - 1 | pos2 < 0 | pos2 > n - 1)
{
    Console.WriteLine("Выбранный элемент не существует в двумерном массиве");
}
else
{
    Console.WriteLine("Значение выбранного элемента массива: " +array[pos1, pos2]);
}

