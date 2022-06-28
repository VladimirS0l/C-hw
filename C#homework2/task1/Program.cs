/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*# Первый вариант
Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA % 100;
int numberC = (numberB - numberB % 10)/10;
Console.WriteLine(numberC);*/

Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

void outnumber(int numberA)
{
    int numberB = numberA % 100;
    int numberC = (numberB - numberB % 10)/10;
    Console.WriteLine(numberC);
}

outnumber(numberA);
