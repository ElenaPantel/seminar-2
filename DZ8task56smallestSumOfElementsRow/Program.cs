//Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = CreateArrayRandom(
    rows: ReadInteger("Enter the number of rows m= "),
    columns: ReadInteger("Enter the number of columns n="),
    minValue: -99,
    maxValue: 99
);

int[] rowSum = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        rowSum[i] += array[i, j];

Console.WriteLine("Initial array:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine($"      | sum = {rowSum[i]}");
}

int minSumRow = 0;
for (int i = 0; i < rowSum.Length; i++)
    if (rowSum[i] < rowSum[minSumRow])
        minSumRow = i;

Console.WriteLine();
Console.WriteLine($"Row with the smallest sum of the elements: ");
for (int j = 0; j < array.GetLength(1); j++)
    Console.Write($"{array[minSumRow, j]} ");

int[,] CreateArrayRandom(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int ReadInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}