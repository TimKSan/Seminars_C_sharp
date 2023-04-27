////////////////////////////////////// 1 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
bool NumIsPalin(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4) return true;
    return false;
}

Console.WriteLine("Input a five-digit number");
int num = Convert.ToInt32(Console.ReadLine());
bool result = NumIsPalin(num);

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Wrong number");
} 
else Console.WriteLine($"{num} -> {result}");
*/


////////////////////////////////////// 2 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double FindDist(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2)
                              + Math.Pow(yb - ya, 2)
                              + Math.Pow(zb - za, 2)), 2);
}

Console.WriteLine("input coordinate x to a:");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate y to a:");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate z to a:");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate x to b:");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate y to b:");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input coordinate z to b:");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between points A and B = {FindDist(xa, ya, za, xb, yb, zb)}");
*/


////////////////////////////////////// 3 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void ShowCubeOfNums(int num)
{
    int count = 1;

    while (count <= num) 
    {
    Console.WriteLine(Math.Pow(count, 3));
    count++;
    }
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
ShowCubeOfNums(num);
*/