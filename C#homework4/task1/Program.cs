/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double ab(double a, double b)
{
    double result = Math.Pow(a, b);
    Console.WriteLine(result);
    return result;
}
ab(3, 5);
ab(2, 4);
