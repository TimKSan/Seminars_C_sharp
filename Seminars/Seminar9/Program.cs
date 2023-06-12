//Задача 1. Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

/*
void ShowNums(int n)
{
    if (n > 0)
    {
        //Console.Write(n + " ");
        ShowNums(n - 1);
        Console.Write(n + " ");
    }
}

ShowNums(5);
*/

//Задание 2. Напишите программу, которая будет принимать на 
//вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

/*
int FindSum(int num)
{
    if (num > 0)
    {
        return FindSum(num / 10) + num % 10;
    }
    else return num;
}
Console.WriteLine(FindSum(453));
*/





//Задача 3. Задайте значения M и N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

/*
void ListNum(int N, int M)
{
    if (N > M)
    {
        ListNum(N - 1, M);
        Console.Write(N + " ");
    }
    else if (N < M)
    {
        ListNum(M - 1, N);
        Console.Write(M + " ");
    }
    else Console.WriteLine(N);
}


ListNum(15, 10);
*/


//Задача 4.Напишите программу, которая на вход принимает два 
//числа A и B, и возводит число А в целую степень B с помощью рекурсии.

/*
int Stepen(int a, int b)
{
    if (b > 0) return Stepen(a, b - 1) * a;
    else return 1;
}

Console.WriteLine(Stepen(5, 2));
*/