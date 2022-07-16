// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите цифру от 1 до 7 включительно ");
int number = Convert.ToInt32(Console.ReadLine());
int DayWeek(int num)
{
    if (number == 6 || number == 7) Console.WriteLine($"{number}-> да");
      else if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5) Console.WriteLine($"{number} -> нет");
       else if (number < 1 || number >7) Console.WriteLine($"{number} не является числом от 1 до 7");
return number;
}            
DayWeek(number);

//Андрей, подскажите, почему у меня два раза пишется ответ?