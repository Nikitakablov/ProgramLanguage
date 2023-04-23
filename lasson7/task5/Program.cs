// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.
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
(int,int) Find(int[,] array, int num)// возврат из функции нескольких значений, кортеж
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            if(num == array[i,j])
            {
                return (i,j);
            }
         }
    }
    return (-1,-1);
}   
int rows = ReadInt("Введите кол-во строк ");
int columns = ReadInt("Введите кол-во колонок ");
int[,] array = Generate2DArray(rows, columns);
Print2DArray(array);
int num = ReadInt("Введите искомое значение ");
(int x, int y) = Find(array, num);
if (x != -1)// != не равен
{
    Console.WriteLine($"координаты вашего числа {x+1},{y+1} ");
}
else
{
    Console.WriteLine("результат: такого элемента нет");
}







