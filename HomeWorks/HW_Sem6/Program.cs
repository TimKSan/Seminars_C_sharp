// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/**
int[] ShowLessThanZero(int size, int minVal, int maxVal)
{
    int count = 0;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);

        if (array[i] > 0) count++;
    }
    Console.WriteLine(count);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine($"input size of array");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input min Value");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"input max Value");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] myArray = ShowLessThanZero(size, minVal, maxVal);

PrintArray(myArray);
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void ShowsIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    if (k1 == k2)
    {
        Console.Write("Заданные прямые не пересекаются!");
    }

    else if ((k1 == k2) && (b1 == b2))
    {
        Console.Write("Прямые параллельны");
    }

    else Console.Write($"Точка пересечения прямых: ({x}; {y})");

}

Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

ShowsIntersectionPoint(k1, b1, k2, b2);