/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

bool palindrome(int number)
{
    int div = 1;
    while(number / div >= 10)
    {
        div *= 10;
    }
    while(number != 0)
    {
        int left = number / div;
        int right = number % 10;
        if(left != right)
        {
            Console.WriteLine("Заданное число не является паллиндромом");
            return false;
        }
        number = (number % div) /10;
        div /= 100;
    }
    Console.WriteLine("Заданное число паллиндром");
    return true;
}
    
palindrome(14212);
palindrome(12821);
palindrome(23432);