// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

int Prompt(string message)
{
    Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M,int N)
{
    if (M == N)
    {
        Console.Write(N);
        return;
    }
    Console.Write($"{M}, ");
    PrintNumbers(M+1,N);
}

int M = Prompt("Введите первое число");
int N = Prompt("Введите второе число");
PrintNumbers(M,N);