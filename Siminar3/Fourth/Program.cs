// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int start = 1;

int number = Promt("Введите число");

if (number < 0)
{
    number = number * (-1);
}

while (start <= number)
{
    System.Console.Write($"{Math.Pow(start, 2)} ");
    start++;
}