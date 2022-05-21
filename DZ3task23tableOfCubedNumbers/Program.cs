// Задача 23: Напишите программу, которая принимает на 
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125

Console.Write("Enter a number, please: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("|{0,10} | {1,10}|", "Number", "Cube");
for (int i = 1; i <= num; i++)
{
    //Console.WriteLine("|{0,10} | {1,10}|", i, i*i*i);
    //Console.WriteLine("5^3 = " + Math.Pow(i, stepen));
    Console.WriteLine("|{0,10} | {1,10}|", i, +Math.Pow(i, 3));
}