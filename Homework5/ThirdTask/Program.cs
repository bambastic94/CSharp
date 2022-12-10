// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

double[] GenerateArray(int length, double minrange, double maxrange)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minrange + (maxrange - minrange) * (new Random().NextDouble());
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]:F2}\t");
    }
}

double Differance(double[] array)
{
    double max = array[0];
    double min = array[1];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    return diff;
}


int length = Promt($"Введите длину массива");
double minrange = PromtDouble($"Введите минимальную цифру для образования массива");
double maxrange = PromtDouble($"Введите максимальную цифру для образования массива");

double[] array = GenerateArray(length, minrange, maxrange);
PrintArray(array);
System.Console.WriteLine($"\nРазница между максимальным и минимальным значениями = {Differance(array):F2}");