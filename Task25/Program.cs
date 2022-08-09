// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.WriteLine("Введите число А:" );
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:" );
int b = Convert.ToInt32(Console.ReadLine());
int Degree(int first, int second) 
{
    int count = 1;
    int degree = first;
while (count < second)
{
    degree=degree*first;
    count++;
}
return degree;
}
Console.WriteLine ($" {a}, {b} -> {Degree(a,b)}");