/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */
Console.WriteLine("Введите неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int AkkerNums(int numM, int numN)
{

    if (numM < 0)
    {
        Console.WriteLine("Введено отрицательное число ");
        return numM;
    }
    else if (numN < 0)
    {
        Console.WriteLine("Введено отрицательное число ");
        return numN;
    }
    else if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return AkkerNums(numM - 1, 1);
    }
    else return AkkerNums(numM - 1, AkkerNums(numM, numN - 1));

}
int res = AkkerNums(m, n);
Console.WriteLine($" A(m,n) = {res}");