// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number3 = number % 10;
if (number3 == 0) 
{
     Console.Write("нет третий цыфры: ");
}
else {
    Console.Write($"Третья цыфра числа {number3} ");
}

// int ReadInt(string message)
// {
//     Console.Write(message);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }
// int number = ReadInt("Введите число: ");
// int LastDigit = number % 10;
// Console.WriteLine($"последняя цифра числа {number} равна {LastDigit}");
