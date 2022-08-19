/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */
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

int[] SumRow(int[,] matr)
{
    int[] result = new int[matr.GetLength(1)];
    int sum = 0;
    int i = 0;
    int j = 0;
    while (i < matr.GetLength(1))
    {
        while (j < matr.GetLength(0))
        {
            sum += matr[i, j];
            j++;


        }
        result[i] = sum;
        i++;
        j = 0;
        sum = 0;
    }

    return result;
}
int FindMinSumRow(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        { 
            min = array[i];
            index = i+1;
        }
    }
    return index;
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length) Console.Write(num[i] + " ");
    }
}
int[,] matrNew = GetMatrix(4, 4);
PrintMatrix(matrNew);
Console.WriteLine();
int[] sum = SumRow(matrNew);
Console.WriteLine("сумма элементов в каждой строке ");
int res = FindMinSumRow(sum);
PrintArray(sum);
Console.WriteLine($" в строке {res} наименьшая сумма элементов");