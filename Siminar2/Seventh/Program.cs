// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да

System.Console.Write("Input number >");
int number = Convert.ToInt32(Console.ReadLine());

int random()
{
    int rand = new Random().Next();
    return rand;
}

int randnumber = random();

int crat = randnumber % number;

int k = 1;

while (crat != 0)
{
    System.Console.WriteLine($"Число {randnumber} не кратно {number}");
    randnumber = random();
    crat = randnumber % number;
    k++;
}

System.Console.WriteLine($"Число {randnumber} кратно {number}, попытка {k}");

// while(true)
// {
//     .....
//     .....
//     .....
//     if(...)
//     {
//         break;
//     }
// }

// while (true)
// {
//     int value = new Random().Next(0, 10);
//     Console.WriteLine(value);
//     if (value % div == 0)
//     {
//         Console.WriteLine($"Мы нашли делитель, это - {value}");
//         break;
//     }
// }