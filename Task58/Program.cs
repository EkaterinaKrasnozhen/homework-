/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
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
int[,] matrix1 = GetMatrix(2, 2);
int[,] matrix2 = GetMatrix(2, 2);
void PrintMatrixTwo(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            if (j < matr1.GetLength(1) - 1) Console.Write($"{matr1[i, j],3}");
            else Console.Write($"{matr1[i, j],3} |");
        }

        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            Console.Write($"{matr2[i, j],3}");
        }
        Console.WriteLine();
    }
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
PrintMatrixTwo(matrix1, matrix2);
Console.WriteLine();
int[,] MultiMatrix(int[,] matr1, int[,] matr2)
{
    int[,] multimatr = new int[matr1.GetLength(0), matr1.GetLength(1)];
    int n = 0;
    int m = 0;
    int i = 0;
    int j = 0;
    int k = 0;
    int l = 0;

    while (k < multimatr.GetLength(0))
    {
        while (n < matr2.GetLength(1))
        {
            multimatr[k, l] = matr1[i, j] * matr2[m, n] + matr1[i, j + 1] * matr2[m + 1, n];
            n++;
            l++;
        }
        k++;
        i++;
        n = 0;
        l = 0;
    }
    return multimatr;
}
Console.WriteLine();
int[,] matrNew = MultiMatrix(matrix1, matrix2);
PrintMatrix(matrNew);
