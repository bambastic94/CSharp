// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int checkit(int number)
{
    int max = number % 10;
    // int edinica = value1 % 10;
    // int desyatki = value1 / 10; - так как int целое число
    int check = (number - max) / 10;
    if(check > max)
    {
        max = check;
    }
    return max;
}

// int value1 = new Random().Next(10, 100);



Random rnd = new Random();
int number = rnd.Next(10,100);

System.Console.WriteLine($"Случайное число {number}, а большая цифра здесь {checkit(number)}");


