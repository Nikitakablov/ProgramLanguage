// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1
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
int GetElement(int[,] array, int row, int col)
{
    if (row < 0 || row >= array.GetLength(0) & col < 0 || col >= array.GetLength(1))
    {
        Console.WriteLine("Элемент не найден");
        return -1;
    }
    else
    {
        return array[row-1, col-1];
    }
}
int row = ReadInt("Введите количество строк");
int col = ReadInt("Введите количество столбцов");
int[,] array = Generate2DArray(row, col);
Print2DArray(array);
int x = ReadInt("Введите номер строки:");
int y = ReadInt("Введите номер столбца:");
int element = GetElement(array, x, y);
Console.WriteLine($"Значение элемента: {element}");