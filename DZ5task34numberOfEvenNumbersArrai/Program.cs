// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int[] nums = new int[9];
var numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(100, 1000);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();

int j = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        j = j + 1;
    }
}
Console.Write($"Number of even numbers in the array is {j}");
