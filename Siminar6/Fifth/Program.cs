// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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
    System.Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0;i<array.Length;i++)
    {
        array2[i] = array[i];
    }
    return array2;
}

int length = Promt($"Введите длину массива");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");

int[] array = GenerateArray(length,minrange,maxrange);
PrintArray(array);
int[] arrayCopy = CopyArray(array);
array[0] = -5;
PrintArray(array);
PrintArray(arrayCopy);