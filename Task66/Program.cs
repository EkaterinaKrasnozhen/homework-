/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, больше первого ");
int num2 = Convert.ToInt32(Console.ReadLine());
int NaturalNumaber(int number1, int number2) //4,3,2,1 b 0 выход
{

    if (number1 == number2)
    {
        Console.WriteLine(number1);
    }
    int sum = 0;
    sum += number1;
    if (number1 < number2)
    {
        sum += NaturalNumaber(number1 + 1, number2);
    }
    return sum;
}

int res = NaturalNumaber(num1, num2);
Console.Write($"M = {num1}, N = {num2} -> {res}");