/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите числа через запятую или пробел: ");
string[] text = Console.ReadLine().Split(',', ' ');
int[] StringCharToArray(string[] numString)
{
    int[] arrayChar = new int[numString.Length];
    for (int i = 0; i < numString.Length; i++)
    {
        if (numString[i] == string.Empty) Console.WriteLine("Вы ввели не верные значения");
        else arrayChar[i] = Convert.ToInt32(numString[i]);
        
    }
    
    return arrayChar;
    
}
int[] col = StringCharToArray(text);
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length) Console.Write(num[i] + " ");
    }
}
PrintArray(col);
int GreaterZero(int[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
        
    }
    return count;
}
int result = GreaterZero(col);
Console.Write($"-> чесел больше 0  = {result}");