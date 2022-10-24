// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* int [] NewArray (int m)
{
    int [] MyArray = new int [m];
    for (int i=0; i<m; i++)
    {Console.WriteLine($"Input {i+1} element");
    MyArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return MyArray;
}

void ShowArray (int [] array)
{
    Console.Write("your array ");
    for (int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+ ", ");
    }
    Console.WriteLine();
}

void Over0 (int [] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++)
        if (array[i]>0)
        count++;
    Console.WriteLine($"in your array numbers greater than zero = {count}");
}

Console.WriteLine("input size of array");
int m = Convert.ToInt32(Console.ReadLine());
int [] MyArray = NewArray (m);
ShowArray(MyArray);
Over0(MyArray); */


// Программа ищет точку пересечения двух прямых, заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем


/* Console.WriteLine("input k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
    
double x=0;
double y=0;
    if (k1*b2-k2*b1==0)
    Console.WriteLine("lines are parallel");
    else 
    {
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    Console.WriteLine($" the coordinates of intersection of your lines is ({x};{y})"); 
    }  */

