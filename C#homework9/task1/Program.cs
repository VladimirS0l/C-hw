// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Все значения от M до N: {PrintNumbers(m, n)}");
Console.WriteLine($"Сумма элементов от M до N = {SumNumber(m, n)}");

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}

int SumNumber(int m, int n)
{
    if (m == n) return m;
    else return m + SumNumber(m + 1, n);
}

