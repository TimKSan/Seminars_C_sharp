//Напишите программу, которая выводит случайное 
//число из отрезка [10, 99] и показывает наибольшую цифру числа

// int MaxDigit(int randomNum)
// {
//     int des = randomNum / 10;
//     int ed = randomNum % 10;
//     if (des > ed) return des;
//     else return ed;
// }


// int num = new Random().Next(10, 100);

// int result = MaxDigit(num);

// Console.WriteLine($"{num} -> {result}");
////////////////////////////////////////////////////////////////////////
// //Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому. Если второе число
//  не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// bool Kratnost (int num1, int num2)
// {
//     if (num1 % num2 == 0) return true;
//     else return false;
// }

// Console.WriteLine("введите 1е число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 2е число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} => {Kratnost(num1, num2)}, ost {num1%num2}");

