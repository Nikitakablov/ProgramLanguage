// Задача 1: Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
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
int rows = ReadInt("Введите кол-во строк ");
int columns = ReadInt("Введите кол-во колонок ");
int[,] array = Generate2DArray(rows, columns);
Print2DArray(array);