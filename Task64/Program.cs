﻿/*  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
void SumNaturalNumaber(int number)
{
    if (number == 0) return;
    Console.Write($"{number} ");
    SumNaturalNumaber(number - 1);
}
Console.Write($"N = {num} -> ");
if (num == 0) Console.Write("0");
SumNaturalNumaber(num);