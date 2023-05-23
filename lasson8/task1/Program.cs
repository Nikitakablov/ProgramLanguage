//  Задайте двумерный массив. Напишите программу, которая поменяет местами 
//первую и последнюю строку массива.
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] Generate2DArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
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
            Console.Write($"{(array[i, j])}\t");
        }
        Console.WriteLine();
    }
}
void Swap (int [,] array)
{
    int lastRow = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array [0,j];
        array[0,j] = array[lastRow, j];
        array[lastRow, j] = temp;
    }
}
int cntColumns = ReadInt("Введите кол-во колонок");
int cntRows = ReadInt("Введите кол-во столбцов");
int [,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
Console.WriteLine();
Swap(table);
Print2DArray(table);