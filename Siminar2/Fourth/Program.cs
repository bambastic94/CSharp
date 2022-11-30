// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число >");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {number} не кратно 7 и 23");
}
