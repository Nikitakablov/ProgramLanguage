// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,
Console.Clear();
int[] CreatArray()
{
    int[] res = new int[8];
    for(int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(0,2);
    }
    return res;
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}  
int ReadInt(string message)
{
    Console.Write($"{message} > "); // ввод приглашения
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}
int Count1(int[] array, int num)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            count++;
        }
    }
    return count;
}
int[] massiv = CreatArray();
PrintArray (massiv);
int num = ReadInt("Введите число: ");
System.Console.WriteLine($"кол-во {num} равно {Count1(massiv, num)} ");

