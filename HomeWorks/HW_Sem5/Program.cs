// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/**
int[] ShowsEvenNumbers(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];
    int evenNum = 0;

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal);

        if (newArray[i] % 2 == 0)
        {
            evenNum++;
        }
    }

    Console.WriteLine(evenNum);
    return newArray;
}

int[] myArray = ShowsEvenNumbers(4, 100, 1000);
**/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0 

/*
int[] ShowSumOddNum(int size = 6, int minVal = -10, int maxVal = 11)
{
    int[] newArray = new int[size];
    int temp = 0;

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal);

        if (i % 2 == 1)
        {
            temp = temp + newArray[i];
        }
    }
    Console.WriteLine(temp);
    return newArray;
}

ShowSumOddNum();
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] DiffMaxMin (int size = 5, int minVal = 0, int maxVal = 100)
// {
//     double[] newArray = new double[size];
    
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minVal, maxVal) + new Random().NextDouble();
//         double minNum = newArray[0];
//         //Console.WriteLine($"arr min - {minNum}");
//         double maxNum = newArray[0];
//         double diffMinMax = maxNum - minNum;

//         if (newArray[i] < minNum) 
//         {
//             minNum = newArray[i];
//             Console.WriteLine($"min - {minNum}");
//         }
//         else if (newArray[i] > maxNum) 
//         {
//             maxNum = newArray[i];
//             Console.WriteLine($"max - {maxNum}");
//         }
//         //Console.WriteLine(diffMinMax);
//     }
    
    
//     return newArray;
// }

int[] DiffMaxMin (int size = 5, int minVal = 0, int maxVal = 100)
{
    int[] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal);
        int minNum = newArray[0];
        int maxNum = newArray[0];
    
        if (newArray[i] < minNum) 
        {
            minNum = newArray[i];
            //Console.WriteLine($"min - {minNum}");
        }
        else if (newArray[i] > maxNum) 
        {
            maxNum = newArray[i];
            //Console.WriteLine($"max - {maxNum}");
        }
        int diffMinMax = maxNum - minNum;
    }
    
    Console.WriteLine(diffMinMax);
    
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


int[] myArray = DiffMaxMin();
PrinArray(myArray);

//Console.WriteLine(new Random().Next(0, 100) + new Random().NextDouble());