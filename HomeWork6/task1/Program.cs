// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreatArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Введите {i + 1} - элемент");
    }
    return array;
}
// int[] CreatArray()
// {
//     int[] array = new int[4];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100);
//     }
//     return array;
// }
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t"); // \t табуляция мас
    }
    Console.WriteLine();
}
int Big0(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int length = ReadInt("Введите кол-во элементов - ");
int[] array = CreatArray(length);
PrintArray(array);
int cnt = Big0(array);
Console.WriteLine($"кол-во чисел больше 0 равно = {cnt} ");