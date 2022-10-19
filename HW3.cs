// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* void Palindrom (int num)
{ int inputnum=num;
int returnnum=0;
while (num>0)
    { returnnum=returnnum*10+num%10;
    num=num/10;
    }
    if (returnnum==inputnum)
    Console.WriteLine("your number is palindrom");
    else
    Console.WriteLine("your number isn't palindrom");
}
Console.WriteLine("input your five-digit number");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num); */


// Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/* double Distance (double xa, double ya, double za, double xb, double yb, double zb)
{
double distance=Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
return distance;
}

Console.WriteLine ("input xa");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("input ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("input za");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("input xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("input yb");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("input zb");
double zb = Convert.ToDouble(Console.ReadLine());

double result = Distance(xa,ya,za,xb,yb,zb);
Console.WriteLine($"your distance equal {result}"); */

// Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
/* void Cube(int n)
{
int a=1;
while (a<=n)
    {
    Console.Write($"{Math.Pow(a,3)}, ");
    a++;
    }
}

Console.WriteLine("input your number");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n); */