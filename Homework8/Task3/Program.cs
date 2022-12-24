// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int Prompt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateDimensionalArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

bool ConfirmMultiply(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) == array2.GetLength(1) && array1.GetLength(1) == array2.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int FindMinDemension(int[,] array)
{
    if (array.GetLength(0) <= array.GetLength(1))
    {
        return array.GetLength(0);
    }
    else
    {
        return array.GetLength(1);
    }
}

int FindMaxDemension(int[,] array)
{
    if (array.GetLength(0) <= array.GetLength(1))
    {
        return array.GetLength(1);
    }
    else
    {
        return array.GetLength(0);
    }
}

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] array = new int[FindMinDemension(array1), FindMinDemension(array1)];
    int row = 0;
    for (int i = 0; i < FindMinDemension(array1); i++)
    {
        for (int k = 0; k < FindMinDemension(array1); k++)
        {
            for (int j = 0; j < FindMaxDemension(array1); j++)
            {
                if (FindMinDemension(array1) == array1.GetLength(0))
                {
                    array[row, k] += array1[i, j] * array2[j, k];
                }
                else
                {
                    array[row, k] += array1[j, k] * array2[i, j];
                }
            }
        }
        row++;
    }
    return array;
}


int rows1 = Prompt($"Введите количество строк в первом массиве");
int columns1 = Prompt($"Введите количество столбцов в первом массиве");
int[,] array1 = GenerateDimensionalArray(rows1, columns1);
PrintDimensionalArray(array1);

int rows2 = Prompt($"Введите количество строк во втором массиве");
int columns2 = Prompt($"Введите количество столбцов во втором массиве");
int[,] array2 = GenerateDimensionalArray(rows2, columns2);
PrintDimensionalArray(array2);

if (ConfirmMultiply(array1, array2))
{
    int[,] array = MultiplyArray(array1, array2);
    System.Console.WriteLine("Перемноженная матрица:");
    PrintDimensionalArray(array);
}
else
{
    System.Console.WriteLine("Указана неверная размерность");
}
