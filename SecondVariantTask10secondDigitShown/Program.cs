//  Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//using System;

Console.Write("Enter three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3 ? $"{number} -> {numberS[1]}" : "Not a three digit number entered");

/* if(numberS.Length != 3) {
    Console.WriteLine("You have entered not a three digit number");
} else {
    Console.WriteLine($"{number} -> {numberS[1]}");
}
*/
