// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки A в трехмерном простанстве");
Console.Write("по оси X");
int ax1 = Convert.ToInt32(Console.ReadLine());
Console.Write("по оси Y");
int ay1 = Convert.ToInt32(Console.ReadLine());
Console.Write("по оси C");
int ac1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B в трехмерном простанстве");
Console.Write("по оси X");
int bx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("по оси Y");
int by2 = Convert.ToInt32(Console.ReadLine());
Console.Write("по оси C");
int bc2 = Convert.ToInt32(Console.ReadLine());
double S_aTob(int x1, int y1, int c1, int x2, int y2, int c2)
{
    int a = ((x2 - x1) * (x2 - x1));
    int b = ((y2 - y1) * (y2 - y1));
    int c = ((c2 - c1) * (c2 - c1));
    double s = Math.Sqrt(a + b + c);
    return s;
}
double result = S_aTob(ax1, ay1, ac1, bx2, by2, bc2);
Console.Write($"расстояние между точками А и В => ");
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));