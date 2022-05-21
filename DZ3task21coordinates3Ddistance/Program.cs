// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter the x coordinate of the point A: ");
double xA = double.Parse(Console.ReadLine());
Console.Write("Enter the y coordinate of the point A: ");
double yA = double.Parse(Console.ReadLine());
Console.Write("Enter the z coordinate of the point A: ");
double zA = double.Parse(Console.ReadLine());
Console.Write("Enter the x coordinate of the point B: ");
double xB = double.Parse(Console.ReadLine());
Console.Write("Enter the y coordinate of the point B: ");
double yB = double.Parse(Console.ReadLine());
Console.Write("Enter the z coordinate of the point B: ");
double zB = double.Parse(Console.ReadLine());

float getDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    float result = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))));
    return result;
}
Console.WriteLine("{0: 0.00}", getDistance(xA, yA, zA, xB, yB, zB));