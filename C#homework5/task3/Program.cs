/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int length = 5;
double[] array = new double[length];
Random rnd = new Random();
double minNum = 99;
double maxNum = array[0];
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
double res = maxNum - minNum;
Console.WriteLine("Разница между максимальным значением и минимальным равна: " + res);
