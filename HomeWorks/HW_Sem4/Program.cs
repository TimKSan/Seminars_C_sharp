﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void RaiseToDegree(int a, int b)
// {
//     int temp = a;
//     for (int i = 1; i < b; i++)
//     {
//         a = temp * a;
//         Console.WriteLine(a);
//     }
// }

// RaiseToDegree(3, 5);


////////////////////////////////////////////////////// 2 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumNum(int a)
// {
//     int sum = 0;
//     while (a > 0)
//     {
//         sum = sum + a % 10;
//         a = a / 10;
//     }
//     Console.WriteLine(sum);
// }

// SumNum(82);


////////////////////////////////////////////////////// 3 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void PrinArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input num");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min num");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max num");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrinArray(myArray);