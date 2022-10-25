// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/* double [,] Rand2DArray (int rows, int columns, int minval, int maxval)
{
    double [,] MyArray = new double [rows,columns];
    for (int i=0; i<rows; i++)
      {  for (int j=0; j<columns; j++)
        {
            MyArray[i,j]= new Random().NextDouble()*(maxval-minval)+minval;
        }
      }
    return MyArray;
}

void Show2DArray (double [,] array)
{
    Console.WriteLine("your array:");
    for (int i=0; i<array.GetLength(0); i++)        
      {  for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array [i,j]+" ");
        }
          Console.WriteLine();
}
}

Console.WriteLine("input quantity of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input quantity of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of your array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of your array");
int max = Convert.ToInt32(Console.ReadLine());
double [,] MyArray = Rand2DArray(n,m,min,max);
Show2DArray(MyArray);   */

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/* int [,] Rand2DArray (int rows, int columns, int minval, int maxval)
{
    int [,] MyArray = new int [rows,columns];
    for (int i=0; i<rows; i++)
      {  for (int j=0; j<columns; j++)
        {
            MyArray[i,j]= new Random().Next(minval, maxval+1);
        }
      }
    return MyArray;
}

void Show2DArray (int [,] array)
{
    Console.WriteLine("your array:");
    for (int i=0; i<array.GetLength(0); i++)        
      {  for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array [i,j]+" ");
        }
          Console.WriteLine();
       }
}

void Search (int [,] array)
{   
    Console.WriteLine("input # rows");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input # columns");
    int b = Convert.ToInt32(Console.ReadLine());
       for (int i=0; i<array.GetLength(0); i++)        
            { for (int j=0; j<array.GetLength(1); j++)
                { if (i+1==a && j+1==b)
                    {int result = array [i,j];
                    Console.WriteLine($"your number is {result}");}
                }
            }
    if (a>array.GetLength(0) || b>array.GetLength(1))
    Console.WriteLine($"there is no such number in the array");
}

Console.WriteLine("input quantity of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input quantity of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of your array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of your array");
int max = Convert.ToInt32(Console.ReadLine());

int [,] MyArray=Rand2DArray(m,n,min,max);
Show2DArray(MyArray);
Search(MyArray); */

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

 int [,] Rand2DArray (int rows, int columns, int minval, int maxval)
{
    int [,] MyArray = new int [rows,columns];
    for (int i=0; i<rows; i++)
      {  for (int j=0; j<columns; j++)
        {
            MyArray[i,j]= new Random().Next(minval, maxval+1);
        }
      }
    return MyArray;
}

void Show2DArray (int [,] array)
{
    Console.WriteLine("your array:");
    for (int i=0; i<array.GetLength(0); i++)        
      {  for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array [i,j]+" ");
        }
          Console.WriteLine();
       }
}

void ArithmeticMean (int [,] array)
{
   for (int j=0; j<array.GetLength(1); j++)
     {  int i = 0;
        double sum = 0;
        double arit = 0;
        {  while (i<array.GetLength(0))
          {sum=sum+array[i,j];
           i++;}
       arit=sum/array.GetLength(0);
       Console.WriteLine($"ArithmeticMean for {j+1} column = {arit}");
       }
     }
    }

Console.WriteLine("input quantity of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input quantity of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of your array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of your array");
int max = Convert.ToInt32(Console.ReadLine());
int [,] MyArray=Rand2DArray(m,n,min,max);
Show2DArray(MyArray);
ArithmeticMean(MyArray);  

