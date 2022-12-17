// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

(int?, int?) FindArrayElement(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (i,j);
            }
        }
    }
    return (null, null);
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
int number = Promt("Введите искомое число");

int[,] array = GenerateDimensionalArray(rows, columns, minrange, maxrange);

PrintDimensionalArray(array);

(int? rowElement, int? columnElement) = FindArrayElement(array, number);

if (rowElement == null)
{
Console.WriteLine("Такого элемента нет");
}
else
{
Console.WriteLine($"Число {number} находится на позиции[{FindArrayElement(array, number)}]");
}