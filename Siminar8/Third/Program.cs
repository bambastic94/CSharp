// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных. Значения элементов массива 0..9


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

int[] Dictionary(int[,] array)
{
    int[] dict = new int[10];
    for (int k = 0; k < 10; k++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(k == array[i,j])
                {
                    count++;
                }
            }
        }
        dict[k] = count;
    }
    return dict;
}

void PrintDictionary(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"fr[{i}] = {array[i]}\t");
    }
}


int rows = Prompt($"Введите количество строк в массиве");
int columns = Prompt($"Введите количество столбцов в массиве");
int minrange = Prompt($"Введите минимальную цифру для образования массива");
int maxrange = Prompt($"Введите максимальную цифру для образования массива");


int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);
PrintDimensionalArray(array);

int[] dictionary = Dictionary(array);
PrintDictionary(dictionary);