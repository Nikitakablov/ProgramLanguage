//  Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}
double[,] Generate2DArray(int cntRows, int cntColumns)
{
    Random rnd = new Random();
    double[,] array = new double[cntRows, cntColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble();
        }
    }
    return array;
}
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j],2)}\t");
        }
        Console.WriteLine();
    }
}
int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
double[,] array = Generate2DArray(rows, columns);
Print2DArray(array);