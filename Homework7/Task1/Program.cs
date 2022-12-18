// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

double PromtDouble(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToDouble(Console.ReadLine());
}

double[,] GenerateDimensionalArray(int rows, int columns, double minrange, double maxrange)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = minrange + (maxrange - minrange) * (new Random().NextDouble());
        }
    }
    return array;
}

void PrintDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}\t");
        }
        System.Console.WriteLine();
    }
}

int rows = Promt($"Введите количество строк в массиве");
int columns = Promt($"Введите количество столбцов в массиве");
double minrange = PromtDouble($"Введите минимальную цифру для образования массива");
double maxrange = PromtDouble($"Введите максимальную цифру для образования массива");


double[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);

PrintDimensionalArray(array);