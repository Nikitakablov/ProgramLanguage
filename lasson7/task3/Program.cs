// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив        Новый массив будет выглядеть 
// вот так:                           выглядел вот так:
// 1 4 7 2                             1   4  7  2
// 5 9 2 3                             5  81  2  9
// 8 4 2 4                             8   4  2  4
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
int[,] SquareEvens(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i +=2)
    {
        for (int j = 1; j < array.GetLength(1); j +=2)
        {
            array[i, j] *= array[i, j];
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
int rows = ReadInt("Введите кол-во строк ");
int columns = ReadInt("Введите кол-во колонок ");
int[,] array = Generate2DArray(rows, columns);
Print2DArray(array);
int[,] array2 = SquareEvens(array);
Console.WriteLine();
Print2DArray(array2);



