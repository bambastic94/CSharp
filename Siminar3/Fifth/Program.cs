// Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов в диапазоне от 1 до 10, 
// и подсчитывает, сколько сгенерировалось чисел больше 5.

int[] numArray = new int[10];
int high = 0;

System.Console.WriteLine("Матрица:");

for (int i = 0; i < numArray.Length; i++)
{
    int tmp = new Random().Next(1, 11);
    numArray[i] = tmp;
    if (numArray[i] > 5)
    {
        high++;
    }
    System.Console.Write($"{numArray[i]} ");
}

System.Console.WriteLine($"Чисел больше 5 - {high}");