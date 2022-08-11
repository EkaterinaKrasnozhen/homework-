//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    //int[] arr = new int[size]{2,5,6,7} конкретные значения или  int[] arr = {2,5,6,7}
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int ShowEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length) Console.Write(num[i] + " ");
    }
}
int[] arr = CreateArrayRndInt(4, 100, 1000);
PrintArray(arr);
Console.WriteLine("-> " + ShowEvenNum(arr));
