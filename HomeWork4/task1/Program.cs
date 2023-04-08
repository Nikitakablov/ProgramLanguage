// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Involution(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}
int A = ReadInt("Введите число А: ");
int B = ReadInt("Введите число В: ");
Console.WriteLine($"{A} в степени {B} равно {Involution(A, B)}");


