﻿// // Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

int GetDemension(string message)
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int[,,] InitMatrix(int firstDemension, int secondDemension, int thirdDemension)
{
    int[,,] matrix = new int[firstDemension, secondDemension, thirdDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
        {
            for (int k = 0; k < thirdDemension; k++)
            {
                matrix[i, j, k] = rnd.Next(0, 10);
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
           { Console.Write($"{matrix[i,j, k]} index {i}.{j}.{k}. ");

             Console.WriteLine();
           }
      }
        
    }
}


int firstDemension = GetDemension("Enter lenght of the X dimension:");
int secondDemension = GetDemension("Enter lenght of the Y dimension:");
int thirdDemension = GetDemension("Enter lenght of the Z dimension:");

int[,,] resultMatrix = InitMatrix(firstDemension, secondDemension, thirdDemension);

PrintMatrix(matrix: resultMatrix);