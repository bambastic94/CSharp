// Определите, является ли число степенью двойки

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool PowerOfTwo(int number)
{
    if (number == 2 || number == 0)
    {
        return true;
    }
    if (number % 2 == 1)
    {
        return false;
    }
    return PowerOfTwo(number / 2);
}

// bool PowerTwo(int number)
// {
//     if (number == 2)
//     {
//         return true;
//     }
//     return (number % 2 == 0) && PowerTwo(number / 2);
// }

int number = Prompt($"Введите число");

if (PowerOfTwo(number))
{
    Console.WriteLine($"Число {number} является степенью двойки");
}
else
{
    Console.WriteLine($"Число {number} не является степенью двойки");
}