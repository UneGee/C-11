/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

if(number.Length == 5)
{
    if(number{0} == number{4} $$ number{1} == number{3})
    {
        Console.WriteLine("Числ палиндром!");
    }
    else
    {
        Console.WriteLine("Числа не палиндром!");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число!");
}
Не знаю почему, но указывает ошибку, что else не распознаётся*/




/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x точки A: ");
int ax = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки A: ");
int ay = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату z точки A: ");
int az = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int bx = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки B: ");
int by = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату z точки B: ");
int bz = Convert.ToInt32(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((bx-ax), 2)+ Math.Pow((by-ay), 2)+ Math.Pow((bz-az), 2));
Console.WriteLine($"Расстояние между точками АВ = {AB:f2}");*/




/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= number; i++)
{
    int sqr = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine(sqr);
}*/