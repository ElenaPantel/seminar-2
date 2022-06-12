// SЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void NaturalNumbers(int m, int n)
{
    if (n < n) return;
    NaturalNumbers(m, n - 1);
    Console.Write($"{n}");
}
int SumNumbers(int m, int n)
{
    if (n > 0) return SumNumbers += (n - 1);
    else return 0;    
}

Console.Write("Enter the start number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the end number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"(The sum of natural numbers from M to N = {SumNumbers}");