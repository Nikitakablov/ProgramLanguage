// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); // \t табуляция мас
    }
    Console.WriteLine();
}
int[] Fibonachi(int somthing)
{
    if (somthing <= 1)
    {
        return new int[1];
    }
    int[] array = new int [somthing];
    array [0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
int num = ReadInt("Введите число ");
PrintArray(Fibonachi(num));