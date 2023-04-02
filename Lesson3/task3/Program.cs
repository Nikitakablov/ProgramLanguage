// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}"); // ввод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
int ax = ReadInt("введите координаты AX");
int ay = ReadInt("введите координаты AY");
int bx = ReadInt("введите координаты BX");
int by = ReadInt("введите координаты BY");