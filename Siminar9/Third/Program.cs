// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.

int sum = 0;

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

void SumNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    sum += number % 10;
    SumNumbers(number / 10);
}

// int SumNumbers(int number)
// {
//     if (number == 0)
//     {
//         return 0;
//     }
//     return number % 10 + SumNumbers(number / 10);
// }
// System.Console.WriteLine(SumNumbers(Prompt("Введите число > ")));

int number = Prompt("Введите число");
SumNumbers(number);
System.Console.WriteLine($"Сумма цифр равна {sum}");