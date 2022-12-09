// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

bool IsFound(int[] array, int number)
{
    foreach (var item in array)
    {
        if(item == number)
        {
        return true;
        }
    }
    return false;
}

int length = Promt($"Введите длину массива");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");

int number = Promt("Какое число искать?");

int[] array = GenerateArray(length, minrange, maxrange);
PrintArray(array);

if(IsFound(array,number))
{
    System.Console.WriteLine("\nЗначения есть");
}
else
{
    System.Console.WriteLine("\nЗначений нет");
}

