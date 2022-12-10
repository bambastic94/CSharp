// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] CustomArray(int[] array)
{
    int length = (array.Length / 2) + (array.Length % 2);
    int[] arr = new int[length];

    for (int i = 0; i < length; i++)
    {
        arr[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 != 0)
    {
        arr[length-1] = array[length-1];
    }

        return arr;
}

int length = Promt($"Введите длину массива");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");

int[] array = GenerateArray(length, minrange, maxrange);
int[] arr = CustomArray(array);
PrintArray(array);
System.Console.WriteLine();
PrintArray(arr);
