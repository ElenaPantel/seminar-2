// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

int[,] matrixA = CreateArrayRandom(
    rows: ReadInteger("Enter the number of rows of the matrix А: "),
    columns: ReadInteger("Enter the number of columns of the matrix А: "),
    minValue: -9,
    maxValue: 9
);

int[,] matrixB = CreateArrayRandom(
    rows: ReadInteger("Enter the number of rows of the matrix B: "),
    columns: ReadInteger("Enter the number of columns of the matrix B: "),
    minValue: -9,
    maxValue: 9
);
Console.WriteLine("Matrix A:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix B:");
PrintArray(matrixB);
Console.WriteLine();

int[,] matrixС = MatrixMultiplication(matrixA, matrixB);

if (matrixС.GetLength(0) != 0)
{
    Console.WriteLine("Matrix A x Matrix B = Matrix C: ");
    PrintArray(matrixС);
}
else
{
    Console.WriteLine("No product for these matrix");
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        return new int[0, 0];

    int[,] matrixС = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int row = 0; row < matrixС.GetLength(0); row++)
        for (int col = 0; col < matrixС.GetLength(1); col++)
        {
            matrixС[row, col] = 0;
            for (int i = 0; i < matrixA.GetLength(1); i++)
                matrixС[row, col] += matrixA[row, i] * matrixB[i, col];
        }
    return matrixС;
}

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}