// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трезначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int ShowSecondDigit(int num) 
{
    int lastDigit = number/10;
    int secondDigit = lastDigit%10;
    return secondDigit;
}
ShowSecondDigit(number);
int find = ShowSecondDigit(number);
Console.WriteLine($"{number} -> {find}");