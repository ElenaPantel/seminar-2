// // Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

int Get3DArray(string message)
{
    Console.Write(message);
    int dimension = int.Parse(Console.ReadLine());
    return dimension;
}

int[,,] InitMatrix(int firstDimension, int secondDimension, int thirdDimension)
{
    int[,,] matrix = new int[firstDimension, secondDimension, thirdDimension];
    Random rnd = new Random();
    for (int i = 0; i < firstDimension; i++)
    {
        for (int j = 0; j < secondDimension; j++)
        {
            for (int k = 0; k < thirdDimension; k++)
            {
                matrix[i, j, k] = rnd.Next(10, 100);
            }
        }

    }

    return matrix;
}

void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} index {i}.{j}.{k}. ");

                Console.WriteLine();
            }
        }

    }
}


int firstDimension = Get3DArray("Enter X dimension length: ");
int secondDimension = Get3DArray("Enter Y dimension length: ");
int thirdDimension = Get3DArray("Enter Z dimension length: ");

int[,,] resultMatrix = InitMatrix(firstDimension, secondDimension, thirdDimension);

PrintMatrix(matrix: resultMatrix);