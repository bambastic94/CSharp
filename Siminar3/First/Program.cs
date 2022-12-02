// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateQuarter (int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат равна 0");
        return false;
    }
    return true;
}

int GetQuarter(int x, int y)
{
    if (y > 0 && x > 0)
    {
        return 1;
    }

    if (y > 0 && x < 0)
    {
        return 2;
    }

    if (y < 0 && x < 0)
    {
        return 3;
    }
    return 4;
}

int coordX = Promt("Введите X");
int coordY = Promt("Введите X");

if (ValidateQuarter(coordX,coordY))
{
    int quarter = GetQuarter(coordX,coordY);
    System.Console.WriteLine($"Полученная четверть {quarter}");
}