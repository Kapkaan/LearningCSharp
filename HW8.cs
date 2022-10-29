//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.                     +

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

void ChangedArray (int [,] array)
{
    int temp=0;
    for (int i=0; i<array.GetLength(0); i++)        
      { for (int j=0; j<array.GetLength(1); j++)
        { for (int k = 0; k < array.GetLength(1) - 1; k++)      //k вложенный цикл для сравнения с внешним
           { if (array[i, k] < array[i, k + 1])
            { temp = array[i, k + 1];
             array[i, k + 1] = array[i, k];
             array[i, k] = temp;
            }
          }
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
ChangedArray(MyArray);
Show2DArray(MyArray); */

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.                      +

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

int SumRow (int [,] array, int i)
{
    int sum=0;
    for (int j=0; j<array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    return sum;
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

int minSumRow=0;
int sumrow=SumRow(MyArray,0);
for (int i=1; i<MyArray.GetLength(0); i++)
{
    int temp = SumRow (MyArray, i);
  if (sumrow > temp)
  {
    sumrow = temp;
    minSumRow = i;
  }
}
Console.WriteLine($"row with min sum of number is {minSumRow+1} "); */


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.                                                                 -
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

int [,] Combo2dArray (int [,] array, int [,] array)
{
    int [,] ComboArray = new int [rows,columns];
    for (int i=0; i<rows; i++)
      {  for (int j=0; j<columns; j++)
        {
            MyArray[i,j]= ;
        }
      }
    return ComboArray;
}

C onsole.WriteLine("input quantity of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input quantity of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of your array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of your array");
int max = Convert.ToInt32(Console.ReadLine());
int [,] MyArray1=Rand2DArray(m,n,min,max);
Show2DArray(MyArray1);
int [,] MyArray2=Rand2DArray(m,n,min,max);
Show2DArray(MyArray2); */


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.   +

/* int [, ,] Rand3DArray (int rows, int columns, int diagonals)
{
  int [,,] MyArray=new int [rows,columns,diagonals];
  for (int i=0; i<rows; i++)
      {  for (int j=0; j<columns; j++)
        { for (int k=0; k<diagonals; k++)
          MyArray[i,j,k]= new Random().Next(10,100);
        }
      }
    return MyArray;
}

void Show3DArray (int [,,] array)
{
    Console.WriteLine("your array:");
    for (int i=0; i<array.GetLength(0); i++)        
      {  for (int j=0; j<array.GetLength(1); j++)
        { for (int k=0; k<array.GetLength(2); k++)
        {
            Console.Write($"{array [i,j,k]} ({i};{j};{k})  ");
        }
          Console.WriteLine();
       }
      }
}

Console.WriteLine("input quantity of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input quantity of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input quantity of diagonals");
int p = Convert.ToInt32(Console.ReadLine());
int [,,] MyArray=Rand3DArray(m,n,p);
Show3DArray(MyArray); */

// Напишите программу, которая заполнит спирально массив 4 на 4.                                                                                                        +

/* void ShowSpiralArray (int [,] array)
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

int n=4;

int [,] SpiralArray = new int [n,n];
int i=0;
int j=0;
int temp = 1;

    while (temp<=16)
      {SpiralArray[i,j]=temp;
      temp++;
        if (i+1>=j && i+j<SpiralArray.GetLength(0)-1)
        i++;
        else if (i>j && i+j>=SpiralArray.GetLength(0)-1)
        j++;
        else if (i<=j && i+j>SpiralArray.GetLength(0)-1)
        i--;
        else  // (i<j && i+j<=SpiralArray.GetLength(0)-1)
        j--;
      }

ShowSpiralArray(SpiralArray); */
