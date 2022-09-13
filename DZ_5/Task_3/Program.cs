double[] array = new double[8]; // создаем массив
Console.Write("Получен массив: ");
FillArray(array);

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
        if (min > array[i])
    {
        min = array[i];
    }
}
double difference = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами = {difference}");

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($" {array[i]} "); // вывод полученного массива на экран
    }
}