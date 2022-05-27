//Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());
int number = a;

int sum = 0;

while (a > 0)
{
    sum += a % 10;
    a /= 10;
}

Console.WriteLine($"The sum of the digits in the number {number} is {sum}");