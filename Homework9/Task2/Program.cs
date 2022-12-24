// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int NumeralSum(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    return M + NumeralSum(M + 1, N);
}

int M = Prompt("Введите первое число");
int N = Prompt("Введите второе число");
System.Console.WriteLine($"Сумма чисел в промежутке от {M} до {N} = {NumeralSum(M, N)}");