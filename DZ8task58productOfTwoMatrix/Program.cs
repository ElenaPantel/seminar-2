// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

int[,] matrixA = GetRandAraay(
    rows: ReadEnteredNum("Enter a number of rows of the matrix A: "),
    columns: ReadEnteredNum("Enter a number of columns of the matrix A: "),
    minValue: -9,
    maxValue: 9
);

int[,] matrixB = GetRandAraay(
    rows: ReadEnteredNum("Enter a number of rows of the matrix B: "),
    columns: ReadEnteredNum("Enter a number of columns of the matrix B: "),
    minValue: -9,
    maxValue: 9
);
Console.WriteLine("Matrix A:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix B:");
PrintArray(matrixB);
Console.WriteLine();

int[,] matrixC = MultiplicatMatrix(matrixA, matrixB);

if (matrixC.GetLength(0) != 0)
{
    Console.WriteLine("Matrix A x Matrix B = Matrix C: ");
    PrintArray(matrixC);
}
else
{
    Console.WriteLine("No product for these matrix");
}

int[,] MultiplicatMatrix(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        return new int[0, 0];

    int[,] MatrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int row = 0; row < MatrixC.GetLength(0); row++)
        for (int column = 0; column < MatrixC.GetLength(1); column++)
        {
            MatrixC[row, column] = 0;
            for (int i = 0; i < matrixA.GetLength(1); i++)
                MatrixC[row, column] += matrixA[row, i] * matrixB[i, column];
        }
    return MatrixC;
}

int[,] GetRandAraay(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int ReadEnteredNum(string message)
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