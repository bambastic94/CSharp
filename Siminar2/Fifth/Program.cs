// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8
// 1213-> 3
// 845 -> 8

int proverka(int ostatok)
{
    int dop = (ostatok / 10) % 10;
    return dop;
}

int number = new Random().Next(10, 10000);
int chislo = number;

int max = number % 10;
int k = 2;
int i = 1;

if (number > 100 & number < 1000)   k = 3;
if (number > 1000 & number < 10000) k = 4;

while( i < k )
{
    if (proverka(number) > max)
    {
        max = proverka(number);
    }
    number = number / 10;
    i++;
}

System.Console.WriteLine($"В числе {chislo} самая большая цифра {max}");
