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
double[] ArithSumColumn(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    double sum = 0;
    int i = 0;
    int j = 0;
    while (j < matr.GetLength(1))
    {
        while (i < matr.GetLength(0))
        {
            sum += matr[i, j];
            i++;
            
            
        }
        result[j] = Math.Round(sum / matr.GetLength(0), 1);
        j++;
        i=0;
        sum=0;
    }

    return result;
}

int[,] matNums = GetMatrix(3, 4);
PrintMatrix(matNums);
Console.WriteLine("Среднее арифметическое столбцов ");
double[] arith = ArithSumColumn(matNums);
void PrintArray(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length) Console.Write(num[i] + " ");
    }
}
PrintArray(arith);
