//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortedToLow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
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
SortedToLow(myArray);
Console.WriteLine("___after sorting___");
Print2DArray(myArray);
*/










//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

void ShowMinSum(int[,] array)
{
    int[] ShowMinSum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            ShowMinSum[i] += array[i, j];
        }
        Console.Write($"{ShowMinSum[i]} ");
    }

    int minRow = 0;

    for (int i = 0; i < ShowMinSum.Length; i++)
    {
        if (ShowMinSum[minRow] > ShowMinSum[i]) minRow = i;
    }
    Console.Write($"\n{ShowMinSum[minRow]}, строка -> {minRow + 1}");
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
ShowMinSum(myArray);
*/








//Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.