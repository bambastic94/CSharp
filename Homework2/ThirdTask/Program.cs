// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки

System.Console.Write("Input number >");
int number = Convert.ToInt32(Console.ReadLine());

int third = 0;
int num = number;

while (true)
{
    if (number < 100)
    {
        System.Console.WriteLine("Invalid number, tape another one:");
        number = Convert.ToInt32(Console.ReadLine());
        num = number;
    }
    else
    {
        while (number >= 1000)
        {
            number = number / 10;
        }
        third = number % 10;
        break;
    }
}

System.Console.WriteLine($"In number {num} third numeral is {third}");