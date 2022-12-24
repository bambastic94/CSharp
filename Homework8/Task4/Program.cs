// Напишите программу, которая заполнит спирально массив 4 на 4.

int Prompt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
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

int[,] SpiralArray(int row, int columns)
{
    int[,] array = new int[row, columns];
    int count = 1;
    int i = 0;
    while (count <= row * columns)
    {
        for (int j = 0 + i; j <= array.GetLength(1) - 1 - i; j++)
        {
            array[i, j] = count;
            count++;
            if (j == array.GetLength(1) - 1 - i)
            {
                for (int m = i + 1; m <= array.GetLength(0) - 1 - i; m++)
                {
                    array[m, j] = count;
                    count++;
                    if (m == array.GetLength(0) - 1 - i)
                    {
                        for (int k = array.GetLength(1) - 2 - i; k >= i; k--)
                        {
                            array[array.GetLength(0) - 1 - i, k] = count;
                            count++;
                            if (k == i)
                            {
                                for (int l = array.GetLength(0) - 2 - i; l >= i + 1; l--)
                                {
                                    array[l, i] = count;
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        i++;
    }
    return array;
}



int rows = Prompt($"Введите количество строк в массиве");
int columns = Prompt($"Введите количество столбцов в массиве");


int[,] array = SpiralArray(rows, columns);
PrintDimensionalArray(array);