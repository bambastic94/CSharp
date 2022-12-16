// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool TriangleCheck(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B)
    {
        return true;
    }
    return false;
}


int A = Promt($"Введите длинну первой стороны треугольника");
int B = Promt($"Введите длинну второй стороны треугольника");
int C = Promt($"Введите длинну третьей стороны треугольника");

if (TriangleCheck(A,B,C))
{
    System.Console.WriteLine("Такой треугольник существует");
}
else
{
    System.Console.WriteLine("Такой треугольник не существует");
}


