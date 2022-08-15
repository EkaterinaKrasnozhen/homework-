/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет */
int [,] GetMatrix(int m, int n) 
{
 int[,] matrix = new int[m,n];
 
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
    }
 }
 return matrix;
}
void PrintMatrix(int [,] matr) 
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
int GetNumMatrix(int [,] matr, int userinput1, int userinput2)

{
 for (int i = 0; i < matr.GetLength; i++)
 {
    for (int j = 0; j < matr.GetLength; j++)
    {
        if (i == userinput1|| j == userinput2 )
    }
 }
 
}