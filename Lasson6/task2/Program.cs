// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}
int sideA = ReadInt("Введите сторону А ");
int sideB = ReadInt("Введите сторону B ");
int sideC = ReadInt("Введите сторону C ");
string text = "не может";
if (sideA < sideB + sideC)
{
    if (sideB < sideA + sideC)
        if (sideC < sideB + sideA)
        {
           text = "может";
        }
}
System.Console.WriteLine(text);