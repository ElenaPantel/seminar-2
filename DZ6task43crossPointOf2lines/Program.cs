//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Прямые параллельны при k1 == k2.

void IntersectionPoint()
{
    Console.Write("Enter the coefficient k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the coefficient b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the coefficient k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the coefficient b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    {
        Console.WriteLine("The straight lines are parallel, there's no point of intersection.");
    }

    else
    {
        double x = ((b2 - b1) / (k1 - k2));
        double y = (k2 * x + b2);
        Console.WriteLine($"Point of intersection of lines: [{Math.Round(x, 2)}, {Math.Round(y, 2)}].");
    }
}

IntersectionPoint();
Console.ReadLine();
