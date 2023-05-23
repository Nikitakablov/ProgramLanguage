// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.
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
void SwapRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}
int cntColumns = ReadInt("Введите кол-во колонок");
int cntRows = ReadInt("Введите кол-во столбцов");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
Console.WriteLine();
SwapRows(table);
Print2DArray(table);
