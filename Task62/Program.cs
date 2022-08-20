/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
 1  2  3 4
12 13 14 5
11 16 15 6
10  9  8 7   */

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = count;
            count++;
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
            Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine();
    }
}
int[,] SpiralMatrix(int[,] matr)
{
    int[,] spiral = new int[matr.GetLength(0), matr.GetLength(1)];
    int n = 0;
    int m = 0;
    int i = 0;
    int j = 0;
    while (j < matr.GetLength(1))
    {
        while (m < spiral.GetLength(1))
        {
            spiral[n, m] = matr[i, j];
            j++;
            m++;
        }
    }
    m = spiral.GetLength(0) - 1;
    i = 1;
    n = 1;
    j = 0;
    while (n < spiral.GetLength(0))
    {
        while (j < matr.GetLength(1) - 1)
        {
            spiral[n, m] = matr[i, j];
            n++;
            j++;
        }
    }
    n = spiral.GetLength(1) - 1;
    m = spiral.GetLength(1) - 1;
    i = 1;
    j = matr.GetLength(0) - 2;
    while (j < matr.GetLength(1))
    {
        spiral[n, m] = matr[i, j];
        m--;
        j++;
    }
    n = spiral.GetLength(1) - 1;
    m = spiral.GetLength(1) - 3;
    i = 2;
    j = 0;
    while (m >= 0)
    {
        spiral[n, m] = matr[i, j];
        m--;
        j++;
    }
    n = spiral.GetLength(0) - 2;
    m = 0;
    i = matr.GetLength(1) - 2;
    j = matr.GetLength(0) - 2;
    while (n > spiral.GetLength(0) - 4)
    {
        spiral[n, m] = matr[i, j];
        n--;
        j++;
    }
    n = spiral.GetLength(0) - 3;
    m = spiral.GetLength(1) - 3;
    i = matr.GetLength(0) - 1;
    j = 0;
    while (m < spiral.GetLength(1) - 1)
    {
        spiral[n, m] = matr[i, j];
        m++;
        j++;
    }
    n = spiral.GetLength(0) - 2;
    m = spiral.GetLength(1) - 2;
    i = matr.GetLength(0) - 1;
    j = matr.GetLength(1) - 2;
    while (j < matr.GetLength(1))
    {
        spiral[n, m] = matr[i, j];
        m--;
        j++;
    }

    return spiral;
}
int[,] matrnew = GetMatrix(4, 4);
PrintMatrix(matrnew);
Console.WriteLine();
int[,] spiral1 = SpiralMatrix(matrnew);
PrintMatrix(spiral1);
