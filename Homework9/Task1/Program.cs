// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintEvenNumbers(int M, int N)
{
    if (M % 2 == 0 && M <= N)
    {
        System.Console.Write($"{M} ");
        PrintEvenNumbers(M + 2,N);
        return;
    }
    if(M > N)
    {
        return;
    }
    PrintEvenNumbers(M + 1,N);
}

int M = Prompt("Введите первое число");
int N = Prompt("Введите второе число");
PrintEvenNumbers(M,N);