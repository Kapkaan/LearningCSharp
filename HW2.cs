// Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/* int SecondDigit (int num)
{
    int sotny = num/100;
    int dec = num/10;
    int result = dec - sotny*10;
    return result;
}

Console.WriteLine("input three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit (num);
Console.WriteLine ($"Second digit of {num} is {result}"); */


//Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* void ThirdDigit (int num)
{
    if (num<99)
    Console.WriteLine("your number isn't have third digit");
    while (num>1000)
    num=num/10;
Console.WriteLine($"third digit is {num%10}");
   }
Console.WriteLine("input your number");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigit (num); */


//Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/* bool Week (int num)
{
    if (num >= 1 && num<5)
    return false;
    else
    return true;
}
 Console.WriteLine("put day of week");
int num = Convert.ToInt32(Console.ReadLine());
bool DayOff = Week(num);
Console.WriteLine("this day is day off");
Console.Write(DayOff); */
