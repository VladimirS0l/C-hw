/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int length = 5;
int[] array = new int[length];
Random rnd = new Random();
int minNum = 99; //почему то, когда стоит значение array[0], он всегда выводит minNum = 0
int maxNum = array[0];
Console.Write("[");

for(int i = 0; i < length; i++)
{
    array[i] = rnd.Next(1, 99);
    Console.Write(array[i] + " ");
    if(array[i] < minNum)
    {
        minNum = array[i];
    }
    if(array[i] > maxNum)
    {
        maxNum = array[i];
    }   
}
Console.Write("]");
Console.WriteLine("\n\nmax: " + maxNum);
Console.WriteLine("min: " + minNum);
int res = maxNum - minNum;
Console.WriteLine("Разница между максимальным значением и минимальным равна: " + res);
