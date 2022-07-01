/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for(int i = 1; i <= number; i++)
{
    array[i-1] = i * i * i;
    Console.WriteLine(array[i-1]);
}*/

int[] calculed(int number)
{
    int[] array = new int[number];
    int i = 1;
    while(i <= number)
        {
            array[i-1] = i * i * i;
            Console.WriteLine(array[i-1]);
            i++;
        }    
    return array;

}
calculed(3);
calculed(5);