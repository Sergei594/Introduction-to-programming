// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointB = Convert.ToInt32(Console.ReadLine());
double distance = Distance(xPointA, yPointA, xPointB, yPointB);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");

double Distance(int xA, int yA, int xB, int yB)
{
return Math.Sqrt(Math.Pow(xA-xB, 2)+Math.Pow(yA-yB, 2));
}