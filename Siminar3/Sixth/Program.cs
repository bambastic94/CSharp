// Напишите программу, которая выводит первые заданные элемента следующей последовательности:
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int length = Promt("Введите число");
int counter = 1;
int counterInside = 1;
int number = 1;

while (counter <= length)
{
    while (counterInside <= number && counter <= length)
    {
        System.Console.Write($"{number} ");
        counterInside++;
        counter++;
    }
    counterInside = 1;
    number++;
}
