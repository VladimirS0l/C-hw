//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число число N: ");
int n = 1;
int m = Convert.ToInt32(Console.ReadLine());

for (int i = n; i <= m; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.Write(" - все чётные значения от 1 до ");
    Console.Write(m);
    Console.ReadKey();
    