// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] CreatArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t"); // \t табуляция мас
    }
    Console.WriteLine();
}
int EvenNum(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
}
int[] array = CreatArray();
Console.Write("Исходный массив: ");
PrintArray(array);
int evenCount = EvenNum(array);
Console.WriteLine($"Количество четных чисел: {evenCount} ");
