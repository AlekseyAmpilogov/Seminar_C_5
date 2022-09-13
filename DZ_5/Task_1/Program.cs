Console.Write("Задайте размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine()); // задаем размер массива
int[] array = new int[size]; // создаем массив

Console.Write("Получен массив: ");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]} "); // вывод полученного массива на экран
    }
}
void PrintArray(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"всего {array.Length} чисел в массиве, {count} из них четные");
}

FillArray(array);
PrintArray(array);
