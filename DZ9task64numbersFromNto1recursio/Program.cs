// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter any integer number N > 0: ");
int number = int.Parse(Console.ReadLine());

void NaturalNum(int num)
{
    if (num == 0) return;
    if (num < 0) Console.Write($"{num} not a natural number");
    Console.Write($"{num,0}, ","");
    NaturalNum(num - 1);
}

NaturalNum(number);