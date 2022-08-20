/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */
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
int[,] matrix1 = GetMatrix(2, 3);
int[,] matrix2 = GetMatrix(2, 3);
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
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] MultiMatrix(int[,] matr1, int [,] matr2)
{
    int[,] multimatr = new int[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < multimatr.GetLength(0); i++)
    {
        for (int j = 0; j < multimatr.GetLength(1); j++)
        {
            multimatr[i, j] = matr1[i, j]*matr2[i,j];
        }
    }
    return multimatr;
}
Console.WriteLine();
int[,] matrNew = MultiMatrix(matrix1, matrix2);
PrintMatrix(matrNew);