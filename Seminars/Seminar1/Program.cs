// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введенное число - {num}");

//Задача 1. Запросить число и вывести его квадрат
// Console.WriteLine("Введите число, которое нужно возвести в квадрат");
// int numToQuad = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Квадрат числа равен {numToQuad} = {numToQuad*numToQuad}");

//Задача 2. Является ли первое число квадратом второго
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2)
// {
//     Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else
// {
// Console.WriteLine($"{num1} не является квадратом {num2}");
// }

//Задача 3. Напишите программу которая принимает на вход число N, 
//на выходе получаем последовательность от -N до N

// Console.WriteLine("Input N");

// int n = Convert.ToInt32(Console.ReadLine());
// int count = n*(-1);

// if (n < 0) Console.WriteLine("Введите положительное число");

// while(count <= n)
// {
//     Console.Write(count+" ");
//     count++;
// }

//задача 4. На вход принимает 3х значное число, вывести последнюю 
//цифру данного числа

// Console.WriteLine("Введите трехзначное число");
// int n = Convert.ToInt32(Console.ReadLine());
// int ed = n % 10;
// Console.WriteLine($"Последнее число у введенного {n} = {ed}");
