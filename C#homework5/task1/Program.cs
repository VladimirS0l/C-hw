/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/* Первый способ
int length = 4;
int[] array = new int[length];
Random rnd = new Random();
int evenNum = 0;
Console.Write("[");

for(int i = 0; i < length; i++)
{
    array[i] = rnd.Next(100, 999);
    Console.Write(array[i] + ", ");
    if(array[i] % 2 == 0)
    {
        evenNum++;
    }
}
Console.Write("]");
Console.WriteLine("\nКоличество четных числел в массиве равно: " +evenNum);
*/

//Второй способ

void fillArray(int[] array)
{
    int length = array.Length;
    int even = 0;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
        if(array[i] % 2 == 0)
        {
            even++;
        }
    }
    Console.WriteLine("\nКоличество четных числел в массиве равно: " +even);
}

void printArray(int[] col)
{
    int count = col.Length;
    Console.Write("[");
    for(int j = 0; j < count; j++)
    {
        Console.Write(col[j] + " ");
    }
Console.Write("]");
}

int[] arr = new int[4];
fillArray(arr);
printArray(arr);



