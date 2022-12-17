// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

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
}

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    if (number >= 1) array[0] = 0;
    if (number >= 2) array[1] = 1;
    if (number >= 3)
    {
        for (int i = 2; i < number; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
    }
    return array;
}

int number = Promt("Какое количество чисел Фибоначчи вывести?");

while (number == 0) 
{
    number = Promt("Введите число больше 0");
}

int[] array = Fibonacci(number);



PrintArray(array);