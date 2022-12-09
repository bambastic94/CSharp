﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int length, int minrange, int maxrange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minrange, maxrange + 1); ;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]} ");
    }
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if(item<0)
        sum += item;
    }
    return sum;
}

int SumPositive(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if(item>0)
        sum += item;
    }
    return sum;
}


int length = Promt($"Введите длину массива");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");

int[] array = GenerateArray(length, minrange, maxrange);
PrintArray(array);
System.Console.WriteLine();

int neg = SumNegative(array);
int pos = SumPositive(array);
System.Console.WriteLine($"Сумма позитивных чисел в массиве ={pos} , а негативных =({neg})");