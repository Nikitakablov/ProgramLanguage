// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}"); // ввод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
int ax = ReadInt("введите координаты AX > ");
int ay = ReadInt("введите координаты AY > ");
int az = ReadInt("введите координаты AZ > ");
int bx = ReadInt("введите координаты BX > ");
int by = ReadInt("введите координаты BY > ");
int bz = ReadInt("введите координаты BZ > ");
double distance = Math.Sqrt(Math.Pow(ax - bx,2) + Math.Pow(ay - by,2) + Math.Pow(az - bz,2));
Console.WriteLine($"Расстояние между двумя точками: {distance :f2}");
