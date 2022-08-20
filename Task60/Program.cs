/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */
int[,,] GetMatrix(int m, int n, int z)
{
    int[,,] matrix = new int[m, n, z];
    Random rnd = new Random();
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(1, 45);
            }
            
        }
    }
    return matrix;
}
int [,,] matr3 = GetMatrix(2,2,2);
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
            
            if (z < matr.GetLength(1)) Console.Write($"{matr[i, j, z],3} ({i},{j},{z}) ");
            
            }
        }
        Console.WriteLine();
    }
}
PrintMatrix(matr3);