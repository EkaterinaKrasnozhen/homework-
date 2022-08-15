/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

double [,] GetMatrix(int m, int n) 
{
 double [,] matrix = new double[m,n];
 
 Random rnd = new Random();
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round(rnd.NextDouble() *12-5, 1);
        
    }
    
 }
 return matrix;
}
void PrintMatrix(double [,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == 0) Console.Write ("[");
        if (j < matr.GetLength(1)-1) Console.Write ($"{matr[i,j], 3}|");
        else  Console.Write ($"{matr [i,j], 3}]");
    }
    Console.WriteLine();
    }
}

double [,] matrixRes = GetMatrix(3,4);
PrintMatrix(matrixRes);
