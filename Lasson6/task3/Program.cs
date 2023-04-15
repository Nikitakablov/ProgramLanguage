// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] Binary(int num)
{
    int[] array = new int[10];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = num % 2;
        num/=2;
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); // \t табуляция мас
    }
    Console.WriteLine();
}
int num = ReadInt("Введите число ");
int [] massiv = Binary(num);
PrintArray(massiv);
// PrintArray(Binary(num));

