// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
double[] ColumnAverages(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double[] columnAvg = new double[col];
    for (int j = 0; j < col; j++)
    {
        int sum = 0;
        for (int i = 0; i < row; i++)
        {
            sum += array[i, j];
        }
        columnAvg[j] = (double)sum / row;
    }
    return columnAvg;
}
int row = ReadInt("Введите количество строк");
int col = ReadInt("Введите количество столбцов");
int[,] array = Generate2DArray(row, col);
Print2DArray(array);
double[] columnAvg = ColumnAverages(array);
Console.WriteLine("Средние арифметические значения для каждого столбца:");
for (int j = 0; j < col; j++)
{
    Console.WriteLine($"Столбец {j + 1}: {columnAvg[j]}");
}
