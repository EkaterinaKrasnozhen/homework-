// Задача 4: Напишите программу, 
//которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Напишите целое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе целое число");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье целое число");
int thirth = Convert.ToInt32(Console.ReadLine());
int max = first;
if(max<second)
{
    max=second;
}
if(max<thirth)
{
    max = thirth;
}
Console.Write($"Максимальное из трех чисел {max}"); 

