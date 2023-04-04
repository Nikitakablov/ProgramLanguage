// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
bool Weekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}

int weekday = ReadInt("Введите номер дня недели: ");
if (Weekend(weekday))
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это рабочий день");
}