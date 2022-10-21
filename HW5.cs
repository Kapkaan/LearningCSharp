//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/* int [] New3digitArray (int size,int min, int max)
{
    int [] MyArray = new int [size];
    for (int i=0; i<size; i++)
    {
        MyArray[i]=new Random().Next(min,max+1);
    }
    return MyArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("your array ");
    for (int i=0; i<array.Length; i++)
    {Console.Write(array[i]+", "); }
Console.WriteLine();
}

int EvenDigits (int [] array)
{
    int amount=0;
for (int i=0; i<array.Length; i++)
    { 
    if (array [i]%2==0)
    amount++;
    }
    return amount;
}

Console.WriteLine("input size of array");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;
int [] MyArray = New3digitArray (size, min, max);
ShowArray(MyArray);
int result = EvenDigits (MyArray);
Console.Write($"amount of even numbers {result} "); */

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/* int [] NewArray (int size,int min, int max)
{
    int [] MyArray = new int [size];
    for (int i=0; i<size; i++)
    {
        MyArray[i]=new Random().Next(min,max+1);
    }
    return MyArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("your array ");
    for (int i=0; i<array.Length; i++)
    {Console.Write(array[i]+", "); }
Console.WriteLine();
}

int SumOddPos (int [] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i=i+2)
    sum+=array[i];
    return sum;
}

Console.WriteLine("input size of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of array");
int max = Convert.ToInt32(Console.ReadLine());
int [] MyArray= NewArray (size,min,max);
ShowArray(MyArray);
int result = SumOddPos (MyArray);
Console.WriteLine($"sum of odd position number {result}"); */


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
/* double [] NewDoubleArray (int size,double min, double max)
{
    double [] MyArray = new double [size];
    for (int i=0; i<size; i++)
    {
        MyArray[i]=new Random().NextDouble()*(max-min)+min;
    }
    return MyArray;
}

void ShowArray (double[] array)
{
    Console.WriteLine("your array ");
    for (int i=0; i<array.Length; i++)
    {Console.Write(array[i]+", "); }
Console.WriteLine();
}

double SubtrMaxMin (double [] array)
{
    int i = 0;
    double mindig=array [i];
    double maxdig=array [i];
    while (i<array.Length)
    {
        if (maxdig<array[i])
        maxdig=array[i];
        if (mindig>array[i])
        mindig=array[i];
        i++;
    }
    double subtr=maxdig-mindig;
    return subtr;
}

Console.WriteLine("input size of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of array");
double min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of array");
double max = Convert.ToInt32(Console.ReadLine());
double [] MyArray= NewDoubleArray (size,min,max);
ShowArray(MyArray);
double result = SubtrMaxMin (MyArray);
Console.WriteLine($"{maxdig} - {mindig} = {result}"); */