/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-99, 99);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int sumOddNum(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    int sumNum = 0;
    while(index < count)
    {
        if(index % 2 != 0)
        {
            Console.Write(collection[index] +" ");
            position++;
            sumNum = sumNum + collection[index];
        }
        index++;
    }
    return sumNum;
}

int[] array = new int[4];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = sumOddNum(array);
Console.WriteLine("\n\nСумма нечетных элементов: " +pos);