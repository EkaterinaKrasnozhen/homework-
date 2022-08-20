/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
 1  2  3 4
12 13 14 5
11 16 15 6
10  9  8 7   */

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
int[,] matrnew = GetMatrix(4, 4);
PrintMatrix(matrnew);
/* void SpiralMatrix(int[,] matr)
{
    int i = 0;
    int j = 0;
    while (j < matr.GetLength(1))
    {
        Console.Write($"{matr[i, j],3}]");
        j++;
    }

}
SpiralMatrix(matrnew); */
void SortMatrixRow(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int minPosition = j;
        for (int m = j + 1; m < matrix.GetLength(1); m++)
        {
            if (matrix[i, m] < matrix[i, minPosition]) minPosition = m;
        }
        int temporary = matrix[i, j];
        matrix[i, j] = matrix[i, minPosition];
        matrix[i, minPosition] = temporary;
    }
   }

}
Console.WriteLine();
SortMatrixRow(matrnew);
PrintMatrix(matrnew);