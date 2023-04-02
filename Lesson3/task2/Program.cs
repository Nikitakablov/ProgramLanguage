// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}"); // ввод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
string GetRange(int Quarter)
{
    if (Quarter == 1)
        return ("X > 0, Y > 0");
    
    if (Quarter == 2)
        return ("X < 0, Y > 0");
    
    if (Quarter == 3)
        return ("X < 0, Y < 0");
    
    return ("X > 0, Y < 0");
}

bool ValedateXY(int Quarter)
{
    bool res = Quarter < 1 || Quarter > 4;
    if (res)
    {
        Console.WriteLine("такой нет четверти");
        return false;
    }
    return true;
}
int numberA = ReadInt("введите значение: ");
if (ValedateXY(numberA))
{
    string range = GetRange(numberA);
    Console.WriteLine(range);
}

