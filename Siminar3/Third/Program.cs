// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int coordX1 = Promt("X1=");
int coordY1 = Promt("Y1=");
int coordX2 = Promt("X2=");
int coordY2 = Promt("Y2=");

double distance = Math.Sqrt(Math.Pow(coordX2-coordX1, 2)+Math.Pow(coordY2-coordY1, 2));

System.Console.WriteLine($"Расстояние между точками {distance:F2}");