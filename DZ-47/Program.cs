﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы - col
        {
            matrix[i, j] = rnd.Next (min, max + 1);
        }
    }
    return matrix;
}
    void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}");
                else Console.Write($"{matrix[i, j], 3}");
            }
            Console.WriteLine("]");
        }
   
    }
 int [,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
 PrintMatrix(array2D);