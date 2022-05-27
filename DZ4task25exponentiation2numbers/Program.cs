// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Задачу решить без использования Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// int result = Math.Pow(numberA, numberB);

internal class NewBaseType
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number A: ");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Enter a number B: ");
        int numberB = int.Parse(Console.ReadLine());

        int exponentiation = 1;
        for (int i = 1; i <= numberB; i++)
        {
            exponentiation = exponentiation * numberA;            
        }
        Console.WriteLine($"Exponentiation of two numbers: {numberA} raised to the power of {numberB} = {exponentiation}");
     

    }
}
