// Цикл принимает на вход два числа (A и B) и возводит число A в натуральную степень B

/* double Exponentiation (double a, double b)
{
    double exp = Math.Pow(a,b);
    return exp;
}

Console.WriteLine("input a");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b");
double b = Convert.ToInt32(Console.ReadLine());
double result = Exponentiation (a,b);
Console.WriteLine($"{a} in the {b} degree = {result}"); */


//Программа принимает на вход число и выдаёт сумму цифр в числе.
/* int DigitsSum (int num)
    {
        int sum=0;
        while (num>0)
       {
         sum=sum+num%10;
         num = num/10;
       }
       return sum;
    }

Console.WriteLine("input your number");
int num = Convert.ToInt32(Console.ReadLine());
int result = DigitsSum(num);
Console.WriteLine($"sum of digits of {num} = {result}"); */

// Программа задаёт массив из 8 элементов и выводит их на экран
/* int [] EightDigitArray (int size, int minvalue, int maxvalue)
{
    int [] MyArray = new int [size];
    for (int i=0; i<size; i++)
    {MyArray[i]=new Random().Next(minvalue,maxvalue+1);}
    return MyArray;
}

void ShowMyArray (int[] array)
{
    Console.Write("your array - ");
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]+ ", ");
    }
}

Console.WriteLine("input size of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of array");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of array");
int maxvalue = Convert.ToInt32(Console.ReadLine());
int [] MyArray = EightDigitArray (size,minvalue,maxvalue);
ShowMyArray(MyArray); */