// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
void Palindrom(int num) 
{
    int one = num/10000;
    int two = (num/1000)%10;
    int five = num%10;
    int four = (num%100)/10;
    if (one == five && two == four) Console.Write("-> да");
    else if (10000>num || num >100000) Console.WriteLine ("Введено неверное число");
    else Console.WriteLine($" -> нет");
}
Palindrom(number);