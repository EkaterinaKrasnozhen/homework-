// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    //int[] arr = new int[size]{2,5,6,7} конкретные значения или  int[] arr = {2,5,6,7}
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * 100), 1);
    }
    return arr;
}
double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[1];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        diff = max - min;
    }
    return diff;
}
void PrintArray(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length) Console.Write(num[i] + " ");
    }
}
double[] array = CreateArrayRndDouble(4, 1, 77);
PrintArray(array);
double result = Math.Round(DiffMaxMin(array), 1);
Console.Write($" ->  {result}");


//double d = 4.23434;
//double res = Math.Round(d, 1);