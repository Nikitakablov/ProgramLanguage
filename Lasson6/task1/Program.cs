// Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}
double[] GenerateArray(int len, int minLimit, int maxLimit)
{
    double[] answer = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Math.Round(rnd.Next(minLimit, maxLimit) + rnd.NextDouble(), 4); //  Math.Round() округляет до такокото кол-ва знаков
    }
    return answer;
}
void PrintArrayDouble(double[] array)
{
    foreach(double item in array)
    {
        Console.Write($"{item:F2}\t");
    }
    Console.WriteLine();
}
double[] Reverse(double[]array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        double tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}
int len = ReadInt("Кол-во элементов массива > ");
int minLimit = ReadInt("Минимальное случайное значение  > ");
int maxLimit = ReadInt("Максимальное случайное значение > ");
double[] array = GenerateArray(len, minLimit, maxLimit);
PrintArrayDouble(array);
PrintArrayDouble(Reverse(array));