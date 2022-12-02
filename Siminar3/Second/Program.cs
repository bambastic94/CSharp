// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)


int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int quarter = Promt("Введите четверть");

switch (quarter)
{
    case 1:System.Console.WriteLine("Диапазон значений X>0,Y>0");break;
    case 2:System.Console.WriteLine("Диапазон значений X<0,Y>0");break;
    case 3:System.Console.WriteLine("Диапазон значений X<0,Y<0");break;
    case 4:System.Console.WriteLine("Диапазон значений X>0,Y<0");break;
    default: System.Console.WriteLine("Не соответствует номеру четверти!"); break;
}
