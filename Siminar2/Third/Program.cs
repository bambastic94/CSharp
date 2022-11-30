// 3. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}


int number1 = Prompt("Введите первое число >");
int number2 = Prompt("Введите второе число >");

if (number1 % number2 == 0)
{
    System.Console.WriteLine($"{number1} кратно {number2}");
}
else
{
    int ostatok = number1 - (number1 / number2) * number2;
    System.Console.WriteLine($"{number1} не кратно {number2}, остаток {ostatok}");
}
