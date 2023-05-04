//  Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.
Console.Clear();
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); // \t табуляция мас
    }
    Console.WriteLine();
}
int[] Copy(int[] massive)
{
int[] copyArray = new int[massive.Length];
for (int i = 0; i < massive.Length; i++)
{
copyArray[i] = massive[i];
}
return copyArray;
}
int[] origin = new int[] { 0, 1, 2, 3 };
int[] array = origin;
origin[0] = 100;
PrintArray(origin);
PrintArray(array);
int[] copired = Copy(origin);
origin[1] = 200;
PrintArray(origin);
PrintArray(array);


