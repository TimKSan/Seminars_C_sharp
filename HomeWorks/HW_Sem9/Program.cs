// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNums(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        ShowNums(n - 1);
    }
}
ShowNums(5);
*/








// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
void SummFromMtoN(int M, int N)
{
    if (M < N)
    {
        SummFromMtoN(M, N - 1);
    }
    Console.Write((M + N) * (N - M + 1) / 2 + " ");
}

SummFromMtoN(1, 15);
*/







// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int Akkerman (int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.WriteLine(Akkerman(3, 4));
*/