// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]} ");
    }
    System.Console.WriteLine();
}

int[] CreateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CounterPositive(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) amount++;
    }
    return amount;
}

int count = Promt("Сколько чисел вы хотели бы ввести?");
int[] array = CreateArray(count);
PrintArray(array);
System.Console.WriteLine($"Количество введенных чисел больше 0 = {CounterPositive(array)}");