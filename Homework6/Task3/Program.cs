// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

int RowsSumMaximum(int[,] array)
{
    int sum = 0;
    int max = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        max = array[i, 0];
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (max < array[i, j + 1]) max = array[i, j + 1];

            if (j == array.GetLength(1) - 2) sum += max;
        }
    }
    return sum;
}

int ColumnsSumMinimum(int[,] array)
{
    int sum = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min = array[0, i];
        for (int j = 0; j < array.GetLength(0) - 1; j++)
        {
            if (min > array[j + 1, i]) min = array[j + 1, i];
            
            if (j == array.GetLength(0) - 2) sum += min;
        }
    }
    return sum;
}

int rows = Promt($"Введите количество строк в массиве");
int columns = Promt($"Введите количество столбцов в массиве");
int minrange = Promt($"Введите минимальную цифру для образования массива");
int maxrange = Promt($"Введите максимальную цифру для образования массива");

int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);

PrintDimensionalArray(array);

int max = RowsSumMaximum(array);
int min = ColumnsSumMinimum(array);

System.Console.WriteLine($"{max} - {min} = {max - min}");