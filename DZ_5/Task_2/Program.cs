Console.Write("Задайте размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine()); // задаем размер массива
int[] array = new int[size]; // создаем массив
Console.Write("Получен массив: ");
FillArray(array);
int sumSize = 0;

for (int j = 1; j < array.Length; j+=2)
    sumSize = sumSize + array[j];

Console.WriteLine();
Console.WriteLine($"Всего {array.Length} элементов, сумма стоящих на нечетных позициях = {sumSize}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($" {array[i]} "); // вывод полученного массива на экран
    }
}