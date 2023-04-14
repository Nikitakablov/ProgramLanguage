// Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. 
// Найдите количество двузначных элементов массива.
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateArray(int length, int minRnd, int maxRnd)
{
int[] array = new int[length];
Random rnd = new Random();
for (int i = 0; i < length; i++)
{
array[i] = rnd.Next(minRnd, maxRnd + 1);
}
return array;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write($"{array[i]}\t");
}
System.Console.WriteLine();
}
int Double(int[] array)
{   
    int check = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (10 < array[i] & array[i] < 100)
        {
            check ++;
        }
    }
    return check;
}
int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной ведичины");
int maxRnd = ReadInt("Введите границу максимума случайной ведичины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
int number = Double(array);
Console.WriteLine(number);