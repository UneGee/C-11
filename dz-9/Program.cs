/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*example without recursion 
Console.Write("Enter the number: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int count = 1;

for (int i = N; i >= 1; i--)
{
    Console.WriteLine(i + "");
}*/

/*Console.Write("Enter the number: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int count = 1;
NaturalToLow(N, count);

void NaturalToLow(int N, int count)
{
    if (count > N)
    {
        return;
    }
    else
    {
        NaturalToLow(N, count +1);
        Console.Write(count + " ");
    }
}*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine()!);

SummMN(m, n);

//summoning the amount
void SummMN(int m, int n)
{
    Console.Write(SumMN(m-1, n));
}

//summoning from m to n
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
    return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}*/



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter to M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter to N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// calling Akkerman function
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// function Akkerman
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}*/