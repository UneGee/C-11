﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
(Проверка на трехзначность при вводе пользователем)
456 -> 5 
782 -> 8
918 -> 1

Console.Write("Введите число R: ");
int R = int.Parse(Console.ReadLine()!);
int b = (R/10) % 10;

if (R >= 100 && R <= 1000)
{
    Console.WriteLine($"Вторая цифра числа {R} = {b}: ");
}

if (R >= -1000 && R <= -100)
{
    Console.WriteLine($"Вторая цифра числа {R} = {-b}: ");
}

if (R > -100 && R < 100)
{
    Console.WriteLine("Данное число не подходит, введите новое");
}

if (R < -1000)
{
    Console.WriteLine("Данное число не подходит, введите новое");
}

if (R > 1000)
{
    Console.WriteLine("Данное число не подходит, введите новое");
}*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. (Максимум 100000)
645 -> 5
78 -> третьей цифры нет 
32679 -> 6

Console.Write("Введите число R: ");
int R = int.Parse(Console.ReadLine()!);
int a = (R / 100) % 10;
int b = R % 10;

if (R >= 10000 && R <= 100000)
{
    Console.WriteLine($"Третья цифра числа {R} = {a}: ");
}

if (R >= -100000 && R <= -10000)
{
    Console.WriteLine($"Третья цифра числа {R} = {-a}: ");
}

if (R >= 100 && R <= 10000)
{
    Console.WriteLine($"Третья цифра числа {R} = {b}: ");
}

if (R >= -10000 && R <= -100)
{
    Console.WriteLine($"Третья цифра числа {R} = {-b}: ");
}

if (R > -100 && R < 100)
{
    Console.WriteLine("Третьего числа нет, введите новое: ");
}*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.(использовать И и ИЛИ)
6 -> да
7 -> да
1 -> нет*/