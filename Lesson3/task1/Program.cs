//Напишите программу, которая принимает на вход координаты точки (X и Y), причём
//X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > "); // ввод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return 0;
}
bool ValedateXY(int x, int y)
{
    bool res = x == 0 || y == 0;
    if (res)
    {
        Console.WriteLine("одна из координат находится на оси");
        return false;
    }
    return true;
}
int x = ReadInt("введите X");
int y = ReadInt("введите Y");
int numberQuartar = GetQuarter(x, y);
if (ValedateXY(x, y))
{
    Console.WriteLine($"Номер четверти для X,Y ({x},{y}) равна {numberQuartar} ");
}