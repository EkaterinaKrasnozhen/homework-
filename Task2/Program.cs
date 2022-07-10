//Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Напишите целое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите другое целое число");
int second = Convert.ToInt32(Console.ReadLine());
if(first>second)
{
    Console.Write(first);
}
else 
Console.Write($"Максимальное из двух чисел {second}"); 



