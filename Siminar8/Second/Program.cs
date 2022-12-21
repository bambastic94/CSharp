// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

bool VerifyArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Невозможно перевернуть матрицу");
        return false;
    }
}

int[,] ReverseArray(int[,] array)
{
    int[,] arrayReverse = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayReverse[i,j] = array[j, i];
        }
    }
    return arrayReverse;
}


int rows = Prompt($"Введите количество строк в массиве");
int columns = Prompt($"Введите количество столбцов в массиве");
int minrange = Prompt($"Введите минимальную цифру для образования массива");
int maxrange = Prompt($"Введите максимальную цифру для образования массива");


int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);
PrintDimensionalArray(array);
System.Console.WriteLine();
if (VerifyArray(array))
{
    int[,] arrayReverse = ReverseArray(array);
    PrintDimensionalArray(arrayReverse);
}