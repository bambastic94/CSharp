// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFn(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermanFn(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AckermanFn(m - 1, AckermanFn(m, n - 1));
    }
    return n;
}

int m = Prompt("Введите первое число");
int n = Prompt("Введите второе число");
System.Console.WriteLine($"A({m},{n}) = {AckermanFn(m, n)}");