/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
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
double ArithSumColumn(int[,] matr, int plusRow)
{
    int j = plusRow;
    double result = 0;
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        {
            sum += matr[i, j];
            result = Math.Round(sum / matr.GetLength(0),1);
            
        }
        
    }
    return result;
    
    
    
}

int[,] matNums = GetMatrix(3, 4);
PrintMatrix(matNums);
Console.WriteLine("Среднее арифметическое столбцов ");
Console.Write (ArithSumColumn(matNums,0));
Console.Write("  ");
Console.Write (ArithSumColumn(matNums,1));
Console.Write("  ");
Console.Write (ArithSumColumn(matNums,2));
Console.Write("  ");
Console.Write (ArithSumColumn(matNums,3));