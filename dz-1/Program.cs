/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

int a = 1;
while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.Write($"(a) ");    
    }
    a++;
}
Console.WriteLine();*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else 
{
    Console.WriteLine("Число нечётное");
}*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное число = {max}");*/

/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Введите А: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine("А больше В");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine("B больше A");
    }
    else
    {
        Console.WriteLine("B равно A");
    }
}*/
