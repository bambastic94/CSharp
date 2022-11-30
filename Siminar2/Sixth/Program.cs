// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int quantity = Prompt("Введите колличество чисел");
double sum = 0;

for (int i = 1; i <= quantity; i++)
{
    int number = Prompt("Введите число " + i);
    sum = sum + number;
}
System.Console.WriteLine($"Сумма {quantity} чисел равна {sum}, среднее арифметичекое {sum/quantity}");