/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.WriteLine("Введите значение b1= ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1= ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2= ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2= ");
double k2 = Convert.ToInt32(Console.ReadLine());
void FindPoint(double a1, double c1, double a2, double c2)
{
    if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые идентичны.");
    else if (k1 == k2) Console.WriteLine(" Точек пересечения нет");
    else
    {
        double x = (a2 - a1) / (c1 - c2);

        double y = k1 * x + b1;
        Console.WriteLine($" -> координаты точки пересечения двух прямых ({Math.Round(x, 1)};{Math.Round(y, 1)}) ");
    }
}
FindPoint(b1, k1, b2, k2);
