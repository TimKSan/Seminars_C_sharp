//Задача 2.Напишите программу, которая принимает на вход 
//число и выдаёт количество цифр в числе. 36478439 - 8

// int DigitCount(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         count++;
//         num /= 10;
//     }
//     return count;
// }

// Console.WriteLine("input num");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"num of digits in {num} -> {DigitCount(num)}");
//____________________________________________________________________________________
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrinArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("input num");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min num");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max num");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrinArray(myArray);
//______________________________________________________________________________
//Задача 3. Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Factorial(int N)
// {
//     int result = 1;
//     for (int i=1; i<=N; i++)
//     {
//         result = result*i;
//     }
//     return result;
// }
// int N = 4;
// Console.WriteLine(Factorial(N));
//________________________________________________________________________________
//Задача 1. Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.

// int Sum(int N)
// {
//     int result = 0;
//     for (int i=0; i<=N; i++)
//     {
//         result = result+i;
//     }
//     return result;
// }
// int N = 2;
// Console.WriteLine(Sum(N));