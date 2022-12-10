// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

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
        System.Console.Write($"{array[j]}\t");
    }
}

int Even(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
        return count;
}

int length = Promt($"Введите длину массива");

int[] array = GenerateArray(length, 100, 999);

PrintArray(array);
System.Console.WriteLine($"\nКоличество четных чисел = {Even(array)}");
