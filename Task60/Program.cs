/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */


/* int [,,] RandomValue(int m, int n, int z)
{
    int[, ,] matrix = new int[m, n, z];
    int rnd = new int [,,] {1,2,3,4,5,6,7,8,9,0,10,11,12,13,14,15};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
               matrix[i, j, l] = rnd;
            }
            
        }
    }
    return matrix;
}
int [, ,] matr3d = RandomValue(2,2,2); */
int[, ,] matrix = new int[2, 2, 2]{{{1,2},{3,4}},{{5,6},{7,8,}}};//{{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                Console.Write($"{matr[i, j, z],3} ({i},{j},{z}) ");
            }
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);