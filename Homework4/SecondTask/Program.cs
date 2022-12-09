// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int total(int number)
{
    int sum = 0;
    int temp = 0;
    while(number>0)
    {
        temp = number % 10;
        sum += temp;
        number /= 10;
    }
    return sum;
}

int number = Promt("Input number");

System.Console.WriteLine($"Sum of number is {total(number)}");