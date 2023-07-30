//Задайте значения M и N. Напишите программу, которая выведет все 
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
Console.Clear();
int ReadInt(string massage)
{
   Console.Write($"{massage} > ");
   return int.Parse(Console.ReadLine());
}
void EvenNumbers(int current, int N)
{
    if (current > N)
    {
        return;
    }
    if (current % 2 == 0)
    {
        System.Console.WriteLine(current);
    }
    EvenNumbers(current + 1,N);
}
int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
EvenNumbers(M, N);