int N = 12;
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($" {array[i]} ");
}

int negSum = 0;
int posSum = 0;
for (int i = 0; i < N; i++)
{
    if (array[i] < 0)
    {
        negSum = negSum + array[i];
    }
    else
    {
        posSum = posSum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма отрицательных чисел " + negSum);
Console.WriteLine("Сумма положительных чисел " + posSum);