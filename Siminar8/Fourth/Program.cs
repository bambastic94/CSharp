// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

(int, int) CoordMin(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    return (iMin, jMin);
}

int[,] LossArray(int[,] array)
{
    (int iMin, int jMin) = CoordMin(array);
    int[,] arrayLoss = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < arrayLoss.GetLength(0); i++)
    {
        for (int j = 0; j < arrayLoss.GetLength(1); j++)
        {
            if (i >= iMin && j < jMin)
            {
                arrayLoss[i, j] = array[i + 1, j];
            }
            else if (j >= jMin && i < iMin)
            {
                arrayLoss[i, j] = array[i, j + 1];
            }
            else if (j >= jMin && i >= iMin)
            {
                arrayLoss[i, j] = array[i + 1, j + 1];
            }
            else
            {
                arrayLoss[i, j] = array[i, j];
            }
        }
    }
    return arrayLoss;
}

// int[,] DeleteIJ(int[,] array, int I, int J)
// {
//     int rows = 0;
//     int columns = 0;
//     int[,] matrix = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         columns = 0;
//         if (I == i) continue;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (J == j) continue;
//             matrix[rows, columns] = array[i, j];
//             columns++;
//         }
//         rows++;

//     }
//     return matrix;
// }


int rows = Prompt($"Введите количество строк в массиве");
int columns = Prompt($"Введите количество столбцов в массиве");
int minrange = Prompt($"Введите минимальную цифру для образования массива");
int maxrange = Prompt($"Введите максимальную цифру для образования массива");


int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);
PrintDimensionalArray(array);
System.Console.WriteLine();
int[,] arrayLoss = LossArray(array);
PrintDimensionalArray(arrayLoss);