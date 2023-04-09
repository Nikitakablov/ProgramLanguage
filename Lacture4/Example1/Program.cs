// 
string[,] table = new string[2, 5]; // создание двумерного массива где 2 кол-во строчек 5 кол-во столбцов
// String.Empty - иницилизация строк 
// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]
// table[1, 2] = "слово"; // обращаемся к нужному элементу
//                        //далее ниже распечатываем массив 
// for (int rows = 0; rows < 2; rows++)
// // счетчик строк
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"{table[rows, columns]}-"); // распечатывание  элементов массива 
//     }                      // индекс строки и столбца
// }

// определяем двумерный массив 
void PrintArray(int[,] mat)
{
    for (int i = 0; i < /*3*/mat.GetLength(0); i++) // i (внешний цикл, щёлкающий строки),
    {
        for (int j = 0; j < /*4*/mat.GetLength(1); j++) // (внутренний цикл, щёлкающий столбцы)
        {
            Console.Write($"{mat[i, j]} "); // в прошлом примере был дефис, поставим пробел
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] mat)
{
    for (int i = 0; i < /*3*/mat.GetLength(0); i++)
    {
        for (int j = 0; j < /*4*/mat.GetLength(1); j++) 
        {
            mat[i,j] = new Random().Next(1,10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix); // печатает массив из 0
FillArray(matrix); // заполняет массив воспользовавшись функцией рандомного заполнения
Console.WriteLine(); // прослойка между массивами в терминале
PrintArray(matrix); // печатает уже заполнянный массив