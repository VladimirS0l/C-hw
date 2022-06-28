/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


/*Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA>99)
{
    Console.WriteLine(numberA.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void something(int number)
{
    if(number>99)
    {
        Console.WriteLine(number.ToString()[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

something(number);









/*Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

void outnumber(int numberA)
{
    if(numberA % 100 != 0)
    {
        int numberB = numberA % 100;
        int numberC = numberB % 10;
        Console.WriteLine(numberC);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

outnumber(numberA);*/
