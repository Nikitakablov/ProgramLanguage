// Задайте двумерный массив. Найдите максимальный элемент массива 
// и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Максимальный элемент массива 9
// Среднее арифметическое 4.25
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int SearchMax(int[,] array)
{
    int max = array[0, 0];
    foreach (int item in array)
    {
        if (max < item)
        {
            max = item;
        }
    }
    return max;
}
double Average(int[,] array)
{
    double sum = 0;
    int max = array[0, 0];
    foreach (int item in array)
    {
        sum+=item;
    }
        return sum/array.Length;
}
int rows = ReadInt("Введите кол-во строк ");
int columns = ReadInt("Введите кол-во колонок ");
int[,] array = Generate2DArray(rows, columns);
Print2DArray(array);
Console.WriteLine($"Максимальное значение {SearchMax(array)}");
Console.WriteLine($"среднее арифметическое всех элементов массива.{Average(array)}");




