/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int sumNumbers(int num)
{
    int result = 0;
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    Console.WriteLine(result);
    return result;
}

sumNumbers(452);
sumNumbers(82);
sumNumbers(9012);