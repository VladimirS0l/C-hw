// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(m, n));
Console.WriteLine();
int SumNumber(int m, int n)
{
    if(m == n) return m;
    else return m + SumNumber(m + 1, n);  
}
Console.WriteLine(SumNumber(m, n));
