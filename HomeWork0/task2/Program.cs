//  Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("наптшите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите втореое число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int maxNum = num1;
if (maxNum < num2)
{
    maxNum = num2;
}
if (maxNum < num3)
{
    maxNum = num3;
}
 Console.WriteLine($"максимальное сичло -> {maxNum}");