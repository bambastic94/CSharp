// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Multi(int number)
{
    int value = 1;

    for (int i = 1; i <= number; i++)
    {
        value = value * i;
    }
    return value;
}

int number = Promt("Введите число");

System.Console.WriteLine($"Факториал числа {number} равен {Multi(number)}");