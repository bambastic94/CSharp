// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите
// максимальный порог случайных значений”)

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


int length = Promt($"Введите длину массива");
int minrange = Promt($"Введите минимальную цифру в образования массива");
int maxrange = Promt($"Введите максимальную цифру в образования массива");

int[] array = GenerateArray(length, minrange, maxrange);
PrintArray(array);
