// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int r = 2;
int c = 2;
int d = 2;
int[,,] array = new int[r, c, d];
Random random = new Random();

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        for (int k = 0; k < d; k++)
        {
            array[i, j, k] = random.Next(10, 99);
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
                    
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

