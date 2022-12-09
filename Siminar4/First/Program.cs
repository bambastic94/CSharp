// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Введите число: ");
int count = 0;

int Counter(int number)
{
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

System.Console.WriteLine($"Количество цифр в числе {number} - {Counter(number)}");