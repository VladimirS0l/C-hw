/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*Console.WriteLine("Введите координаты первой точки A(x, y, z): ");
double xA = Convert.ToInt32(Console.ReadLine());
double yA = Convert.ToInt32(Console.ReadLine());
double zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки В(x, y, z): ");
double xB = Convert.ToInt32(Console.ReadLine());
double yB = Convert.ToInt32(Console.ReadLine());
double zB = Convert.ToInt32(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xB-xA, 2)+ Math.Pow(yB - yA, 2)+ Math.Pow(zB - zA, 2));

Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " +ab);*/

double coordinates (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double result = Math.Sqrt(Math.Pow(xB-xA, 2)+ Math.Pow(yB - yA, 2)+ Math.Pow(zB - zA, 2));
    return result;
}

double ab = coordinates(3,6,8,2,1,-7);
Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " +ab);

double ac = coordinates(7,-5,0,1,-1,9);
Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " +ac);


