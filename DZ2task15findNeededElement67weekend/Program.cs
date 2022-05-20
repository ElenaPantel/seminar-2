// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Please, enter a day number 1-7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} -> weekend");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine($" {number} -> a work day");
}
else
{
    Console.WriteLine("Sorry, check the number you've entered. It should be from 1 to 7.");
}
