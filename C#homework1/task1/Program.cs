﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число число: ");
string a = Console.ReadLine();
int intA = Convert.ToInt32(a);
Console.WriteLine("Введите второе число число: ");
string b = Console.ReadLine();
int intB = Convert.ToInt32(b);

if(intA > intB)
{
    Console.Write("Первое число ");
    Console.Write(intA);
    Console.Write(" больше второго числа ");
    Console.Write(intB);
}
else
{
    Console.Write("Второе число ");
    Console.Write(intB);
    Console.Write(" больше первого числа ");
    Console.Write(intA);
}
