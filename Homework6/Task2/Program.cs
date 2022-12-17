// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Promt(string massage)
{
    Console.Write($"{massage} = ");
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = Promt("b1");
double k1 = Promt("k1");
double b2 = Promt("b2");
double k2 = Promt("k2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
System.Console.WriteLine($"x = {x}\ny = {y}");

// Надеюсь я правильно её решил, по другому даже не знаю как