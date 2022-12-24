// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int Prompt(string massage)
{
    Console.WriteLine($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateDimensionalArray(int rows, int columns, int minrange, int maxrange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minrange, maxrange + 1);
        }
    }
    return array;
}

void PrintDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeElementsArray(int[,] array)
{
    int temp = array[0,0];
    array[0,0] = array[array.GetLength(0)-1,array.GetLength(1)-1];
    array[array.GetLength(0)-1,array.GetLength(1)-1] = temp;
    return array;
}

int rows = Prompt($"Введите количество строк в массиве");
int columns = Prompt($"Введите количество столбцов в массиве");
int minrange = Prompt($"Введите минимальную цифру для образования массива");
int maxrange = Prompt($"Введите максимальную цифру для образования массива");


int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);
PrintDimensionalArray(array);
System.Console.WriteLine();
int[,] arrayChanged = ChangeElementsArray(array);
PrintDimensionalArray(arrayChanged);
