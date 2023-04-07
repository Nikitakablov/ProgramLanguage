// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > "); // ввод приглашения
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool IsPalindrom(int num)
{
    int reversnum = 0;
    int fearstnum = num;
    while (num > 0)
    {
        int lastdigit = num % 10;
        reversnum = reversnum * 10 + lastdigit;
        num /= 10;
    }
    return fearstnum == reversnum;
}
int num = ReadInt("Введите пятизначное число: ");
if (IsPalindrom(num))
{
    Console.WriteLine("Число является палиндромом ");
}
else
{
    Console.WriteLine("Число не является палиндромом ");
}


