// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

System.Console.WriteLine("Введите трехзначное число >");
int number = Convert.ToInt32(Console.ReadLine());

while(true)
{
    if (number < 100 || number >= 1000)
    {
        System.Console.WriteLine("Неверно, введите еще раз:");
        number = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        int chislo = (number / 10) % 10;
        System.Console.WriteLine($"Вторая цифра равна {chislo}");
        break;
    }
}