//  Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. // 6 -> да
 // 1 -> нет
int ReadInt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}