// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число 
// меньше максимального элемента, но больше всех остальных). Сделать одним циклом

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

int SecondMax(int[] array)
{
    int max = array[0];
    int max2 = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != max)
        {
            if (array[i] > max)
            {
                max2 = max;
                max = array[i];
            }
            else if (array[i] > max2)
            {
                max2 = array[i];
            }
        }
    }
    return max2;
}

int length = Promt($"Введите длину массива");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");

int[] array = GenerateArray(length, minrange, maxrange);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Второе максимальное значение в массиве > {SecondMax(array)}");