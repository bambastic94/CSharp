// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int PowerNumber(int number, int power)
{
    if (power == 0)
    {
        return 1;
    }
    return number * PowerNumber(number, power - 1);
}

int number = Prompt($"Введите число");
int power = Prompt($"Введите степень");
System.Console.WriteLine($"Число {number} в {power} степени = {PowerNumber(number, power)}");