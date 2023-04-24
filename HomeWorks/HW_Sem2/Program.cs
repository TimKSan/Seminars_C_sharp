/*__________________1_________________________________________________________________________________________________
int ShowSecondNum(int num)
{
    int sto = num % 100;
    int des = sto / 10;
    return des;
}

int num = new Random().Next(100, 1000);
int result = ShowSecondNum(num);

Console.WriteLine(num);
Console.WriteLine(result);
*/

/*__________________2_________________________________________________________________________________________________
int ShowThirdNum(int num)
{
    if (num >= 10000)
    {
        int thousand = num % 1000;
        int hundred = thousand / 100;
        return hundred;
    }
    else if (num >= 1000)
    {
        int hundred = num % 100;
        int dozens = hundred / 10;
        return dozens;
    }
    else if (num >= 100)
    {
        int dozens = num % 10;
        return dozens;
    }
    else if (num >= 10 || num < 10)
    {
        Console.WriteLine($"У {num} нет третьей цифры");
    }
    return 1;
}

int num = new Random().Next(10, 100000);
int result = ShowThirdNum(num);

Console.WriteLine(num);
Console.WriteLine(result);
*/

/*__________________3_________________________________________________________________________________________________
bool ShowDayWeek(int day)
{
    if (day == 6 || day == 7)
    {
        return true;
    }
    else return false;
}
Console.WriteLine("Введите номер недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Выбранный день является выходным - {ShowDayWeek(day)}");
*/