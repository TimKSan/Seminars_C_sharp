// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// double[,] Create2DRandomArray(int rows, int colums, int minVal, int maxVal)
// {
//     double[,] array = new double[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = Math.Round(new Random().Next(minVal, maxVal) + new Random().NextDouble(), 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
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









// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void ShowElementOfArray(int[,] array)
{
    Console.WriteLine($"input coordinates");
    int userRowsNum = Convert.ToInt32(Console.ReadLine());
    int userColumNum = Convert.ToInt32(Console.ReadLine());

    if (userRowsNum < 0 || userRowsNum > array.GetLength(0)
    || userColumNum < 0 || userColumNum > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else Console.WriteLine($"({userRowsNum}; {userColumNum}) => {array[userRowsNum, userColumNum]}");
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

Console.WriteLine($"input num of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input num of colums");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input mminValue");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input maxValue");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, colums, minValue, maxValue);

Print2DArray(myArray);
ShowElementOfArray(myArray);
*/








// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void ShowAvgArethmetic(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)} ");
    }
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
Console.WriteLine($"input num of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input num of colums");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input mminValue");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input maxValue");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, colums, minValue, maxValue);

Print2DArray(myArray);
ShowAvgArethmetic(myArray);
*/

