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

// void Counter(int number)
// {
//     int index = 1;
//     int index_lev1 = 1;
//     while (true)
//     {
//         int index_counter = 1;
//         int counter_lev1 = index_lev1;
//         while (index_counter <= counter_lev1)
//         {
//             if (index <= number)
//             {
//                 Console.Write($"{counter_lev1}, ");
//                 index_counter++;
//                 index++;
//             }
//             else return;
//         }
//         index_lev1++;
//     }
// }