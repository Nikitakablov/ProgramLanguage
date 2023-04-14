// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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
int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной ведичины");
int maxRnd = ReadInt("Введите границу максимума случайной ведичины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
int number = Double(array);
Console.WriteLine(number);
