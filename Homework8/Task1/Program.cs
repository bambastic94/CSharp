// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int Prompt(string massage)
{
    Console.Write($"{massage} >");
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

int[,] OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}



int rows = Prompt($"Введите количество строк в массиве");
int columns = Prompt($"Введите количество столбцов в массиве");
int minrange = Prompt($"Введите минимальную цифру для образования массива");
int maxrange = Prompt($"Введите максимальную цифру для образования массива");


int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);
PrintDimensionalArray(array);
array = OrderArray(array);
System.Console.WriteLine();
PrintDimensionalArray(array);