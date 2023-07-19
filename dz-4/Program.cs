/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

int[] getArray(int size)
{
    int[] result = new int[size];
for    (int i = 0; i < size; i++)
{
    result[i] = new Random().Next(0, 20);
}
return result;
}

int[] array = getArray(8);
Console.WriteLine($"[{String.Join(",",array)}]");*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

int x = ReadInt("Enter to number: ");

int lena = NumberLen(x);
SumNumbers(x, lena);

int NumberLen(int y)
{
    int index = 0;
    while (y > 0)
    {
        y /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int z, int lena)
{
    int sum = 0;
    for (int i = 1; i <= lena; i++)
    {
        sum += z % 10;
        z /= 10;
    }
    Console.WriteLine($"Summ numeral in number {sum}: ");
}

int ReadInt(string window)
{
    Console.Write(window);
    return Convert.ToInt32(Console.ReadLine());
}*/

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.WriteLine("Enter to number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter to number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int jump = a;

for (int i = 1; i < b; i++)
{
    jump = jump * a;
}
Console.WriteLine($"A to the extent of B: " + jump);*/