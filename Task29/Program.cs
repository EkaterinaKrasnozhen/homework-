// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
//псевдослучайными числами и выводит их на экран.

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
void FillArray(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(1, 100);
    }
}
void PrintNumbers(int [] numbers)
{
for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if (i != col.Length-1) 
        Console.Write(",");
    }
}
int [] array = new int [8];
FillArray(array);
PrintNumbers(array);
Console.Write(" -> [");
PrintArray(array);
Console.Write("]");