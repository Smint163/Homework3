/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки X1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки X2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
    return result;
}

Console.WriteLine($"Расстояние между точками = {Distance(x1,y1,z1,x2,y2,z2)}");
