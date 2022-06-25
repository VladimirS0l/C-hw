//Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число число: ");
int a = Convert.ToInt32(Console.ReadLine());
int max = a;
Console.WriteLine("Введите второе число число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.Write("Число: ");
Console.Write(max);
Console.Write(" является максимальным");


