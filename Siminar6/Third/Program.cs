// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int ArrayLength(int number)
{
    int i = 0;
    while (number >= 1)
    {
        number /= 2;
        i++;
    }
    return i;
}

string ToBinary(int number)
{
    int[] array = new int[ArrayLength(number)];
    string binary = "";

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number % 2;
        number /= 2;
        if (number == 1) array[array.Length - 1] = 0;
        else if (number == 2) array[array.Length - 1] = 1;
    }

    for (int j = 0; j < array.Length; j++)
    {
        binary += array[array.Length-1-j];
    }
    return binary;
}




int number = Promt($"Введите число");
System.Console.WriteLine($"\n{ToBinary(number)}");
