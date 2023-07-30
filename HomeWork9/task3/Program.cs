// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// A(m, n) = n + 1,                 если m = 0
// A(m, n) = A(m - 1, 1),           если m > 0 и n = 0
// A(m, n) = A(m - 1, A(m, n - 1)), если m > 0 и n > 0

Console.Clear();
int ReadInt(string massage)
{
    System.Console.Write($"{massage} > ");
    return int.Parse(Console.ReadLine());
}
int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    else if (m > 0 && n > 0)
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return AckermanFunction(m,n);    
}
int m = ReadInt("Введите неотрицательное число m: ");
int n = ReadInt("Введите неотрицательное число n: ");
int result = AckermanFunction(m, n);
Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
