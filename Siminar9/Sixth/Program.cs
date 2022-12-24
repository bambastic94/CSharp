// Проверка на простое число:
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool SimpleNumber(int number, int del)
{
    if (number <= 3 || del == 3)
    {
        return true;
    }
    if (number == 4 || number % (del - 1) == 0)
    {
        return false;
    }
    return SimpleNumber(number, del - 1);
}

// bool SimpleNumber(int number, int divider)
// {
//     if (divider == 1)
//     {
//         return true;
//     }
//     if (number % divider != 0)
//     {
//         return SimpleNumber(number, divider - 1);
//     }
//     else
//     {
//         return false;
//     }
// }
// bool SimpleNumber1(int number)
// {
//     return SimpleNumber(number, number - 1);
// }

int number = Prompt($"Введите число");

if (SimpleNumber(number, number))
{
    Console.WriteLine($"Число {number} простое");
}
else
{
    Console.WriteLine($"Число {number} не простое");
}