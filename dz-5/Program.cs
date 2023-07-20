/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

int[] array = GetArray(15, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Positive even number = {GetArrayCount(array)}");

int GetArrayCount(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

//array filling function
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int[] array = GetArray(15, -20, 21);
Console.WriteLine($"[{String.Join(", ", array)}]");

int negativeSum = 0;

foreach (int el in array)
{
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Negative sum = {negativeSum}");

//array filling function
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/

/*Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62

int[] array = GetArray(15, 10, 99);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"The difference between max and min = {GetDifference(array)}");

int GetDifference(int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach (var item in array)
    {   
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}

//array filling function
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/