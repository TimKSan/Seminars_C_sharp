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