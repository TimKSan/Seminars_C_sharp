//Задача2 напишите программу которая принемает на вход три числа и проверяети 
//может ли сущ треугольник. каждая сторона должна быть меньше суммы двух других сторон

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a) return true;
//     return false;
// }

// Console.WriteLine("input A length: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input B length: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input C length: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(CheckTriangle(a, b, c));


// int[] Fibonachi(int size, int firstNum, int secNum)
// {
//     int[] array = new int[size];
//     array[0] = firstNum;
//     array[1] = secNum;
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }

//     return array;
// }

// void PrinArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("input size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input first num");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second num");
// int secNum = Convert.ToInt32(Console.ReadLine());

// //int[] myArray = Fibonachi(size, firstNum, secNum);
// PrinArray(Fibonachi(size, firstNum, secNum));

//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] WishRotate(int[] wishRotate, int size)
{
    //int[] wishRotate = new int[size];
    int box = 0;
    for (int i = 0; i < size - 1 - i; i++)
    {
        box = wishRotate[i];
        wishRotate[i] = wishRotate[size - 1 - i];
        wishRotate[size - 1 - i] = box;
    }
    return wishRotate;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

Console.WriteLine($"input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input minValue");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input maxValue");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, minValue, maxValue);

PrintArray(array);
array = WishRotate(array, size);
PrintArray(array);