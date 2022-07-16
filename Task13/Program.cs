// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirthDigit(int num)
{
    if(number<100) 
    {
        return -1;
    }  
    while (number > 1000) 
    {
        number = number / 10;
    }
    int number1 = number;
    int find = number1 % 10;
    return find;
}
ThirthDigit(number);
int digit3 = ThirthDigit(number);
if(digit3 == -1) Console.Write($"{number} -> третьей цифры нет");
else Console.Write($" -> {digit3}");