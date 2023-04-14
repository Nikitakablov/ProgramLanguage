// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов
// массива.Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateteArray(int lenght, int minRnd, int maxRnd)
{
    int[] array = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
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
// int SumPositiv(int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//         sum += array[i];
//         }
//     }
//     return sum;
// }
// int SumNegativ(int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//         sum += array[i];
//         }
//     }
//     return sum;
// }
int SumSign(int[] array, bool isPositive = true)
{
    int sign = 1;
    if (!isPositive)
    {
        sign = -1;
    }

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * sign > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
int len = ReadInt("Введите длину массива ");
int minRnd = ReadInt("Введите границу минимум случайной величины ");
int maxRnd = ReadInt("Введите границу макс случайной величины ");
int[] array = CreateteArray(len, minRnd, maxRnd);
PrintArray(array);
Console.WriteLine($"Сумма положительных значений {SumSign(array)}");
Console.WriteLine($"Сумма отрицательных значений {SumSign (array, false)}");