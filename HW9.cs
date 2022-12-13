// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

 void ShowNum (int n)
{
     Console.Write(n + ", ");
     if (n>1) 
     ShowNum (n-1);
      
}

Console.WriteLine("input your number");
int n = Convert.ToInt32(Console.ReadLine());
ShowNum(n); 



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

/* int SumNumbersMN (int m, int n)
{
    if  (m<=n)
        return SumNumbersMN (m+1,n)+m;
    else
        return 0;
}     

    

Console.WriteLine("input your the largest number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input your  the smallest number");
int n = Convert.ToInt32(Console.ReadLine());
if (m<=n)
int result = SumNumbersMN (m,n);
Console.WriteLine(result); */


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

