//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return 0;
}
Console.WriteLine("input x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y:");
int y = Convert.ToInt32(Console.ReadLine());

int result = FindQuart(x, y);
Console.WriteLine($"это {result} четверть");
*/

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

/*
double FindDist(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
}

Console.WriteLine("input coordinate x to a:");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate y to a:");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate x to b:");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate y to b:");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(FindDist(xa, ya, xb, yb));
*/

