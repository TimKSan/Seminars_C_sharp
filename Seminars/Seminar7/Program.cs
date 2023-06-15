﻿//Задача 1. Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.

// int[,] Create2DRandomArray(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < rows; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine($"input num of rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input num of colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input mminValue");
// int minVal = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input maxValue");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DRandomArray(rows, colums, minVal, maxVal));




//Задача 4. задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] Create2DRandomArray(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < rows; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumOfMainDiag(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }
//         }
//     }
//     return sum;
// }

// Console.WriteLine($"input num of rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input num of colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input mminValue");
// int minVal = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input maxValue");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int[,] muArray = Create2DRandomArray(rows, colums, minVal, maxVal);

// Print2DArray(muArray);
// Console.WriteLine(SumOfMainDiag(muArray));



//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба 
//индекса чётные, и замените эти элементы на их квадраты.

int[,] Create2DRandomArray(int rows, int colums, int minVal, int maxVal)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Chet(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

Console.WriteLine($"input num of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input num of colums");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input mminValue");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input maxValue");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(rows, colums, minVal, maxVal);

Print2DArray(array);
Console.WriteLine();
Print2DArray(Chet(array));



// Print2DArray(muArray);
// Console.WriteLine(SumOfMainDiag(muArray));
//Задача 2. ****Задайте двумерный массив размера m на n, каждый 
//элемент в массиве находится по формуле: Aₘₙ = m+n.