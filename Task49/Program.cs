﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void ChangeMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i += 2)
    {
        for (int j = 0; j < array2D.GetLength(1); j += 2)
        {

            array2D[i, j] *= array2D[i, j];

        }
    }
}


int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);

Console.WriteLine();

ChangeMatrix(array2D);
PrintMatrix(array2D);