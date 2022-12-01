// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. Не использовать строки

System.Console.Write("Input numeral of day of the week >");
int number = Convert.ToInt32(Console.ReadLine());

while(true)
{
    if (number == 0 || number > 7)
    {
        System.Console.Write("Invalid number, try another:");
        number = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        switch (number)
        {
            case 1: Console.WriteLine("Monday is working day"); break;
            case 2: Console.WriteLine("Tuesday is working day"); break;
            case 3: Console.WriteLine("Wednesday is working day"); break;
            case 4: Console.WriteLine("Thursday is working day"); break;
            case 5: Console.WriteLine("Friday is working day"); break;
            case 6: Console.WriteLine("Saturday is day of"); break;
            case 7: Console.WriteLine("Sunday is day of"); break;
        }
        break;
    }
}