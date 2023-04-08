// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumDigit(int num)
{
    int result = 0;
    while (num > 0)
    {
        int digit = num % 10;
        result = result + digit;
        num/= 10;
    }
    return result;
}
int num = ReadInt("Введите число: ");
Console.WriteLine($"сумма цифр в числе {num} равна {SumDigit(num)} ");