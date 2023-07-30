// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
Console.Clear();
int ReadInt(string massage)
{
    System.Console.Write($"{massage} > ");
    return int.Parse(Console.ReadLine());
}
int SumNaturalNum(int current, int N)
{
    if (current == N)
        return 0;
    return current + SumNaturalNum(current + 1,N);
}
int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
int sum = SumNaturalNum(M, N);
Console.WriteLine($"Сумма натуральных чисел от M до N: {sum}");