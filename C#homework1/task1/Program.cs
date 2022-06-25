//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("Первое число ");
    Console.Write(a);
    Console.Write(" больше второго числа ");
    Console.Write(b);
}
else
{
    Console.Write("Второе число ");
    Console.Write(a);
    Console.Write(" больше первого числа ");
    Console.Write(b);
}
