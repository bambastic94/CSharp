// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

System.Console.Write("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 || number > 100000)
{
    System.Console.Write("Invalid number, tape another one: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number / 10000 == number % 10)
{
    if (((number/10)%10) == ((number/1000)%10))
    {
        System.Console.WriteLine($"Number {number} is palindrome");
    }
}
else
{
    System.Console.WriteLine($"Number {number} is not palindrome");
}