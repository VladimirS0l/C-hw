/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

void СheckNumber2 (int  series)
{
  if (series == '0'||series == '1'||series == '2'
  ||series == '3'||series == '4'||series == '5'||series == '6'
  ||series == '7'||series == '8'||series == '9'||series == ','
  ||series == '-')
  {
  }
  else
  {
    Console.WriteLine($"Ошибка ввода  символа. Попробуй еще раз.");
  }
}

int[] ArrayOfNumbers(string seriesNew)
{ 
  int[] arrayOfNumbers = new int[1];
  int j = 0;
  for (int i = 0; i < seriesNew.Length; i++)
  {
    string seriesNew1 = "";
    while (seriesNew[i] != ',' && i < seriesNew.Length)
    {
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1); 
    if (i < seriesNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayOfNumbers;
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArray(arrayOfNumbers);*/

/*
void NewArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index < length)
  {
    collection[index] = new Random().Next(-100, 100);
    index++;
  }
}

int PrintArray(int[] randArray)
{
  int count = randArray.Length;
  int position = 0;
  while(position < count)
  {
    Console.Write(randArray[position] +", ");
    position++;
  }
  return position;
}

int[] array = new int[8];
NewArray(array);
PrintArray(array);
Console.WriteLine();*/

/*
int length = 8;
int[] newArray = new int [length];
Random rnd = new Random();

for (int i = 0; i < length; i++)
{
  newArray[i] = rnd.Next(-100, 100);
  Console.Write(newArray[i] + ", ");
}*/

