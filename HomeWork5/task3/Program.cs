//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int[] CreatArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
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
int Diferent(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i]; 
        }
        if (array[i] < min)
        {
            min = array[i]; 
        }
    }
    return max - min;
}
int[] array = CreatArray();
PrintArray(array);
int dif = Diferent(array);
Console.WriteLine($"Разница между макс и мин элементов массива равна: {dif} ");