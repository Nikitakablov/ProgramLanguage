// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > "); // ввод приглашения
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}
int theardDigit(int number)
{
    while (number >= 1000)
    number /= 10;
    int last = number % 10;
    return last;
}
int number = ReadInt("Введите число: ");
if (number >= 100) 
{
    int last = theardDigit(number);
    Console.Write($"третья цифра числа {number} равна {last}: ");
}
else {
    Console.Write($"Третья цыфра числа нет ");
}

// int number = ReadInt("Введите число: ");
// int LastDigit = number % 10;
// Console.WriteLine($"последняя цифра числа {number} равна {LastDigit}");
