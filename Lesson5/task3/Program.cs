// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
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
bool Find(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            return true;
        }
    }
    return false;
}

int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной ведичины");
int maxRnd = ReadInt("Введите границу максимума случайной ведичины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
int number = ReadInt("Введите число ");
if (Find(array, number))
{
    Console.WriteLine($"Нашли число в массиве ");
}
else
{
    Console.WriteLine($"Нe нашли число в массиве ");
}
