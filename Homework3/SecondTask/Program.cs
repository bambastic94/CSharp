// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Input coordinates of first point:");
int coorX1 = Promt("X1: ");
int coorY1 = Promt("Y1: ");
int coorZ1 = Promt("Z1: ");

System.Console.WriteLine("Input coordinates of second point:");
int coorX2 = Promt("X2: ");
int coorY2 = Promt("Y2: ");
int coorZ2 = Promt("Z2: ");

double distance = Math.Sqrt(Math.Pow((coorX2-coorX1), 2)+Math.Pow((coorY2-coorY1), 2)+Math.Pow((coorZ2-coorZ1), 2));

System.Console.WriteLine($"Distance between two points is {distance:F3}");