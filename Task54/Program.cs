/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного 
массива.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8 */
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 8);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}|");
            else Console.Write($"{matr[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void SortMatrixRow(int[,] matrix)
{
    int i = 0;
    while (i < matrix.GetLength(0))
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int m = j + 1; m < matrix.GetLength(1); m++)
            {
                if (matrix[i, m] > matrix[i, maxPosition]) maxPosition = m;
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, maxPosition];
            matrix[i, maxPosition] = temporary;
        }
        i++;
    }
}
int[,] matrixRandom = GetMatrix(3, 4);
PrintMatrix(matrixRandom);
SortMatrixRow(matrixRandom);
Console.WriteLine();
PrintMatrix(matrixRandom);

