// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Promt(string massage)
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

double[] columnAverage(int[,] array)
{
    int sum = 0;
    double[] arrayAverage = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
            if (j == array.GetLength(0)-1)
            {
                arrayAverage[i] = sum / Convert.ToDouble(array.GetLength(0));
            }
        }
    }
    return arrayAverage;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine();
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]:F2}\t");
    }
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

int rows = Promt($"Введите количество строк в массиве");
int columns = Promt($"Введите количество столбцов в массиве");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");


int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);
double[] arrayAverage = columnAverage(array);

PrintDimensionalArray(array);
PrintArray(arrayAverage);